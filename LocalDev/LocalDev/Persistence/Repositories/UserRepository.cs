using LocalDev.Core.Domain;
using LocalDev.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;
using LocalDev.Core;
using LocalDev.Core.Helper;

namespace LocalDev.Persistence.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public string id = "";
        public bool error = false;
        public string errorMessage = "";

        public UserRepository(ProjectDataContext projectDataContext) : base(projectDataContext)
        {
        }

        public ProjectDataContext ProjectDataContext
        {
            get { return Context as ProjectDataContext; }
        }

        #region Conditions for search
        public enum SearchConditions
        {
            Id,
            Username,
            FullName,
            Phone,
            Address,
            Gender,
            Status,

            SortUsername_Desc
        }
        #endregion

        public User GetInfo(string id)
        {
            ProjectDataContext projectDataContext = new ProjectDataContext();
            return projectDataContext.Users.OrderBy(_ => _.Username).SingleOrDefault(_ => _.Id.Equals(id));
        }

        public IEnumerable<User> GetAll(Dictionary<SearchConditions, object> conditions)
        {
            ProjectDataContext projectDataContext = new ProjectDataContext();
            var query = from x in projectDataContext.Users
                        select x;

            if (!query.Any()) return new List<User>();
            if (conditions != null)
            {
                #region Check conditions
                if (conditions.Keys.Contains(SearchConditions.Id))
                {
                    string value = conditions[SearchConditions.Id].ToString();
                    query = query.Where(_ => _.Id.Equals(value));
                }
                if (conditions.Keys.Contains(SearchConditions.Username))
                {
                    string value = conditions[SearchConditions.Username].ToString();
                    query = query.Where(_ => _.Username.Contains(value));
                }
                if (conditions.Keys.Contains(SearchConditions.FullName))
                {
                    string value = conditions[SearchConditions.FullName].ToString();
                    query = query.Where(_ => _.FullName.Contains(value));
                }
                if (conditions.Keys.Contains(SearchConditions.Phone))
                {
                    string value = conditions[SearchConditions.Phone].ToString();
                    query = query.Where(_ => _.Phone.Contains(value));
                }
                if (conditions.Keys.Contains(SearchConditions.Address))
                {
                    string value = conditions[SearchConditions.Address].ToString();
                    query = query.Where(_ => _.Address.Contains(value));
                }
                if (conditions.Keys.Contains(SearchConditions.Gender))
                {
                    GlobalConstants.GenderValue value;
                    Enum.TryParse<GlobalConstants.GenderValue>(conditions[SearchConditions.Gender].ToString(), out value);
                    query = query.Where(_ => _.Gender == value);
                }
                if (conditions.Keys.Contains(SearchConditions.Status))
                {
                    GlobalConstants.StatusValue value;
                    Enum.TryParse<GlobalConstants.StatusValue>(conditions[SearchConditions.Status].ToString(), out value);
                    query = query.Where(_ => _.Status == value);
                }
                #endregion

                #region Sort by
                if (conditions.Keys.Contains(SearchConditions.SortUsername_Desc))
                {
                    bool value = (bool)conditions[SearchConditions.SortUsername_Desc];
                    if (value)
                    {
                        query = query.OrderByDescending(_ => _.Username);
                    }
                    else
                    {
                        query = query.OrderBy(_ => _.Username);
                    }
                }
                #endregion
            }
            return query.ToList();
        }

        public void Save(User user)
        {
            if (String.IsNullOrEmpty(user.Id))
            {
                Add(user);
            }
            else
            {
                Update(user);
            }
        }

        public void Add(User user)
        {
            error = false;
            errorMessage = "";
            try
            {
                user.Id = GetAutoID();
                user.Salt = SecurityHelper.CreateSalt(GlobalConstants.defaultSaltLength);
                user.Password = SecurityHelper.GenerateMD5(user.Password, user.Salt);
                user.CreatedAt = DateTime.Now;
                user.CreatedBy = GlobalConstants.username;
                var raw = ProjectDataContext.Set<User>().Add(user);
                id = raw.Id;
            }
            catch (Exception ex)
            {
                error = true;
                errorMessage = ex.ToString();
            }
        }

        public void Update(User user)
        {
            error = false;
            errorMessage = "";
            try
            {
                var query = from x in ProjectDataContext.Users
                            where x.Id.Equals(user.Id)
                            select x;
                if (query.Any())
                {
                    var raw = query.FirstOrDefault();
                    if (!String.IsNullOrEmpty(user.Password))
                    {
                        user.Password = SecurityHelper.GenerateMD5(user.Password, raw.Salt);
                    }
                    else
                    {
                        user.Password = raw.Password;
                    }
                    raw.CollectInformation(user);
                    raw.EditedAt = DateTime.Now;
                    raw.EditedBy = GlobalConstants.username;
                    id = raw.Id;
                }
            }
            catch (Exception ex)
            {
                error = true;
                errorMessage = ex.ToString();
            }
        }

        public void Delete(string id)
        {
            error = false;
            errorMessage = "";
            try
            {
                var user = ProjectDataContext.Users.Where(_ => _.Id.Equals(id)).SingleOrDefault();
                Delete(user);
            }
            catch (Exception ex)
            {
                error = true;
                errorMessage = ex.ToString();
            }
        }

        public void Delete(User user)
        {
            error = false;
            errorMessage = "";
            try
            {
                if (user == null) return;
                ProjectDataContext.Set<User>().Remove(user);
            }
            catch (Exception ex)
            {
                error = true;
                errorMessage = ex.ToString();
            }
        }

        public void DeleteRange(string ids)
        {
            error = false;
            errorMessage = "";
            try
            {
                var users = ProjectDataContext.Users.Where(_ => (ids.Contains(_.Id)));
                DeleteRange(users);
            }
            catch (Exception ex)
            {
                error = true;
                errorMessage = ex.ToString();
            }
        }

        public void DeleteRange(IEnumerable<User> users)
        {
            error = false;
            errorMessage = "";
            try
            {
                ProjectDataContext.Set<User>().RemoveRange(users);
            }
            catch (Exception ex)
            {
                error = true;
                errorMessage = ex.ToString();
            }
        }

        public void ChangePassword(string username, string newPassword)
        {
            error = false;
            errorMessage = "";
            try
            {
                var query = from x in ProjectDataContext.Users
                            where x.Username.Equals(username)
                            select x;
                if (query.Any())
                {
                    var raw = query.FirstOrDefault();
                    raw.Password = SecurityHelper.GenerateMD5(newPassword, raw.Salt);
                    raw.EditedAt = DateTime.Now;
                    raw.EditedBy = GlobalConstants.username;
                }
            }
            catch (Exception ex)
            {
                error = true;
                errorMessage = ex.ToString();
            }
        }

        public void CheckSecurity(string username, string password)
        {
            error = false;
            errorMessage = "";
            ProjectDataContext projectDataContext = new ProjectDataContext();
            var query = from x in projectDataContext.Users
                        where x.Username.Equals(username)
                        select x;
            if (query.Any())
            {
                var user = query.SingleOrDefault();
                String encryptedPassword = SecurityHelper.GenerateMD5(password, user.Salt);
                if (user.Password != encryptedPassword)
                {
                    error = true;
                    errorMessage = "Mật khẩu không đúng";
                }
                GlobalConstants.username = user.Username;
                GlobalConstants.fullName = user.FullName;
            }
            else
            {
                error = true;
                errorMessage = "Tài khoản không tồn tại";
            }
        }

        public void CheckPermission(string username, string password, string permission)
        {
            error = false;
            errorMessage = "";
        }

        public string GetAutoID()
        {
            return Guid.NewGuid().ToString();
        }
    }
}