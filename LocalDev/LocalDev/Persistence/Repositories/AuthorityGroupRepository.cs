using LocalDev.Core.Domain;
using LocalDev.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;
using LocalDev.Core;
using LocalDev.Core.Helper;

namespace LocalDev.Persistence.Repositories
{
    public class AuthorityGroupRepository : Repository<AuthorityGroup>, IAuthorityGroupRepository
    {
        public bool error = false;
        public string errorMessage = "";

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

        public AuthorityGroup GetInfo(int id)
        {
            ProjectDataContext projectDataContext = new ProjectDataContext();
            return projectDataContext.AuthorityGroups.OrderBy(_ => _.Id).SingleOrDefault(_ => _.Id.Equals(id));
        }

        public IEnumerable<AuthorityGroup> GetAll(Dictionary<SearchConditions, object> conditions)
        {
            ProjectDataContext projectDataContext = new ProjectDataContext();
            var query = from x in projectDataContext.AuthorityGroups
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
            if (authorityGroup.Id == null)
            {
                Add(authorityGroup);
            }
            else
            {
                Update(authorityGroup);
            }
        }

        public void Add(AuthorityGroup authorityGroup)
        {
            error = false;
            errorMessage = "";
            try
            {
                authorityGroup.CreatedAt = DateTime.Now;
                authorityGroup.CreatedBy = GlobalConstants.Username;
                ProjectDataContext.Set<AuthorityGroup>().Add(authorityGroup);
            }
            catch (Exception ex)
            {
                error = true;
                errorMessage = ex.ToString();
            }
        }

        public void Update(AuthorityGroup authorityGroup)
        {
            error = false;
            errorMessage = "";
            try
            {
                var query = from x in ProjectDataContext.AuthorityGroups
                            where x.Id.Equals(authorityGroup.Id)
                            select x;
                if (query.Any())
                {
                    var raw = query.FirstOrDefault();
                    raw.CollectInformation(authorityGroup);
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

        public void Delete(int id)
        {
            error = false;
            errorMessage = "";
            try
            {
                var AuthorityGroup = ProjectDataContext.AuthorityGroups.Where(_ => _.Id.Equals(id)).SingleOrDefault();
                Delete(AuthorityGroup);
            }
            catch (Exception ex)
            {
                error = true;
                errorMessage = ex.ToString();
            }
        }

        public void Delete(AuthorityGroup authorityGroup)
        {
            error = false;
            errorMessage = "";
            try
            {
                if (authorityGroup == null) return;
                ProjectDataContext.Set<AuthorityGroup>().Remove(authorityGroup);
            }
            catch (Exception ex)
            {
                error = true;
                errorMessage = ex.ToString();
            }
        }

        //public void DeleteRange(string ids)
        //{
        //    error = false;
        //    errorMessage = "";
        //    try
        //    {
        //        var AuthorityGroups = ProjectDataContext.AuthorityGroups.Where(_ => (ids.Contains(_.Id)));
        //        DeleteRange(AuthorityGroups);
        //    }
        //    catch (Exception ex)
        //    {
        //        error = true;
        //        errorMessage = ex.ToString();
        //    }
        //}

        public void DeleteRange(IEnumerable<AuthorityGroup> authorityGroups)
        {
            error = false;
            errorMessage = "";
            try
            {
                ProjectDataContext.Set<AuthorityGroup>().RemoveRange(authorityGroups);
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