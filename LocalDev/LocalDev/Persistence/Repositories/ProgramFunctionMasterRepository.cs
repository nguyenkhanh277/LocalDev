using LocalDev.Core.Domain;
using LocalDev.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;
using LocalDev.Core;
using LocalDev.Core.Helper;

namespace LocalDev.Persistence.Repositories
{
    public class ProgramFunctionMasterRepository : Repository<ProgramFunctionMaster>
    {
        public ProgramFunctionMasterRepository(ProjectDataContext projectDataContext) : base(projectDataContext)
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

            SortProgramName_Desc
        }
        #endregion

        public IEnumerable<ProgramFunctionMaster> Find(Dictionary<SearchConditions, object> conditions)
        {
            ProjectDataContext projectDataContext = new ProjectDataContext();
            var query = from x in projectDataContext.ProgramFunctionMasters
                        select x;

            if (!query.Any()) return new List<ProgramFunctionMaster>();
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
                if (conditions.Keys.Contains(SearchConditions.SortProgramName_Desc))
                {
                    bool value = (bool)conditions[SearchConditions.SortProgramName_Desc];
                    if (value)
                    {
                        query = query.OrderByDescending(_ => _.ProgramName).ThenByDescending(_ => _.FunctionName);
                    }
                    else
                    {
                        query = query.OrderBy(_ => _.ProgramName).ThenBy(_ => _.FunctionName);
                    }
                }
                #endregion
            }
            return query.ToList();
        }

        public void Save(ProgramFunctionMaster programFunctionMaster)
        {
            if (String.IsNullOrEmpty(programFunctionMaster.Id))
            {
                programFunctionMaster.Id = GetAutoID();
                programFunctionMaster.CreatedAt = DateTime.Now;
                programFunctionMaster.CreatedBy = GlobalConstants.username;
                Add(programFunctionMaster);
            }
            else
            {
                Update(programFunctionMaster);
            }
        }

        public void Update(ProgramFunctionMaster programFunctionMaster)
        {
            error = false;
            errorMessage = "";
            try
            {
                var raw = FirstOrDefault(x => x.Id.Equals(programFunctionMaster.Id));
                if (raw != null)
                {
                    raw.CollectInformation(programFunctionMaster);
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

        public string GetAutoID()
        {
            return Guid.NewGuid().ToString();
        }
    }
}