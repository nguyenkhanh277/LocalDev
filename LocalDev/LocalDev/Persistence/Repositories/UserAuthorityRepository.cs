using LocalDev.Core.Domain;
using LocalDev.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;
using LocalDev.Core;
using LocalDev.Core.Helper;

namespace LocalDev.Persistence.Repositories
{
    public class UserAuthorityRepository : Repository<UserAuthority>
    {
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
            UserID,

            SortAuthorityGroupID_Desc
        }
        #endregion

        public IEnumerable<UserAuthority> Find(Dictionary<SearchConditions, object> conditions)
        {
            ProjectDataContext projectDataContext = new ProjectDataContext();
            var query = from x in projectDataContext.UserAuthoritys
                        select x;

            if (!query.Any()) return new List<UserAuthority>();
            if (conditions != null)
            {
                #region Check conditions
                if (conditions.Keys.Contains(SearchConditions.Id))
                {
                    string value = conditions[SearchConditions.Id].ToString();
                    query = query.Where(_ => _.Id.Equals(value));
                }
                if (conditions.Keys.Contains(SearchConditions.UserID))
                {
                    string value = conditions[SearchConditions.UserID].ToString();
                    query = query.Where(_ => _.UserID.Equals(value));
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
                userAuthority.Id = GetAutoID();
                userAuthority.CreatedAt = DateTime.Now;
                userAuthority.CreatedBy = GlobalConstants.username;
                Add(userAuthority);
            }
            else
            {
                Update(userAuthority);
            }
        }

        public void Update(UserAuthority userAuthority)
        {
            error = false;
            errorMessage = "";
            try
            {
                var raw = FirstOrDefault(x => x.Id.Equals(userAuthority.Id));
                if (raw != null)
                {
                    raw.CollectInformation(userAuthority);
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

        public void DeleteByUserID(string userID)
        {
            Remove(FirstOrDefault(x => x.UserID.Equals(userID)));
        }

        public string GetAutoID()
        {
            return Guid.NewGuid().ToString();
        }
    }
}