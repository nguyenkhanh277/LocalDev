using LocalDev.Core.Domain;
using LocalDev.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;
using LocalDev.Core;
using LocalDev.Core.Helper;

namespace LocalDev.Persistence.Repositories
{
    public class ProgramFunctionAuthorityRepository : Repository<ProgramFunctionAuthority>, IProgramFunctionAuthorityRepository
    {
        public bool error = false;
        public string errorMessage = "";

        public ProgramFunctionAuthorityRepository(ProjectDataContext projectDataContext) : base(projectDataContext)
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
            AuthorityGroupID,

            SortProgramName_Desc
        }
        #endregion

        public ProgramFunctionAuthority GetInfo(string id)
        {
            ProjectDataContext projectDataContext = new ProjectDataContext();
            return projectDataContext.ProgramFunctionAuthoritys.OrderBy(_ => _.ProgramName).SingleOrDefault(_ => _.Id.Equals(id));
        }

        public IEnumerable<ProgramFunctionAuthority> GetAll(Dictionary<SearchConditions, object> conditions)
        {
            ProjectDataContext projectDataContext = new ProjectDataContext();
            var query = from x in projectDataContext.ProgramFunctionAuthoritys
                        select x;

            if (!query.Any()) return new List<ProgramFunctionAuthority>();
            if (conditions != null)
            {
                #region Check conditions
                if (conditions.Keys.Contains(SearchConditions.Id))
                {
                    string value = conditions[SearchConditions.Id].ToString();
                    query = query.Where(_ => _.Id.Equals(value));
                }
                if (conditions.Keys.Contains(SearchConditions.AuthorityGroupID))
                {
                    int? value = (int)conditions[SearchConditions.AuthorityGroupID];
                    query = query.Where(_ => _.AuthorityGroupID == value);
                }
                #endregion

                #region Sort by
                if (conditions.Keys.Contains(SearchConditions.SortProgramName_Desc))
                {
                    bool value = (bool)conditions[SearchConditions.SortProgramName_Desc];
                    if (value)
                    {
                        query = query.OrderByDescending(_ => _.ProgramName);
                    }
                    else
                    {
                        query = query.OrderBy(_ => _.ProgramName);
                    }
                }
                #endregion
            }
            return query.ToList();
        }

        public void Save(ProgramFunctionAuthority programFunctionAuthority)
        {
            if (String.IsNullOrEmpty(programFunctionAuthority.Id))
            {
                Add(programFunctionAuthority);
            }
            else
            {
                Update(programFunctionAuthority);
            }
        }

        public void Add(ProgramFunctionAuthority programFunctionAuthority)
        {
            error = false;
            errorMessage = "";
            try
            {
                programFunctionAuthority.Id = GetAutoID();
                programFunctionAuthority.CreatedAt = DateTime.Now;
                programFunctionAuthority.CreatedBy = GlobalConstants.username;
                ProjectDataContext.Set<ProgramFunctionAuthority>().Add(programFunctionAuthority);
            }
            catch (Exception ex)
            {
                error = true;
                errorMessage = ex.ToString();
            }
        }

        public void Update(ProgramFunctionAuthority programFunctionAuthority)
        {
            error = false;
            errorMessage = "";
            try
            {
                var query = from x in ProjectDataContext.ProgramFunctionAuthoritys
                            where x.Id.Equals(programFunctionAuthority.Id)
                            select x;
                if (query.Any())
                {
                    var raw = query.FirstOrDefault();
                    raw.CollectInformation(programFunctionAuthority);
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

        public void Delete(string id)
        {
            error = false;
            errorMessage = "";
            try
            {
                var ProgramFunctionAuthority = ProjectDataContext.ProgramFunctionAuthoritys.Where(_ => _.Id.Equals(id)).SingleOrDefault();
                Delete(ProgramFunctionAuthority);
            }
            catch (Exception ex)
            {
                error = true;
                errorMessage = ex.ToString();
            }
        }

        public void Delete(ProgramFunctionAuthority programFunctionAuthority)
        {
            error = false;
            errorMessage = "";
            try
            {
                if (programFunctionAuthority == null) return;
                ProjectDataContext.Set<ProgramFunctionAuthority>().Remove(programFunctionAuthority);
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
                var ProgramFunctionAuthoritys = ProjectDataContext.ProgramFunctionAuthoritys.Where(_ => (ids.Contains(_.Id)));
                DeleteRange(ProgramFunctionAuthoritys);
            }
            catch (Exception ex)
            {
                error = true;
                errorMessage = ex.ToString();
            }
        }

        public void DeleteRange(IEnumerable<ProgramFunctionAuthority> programFunctionAuthoritys)
        {
            error = false;
            errorMessage = "";
            try
            {
                ProjectDataContext.Set<ProgramFunctionAuthority>().RemoveRange(programFunctionAuthoritys);
            }
            catch (Exception ex)
            {
                error = true;
                errorMessage = ex.ToString();
            }
        }

        public void DeleteByProgramAndFunction(string programName, string functionName)
        {
            error = false;
            errorMessage = "";
            try
            {
                var ProgramFunctionAuthority = ProjectDataContext.ProgramFunctionAuthoritys.Where(_ => _.ProgramName.Equals(programName) && _.FunctionName.Equals(functionName)).ToList();
                DeleteRange(ProgramFunctionAuthority);
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