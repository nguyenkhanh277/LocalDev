using LocalDev.Core.Domain;
using LocalDev.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;
using LocalDev.Core;
using LocalDev.Core.Helper;

namespace LocalDev.Persistence.Repositories
{
    public class AuthorityGroupRepository : Repository<AuthorityGroup>
    {
        public string id = "";

        public AuthorityGroupRepository(ProjectDataContext projectDataContext) : base(projectDataContext)
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
            Status,

            SortId_Desc
        }
        #endregion

        public IEnumerable<AuthorityGroup> Find(Dictionary<SearchConditions, object> conditions)
        {
            ProjectDataContext projectDataContext = new ProjectDataContext();
            var query = from x in projectDataContext.AuthorityGroups
                        select x;

            if (!query.Any()) return new List<AuthorityGroup>();
            if (conditions != null)
            {
                #region Check conditions
                if (conditions.Keys.Contains(SearchConditions.Id))
                {
                    int? value = (int)conditions[SearchConditions.Id];
                    query = query.Where(_ => _.Id.Equals(value));
                }
                if (conditions.Keys.Contains(SearchConditions.Status))
                {
                    GlobalConstants.StatusValue value;
                    Enum.TryParse<GlobalConstants.StatusValue>(conditions[SearchConditions.Status].ToString(), out value);
                    query = query.Where(_ => _.Status == value);
                }
                #endregion

                #region Sort by
                if (conditions.Keys.Contains(SearchConditions.SortId_Desc))
                {
                    bool value = (bool)conditions[SearchConditions.SortId_Desc];
                    if (value)
                    {
                        query = query.OrderByDescending(_ => _.Id);
                    }
                    else
                    {
                        query = query.OrderBy(_ => _.Id);
                    }
                }
                #endregion
            }
            return query.ToList();
        }

        public void Save(AuthorityGroup authorityGroup)
        {
            if (String.IsNullOrEmpty(authorityGroup.Id))
            {
                authorityGroup.Id = GetAutoID();
                authorityGroup.CreatedAt = DateTime.Now;
                authorityGroup.CreatedBy = GlobalConstants.username;
                Add(authorityGroup);
            }
            else
            {
                Update(authorityGroup);
            }
        }

        public void Update(AuthorityGroup authorityGroup)
        {
            error = false;
            errorMessage = "";
            try
            {
                var raw = FirstOrDefault(x => x.Id.Equals(authorityGroup.Id));
                if (raw != null)
                {
                    raw.CollectInformation(authorityGroup);
                    raw.EditedAt = DateTime.Now;
                    raw.EditedBy = GlobalConstants.username;
                    this.id = raw.Id;
                }
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