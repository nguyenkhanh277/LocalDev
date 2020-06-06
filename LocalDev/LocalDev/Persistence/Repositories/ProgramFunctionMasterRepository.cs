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