using LocalDev.Core.Domain;
using LocalDev.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;
using LocalDev.Core;
using LocalDev.Core.Helper;

namespace LocalDev.Persistence.Repositories
{
    public class ProgramFunctionMasterRepository : Repository<ProgramFunctionMaster>, IProgramFunctionMasterRepository
    {
        public bool error = false;
        public string errorMessage = "";

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

        public ProgramFunctionMaster GetInfo(string id)
        {
            ProjectDataContext projectDataContext = new ProjectDataContext();
            return projectDataContext.ProgramFunctionMasters.OrderBy(_ => _.ProgramName).SingleOrDefault(_ => _.Id.Equals(id));
        }

        public IEnumerable<ProgramFunctionMaster> GetAll(Dictionary<SearchConditions, object> conditions)
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
                Add(programFunctionMaster);
            }
            else
            {
                Update(programFunctionMaster);
            }
        }

        public void Add(ProgramFunctionMaster programFunctionMaster)
        {
            error = false;
            errorMessage = "";
            try
            {
                programFunctionMaster.Id = GetAutoID();
                programFunctionMaster.CreatedAt = DateTime.Now;
                programFunctionMaster.CreatedBy = GlobalConstants.Username;
                ProjectDataContext.Set<ProgramFunctionMaster>().Add(programFunctionMaster);
            }
            catch (Exception ex)
            {
                error = true;
                errorMessage = ex.ToString();
            }
        }

        public void Update(ProgramFunctionMaster programFunctionMaster)
        {
            error = false;
            errorMessage = "";
            try
            {
                var query = from x in ProjectDataContext.ProgramFunctionMasters
                            where x.Id.Equals(programFunctionMaster.Id)
                            select x;
                if (query.Any())
                {
                    var raw = query.FirstOrDefault();
                    raw.CollectInformation(programFunctionMaster);
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
                var ProgramFunctionMaster = ProjectDataContext.ProgramFunctionMasters.Where(_ => _.Id.Equals(id)).SingleOrDefault();
                Delete(ProgramFunctionMaster);
            }
            catch (Exception ex)
            {
                error = true;
                errorMessage = ex.ToString();
            }
        }

        public void Delete(ProgramFunctionMaster programFunctionMaster)
        {
            error = false;
            errorMessage = "";
            try
            {
                if (programFunctionMaster == null) return;
                ProjectDataContext.Set<ProgramFunctionMaster>().Remove(programFunctionMaster);
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
                var ProgramFunctionMasters = ProjectDataContext.ProgramFunctionMasters.Where(_ => (ids.Contains(_.Id)));
                DeleteRange(ProgramFunctionMasters);
            }
            catch (Exception ex)
            {
                error = true;
                errorMessage = ex.ToString();
            }
        }

        public void DeleteRange(IEnumerable<ProgramFunctionMaster> programFunctionMasters)
        {
            error = false;
            errorMessage = "";
            try
            {
                ProjectDataContext.Set<ProgramFunctionMaster>().RemoveRange(programFunctionMasters);
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