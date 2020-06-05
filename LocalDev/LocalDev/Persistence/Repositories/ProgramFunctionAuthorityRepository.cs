using LocalDev.Core.Domain;
using LocalDev.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;
using LocalDev.Core;
using LocalDev.Core.Helper;

namespace LocalDev.Persistence.Repositories
{
    public class ProgramFunctionAuthorityRepository : Repository<ProgramFunctionAuthority>
    {
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

        public IEnumerable<ProgramFunctionAuthority> Find(Dictionary<SearchConditions, object> conditions)
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
                    string value = conditions[SearchConditions.AuthorityGroupID].ToString();
                    query = query.Where(_ => _.AuthorityGroupID.Equals(value));
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
                programFunctionAuthority.Id = GetAutoID();
                programFunctionAuthority.CreatedAt = DateTime.Now;
                programFunctionAuthority.CreatedBy = GlobalConstants.username;
                Add(programFunctionAuthority);
            }
            else
            {
                Update(programFunctionAuthority);
            }
        }

        public void Update(ProgramFunctionAuthority programFunctionAuthority)
        {
            error = false;
            errorMessage = "";
            try
            {
                var raw = FirstOrDefault(x => x.Id.Equals(programFunctionAuthority.Id));
                if (raw != null)
                {
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

        public void DeleteByProgramAndFunction(string programName, string functionName)
        {
            error = false;
            errorMessage = "";
            try
            {
                var ProgramFunctionAuthority = ProjectDataContext.ProgramFunctionAuthoritys.Where(_ => _.ProgramName.Equals(programName) && _.FunctionName.Equals(functionName)).ToList();
                RemoveRange(ProgramFunctionAuthority);
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