using LocalDev.Core.Domain;
using System.Collections.Generic;
using System.Linq;
using System;
using LocalDev.Core;
using LocalDev.Core.Helper;
using System.Linq.Expressions;

namespace LocalDev.Persistence.Repositories
{
    public class UserRepository : Repository<User>
    {
        public string id = "";

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

        public Expression<Func<User, bool>> FilterById(string id)
        {
            return x => x.Id.Equals(id);
        }

        public IEnumerable<User> Find(Dictionary<SearchConditions, object> conditions)
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
                user.Id = GetAutoID();
                user.Salt = SecurityHelper.CreateSalt(GlobalConstants.defaultSaltLength);
                user.Password = SecurityHelper.GenerateMD5(user.Password, user.Salt);
                user.CreatedAt = DateTime.Now;
                user.CreatedBy = GlobalConstants.username;
                Add(user);
            }
            else
            {
                Update(user);
            }
        }

        public void Update(User user)
        {
            error = false;
            errorMessage = "";
            try
            {
                var raw = FirstOrDefault(x => x.Id.Equals(user.Id));
                if (raw != null)
                {
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

        public void ChangePassword(string username, string newPassword)
        {
            error = false;
            errorMessage = "";
            try
            {
                var user = FirstOrDefault(x => x.Username.Equals(username));
                if (user != null)
                {
                    user.Password = SecurityHelper.GenerateMD5(newPassword, user.Salt);
                    user.EditedAt = DateTime.Now;
                    user.EditedBy = GlobalConstants.username;
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
            var user = FirstOrDefault(x => x.Username.Equals(username));
            if (user != null)
            {
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