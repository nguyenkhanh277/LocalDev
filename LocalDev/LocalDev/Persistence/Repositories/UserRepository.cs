using LocalDev.Core.Domain;
using LocalDev.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;
using LocalDev.Core;

namespace LocalDev.Persistence.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public bool error = false;

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

        public User GetUser(string id)
        {
            ProjectDataContext projectDataContext = new ProjectDataContext();
            return projectDataContext.Users.OrderBy(_ => _.Username).SingleOrDefault(_ => _.Id.Equals(id));
        }

        public IEnumerable<User> GetAllUser(Dictionary<SearchConditions, object> conditions)
        {
            ProjectDataContext projectDataContext = new ProjectDataContext();
            var query = from x in projectDataContext.Users
                        select x;

            if (!query.Any()) return null;
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
                AddUser(user);
            }
            else
            {
                UpdateUser(user);
            }
        }

        public void AddUser(User user)
        {
            try
            {
                user.Id = GetAutoID();
                user.CreatedAt = DateTime.Now;
                user.CreatedBy = GlobalConstants.Username;
                ProjectDataContext.Set<User>().Add(user);
                ProjectDataContext.SaveChanges();
            }
            catch
            {
                error = true;
            }
        }

        public void UpdateUser(User user)
        {
            try
            {
                var query = from x in ProjectDataContext.Users
                            where x.Id.Equals(user.Id)
                            select x;
                if (query.Any())
                {
                    var raw = query.FirstOrDefault();
                    raw.CollectInformation(user);
                    raw.EditedAt = DateTime.Now;
                    raw.EditedBy = GlobalConstants.Username;
                    ProjectDataContext.SaveChanges();
                }
            }
            catch
            {
                error = true;
            }
        }

        public void DeleteUser(string id)
        {
            try
            {
                var user = ProjectDataContext.Users.Where(_ => _.Id.Equals(id)).SingleOrDefault();
                DeleteUser(user);
            }
            catch
            {
                error = true;
            }
        }

        public void DeleteUser(User user)
        {
            try
            {
                if (user == null) return;
                ProjectDataContext.Set<User>().Remove(user);
                ProjectDataContext.SaveChanges();
            }
            catch
            {
                error = true;
            }
        }

        public void DeleteRangeUser(string ids)
        {
            try
            {
                var users = ProjectDataContext.Users.Where(_ => (ids.Contains(_.Id)));
                DeleteRangeUser(users);
            }
            catch
            {
                error = true;
            }
        }

        public void DeleteRangeUser(IEnumerable<User> users)
        {
            try
            {
                ProjectDataContext.Set<User>().RemoveRange(users);
                ProjectDataContext.SaveChanges();
            }
            catch
            {
                error = true;
            }
        }

        public bool IsExist(string username, string password)
        {
            ProjectDataContext projectDataContext = new ProjectDataContext();
            var query = from x in projectDataContext.Users
                        where x.Username.Equals(username) && x.Password.Equals(password)
                        select x;
            bool result = query.Any();
            return result;
        }

        public string GetAutoID()
        {
            return Guid.NewGuid().ToString();
        }
    }
}