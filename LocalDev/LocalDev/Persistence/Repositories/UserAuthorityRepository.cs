using LocalDev.Core.Domain;
using LocalDev.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;
using LocalDev.Core;
using LocalDev.Core.Helper;

namespace LocalDev.Persistence.Repositories
{
    public class UserAuthorityRepository : Repository<UserAuthority>, IUserAuthorityRepository
    {
        public bool error = false;
        public string errorMessage = "";

        public UserAuthorityRepository(ProjectDataContext projectDataContext) : base(projectDataContext)
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

            SortAuthorityGroupID_Desc
        }
        #endregion

        public UserAuthority GetInfo(string id)
        {
            ProjectDataContext projectDataContext = new ProjectDataContext();
            return projectDataContext.UserAuthoritys.OrderBy(_ => _.AuthorityGroupID).SingleOrDefault(_ => _.Id.Equals(id));
        }

        public IEnumerable<UserAuthority> GetAll(Dictionary<SearchConditions, object> conditions)
        {
            ProjectDataContext projectDataContext = new ProjectDataContext();
            var query = from x in projectDataContext.UserAuthoritys
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
                #endregion

                #region Sort by
                if (conditions.Keys.Contains(SearchConditions.SortAuthorityGroupID_Desc))
                {
                    bool value = (bool)conditions[SearchConditions.SortAuthorityGroupID_Desc];
                    if (value)
                    {
                        query = query.OrderByDescending(_ => _.AuthorityGroupID);
                    }
                    else
                    {
                        query = query.OrderBy(_ => _.AuthorityGroupID);
                    }
                }
                #endregion
            }
            return query.ToList();
        }

        public void Save(UserAuthority userAuthority)
        {
            if (String.IsNullOrEmpty(userAuthority.Id))
            {
                Add(userAuthority);
            }
            else
            {
                Update(userAuthority);
            }
        }

        public void Add(UserAuthority userAuthority)
        {
            error = false;
            errorMessage = "";
            try
            {
                userAuthority.Id = GetAutoID();
                userAuthority.CreatedAt = DateTime.Now;
                userAuthority.CreatedBy = GlobalConstants.Username;
                ProjectDataContext.Set<UserAuthority>().Add(userAuthority);
            }
            catch (Exception ex)
            {
                error = true;
                errorMessage = ex.ToString();
            }
        }

        public void Update(UserAuthority userAuthority)
        {
            error = false;
            errorMessage = "";
            try
            {
                var query = from x in ProjectDataContext.UserAuthoritys
                            where x.Id.Equals(userAuthority.Id)
                            select x;
                if (query.Any())
                {
                    var raw = query.FirstOrDefault();
                    raw.CollectInformation(userAuthority);
                    raw.EditedAt = DateTime.Now;
                    raw.EditedBy = GlobalConstants.Username;
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
                var UserAuthority = ProjectDataContext.UserAuthoritys.Where(_ => _.Id.Equals(id)).SingleOrDefault();
                Delete(UserAuthority);
            }
            catch (Exception ex)
            {
                error = true;
                errorMessage = ex.ToString();
            }
        }

        public void Delete(UserAuthority userAuthority)
        {
            error = false;
            errorMessage = "";
            try
            {
                if (userAuthority == null) return;
                ProjectDataContext.Set<UserAuthority>().Remove(userAuthority);
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
                var UserAuthoritys = ProjectDataContext.UserAuthoritys.Where(_ => (ids.Contains(_.Id)));
                DeleteRange(UserAuthoritys);
            }
            catch (Exception ex)
            {
                error = true;
                errorMessage = ex.ToString();
            }
        }

        public void DeleteRange(IEnumerable<UserAuthority> userAuthoritys)
        {
            error = false;
            errorMessage = "";
            try
            {
                ProjectDataContext.Set<UserAuthority>().RemoveRange(userAuthoritys);
            }
            catch (Exception ex)
            {
                error = true;
                errorMessage = ex.ToString();
            }
        }

        public string GetAutoID()
        {
            return Guid.NewGuid().ToString();
        }
    }
}