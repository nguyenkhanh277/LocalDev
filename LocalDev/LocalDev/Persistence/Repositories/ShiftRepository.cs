using LocalDev.Core.Domain;
using LocalDev.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;
using LocalDev.Core;
using LocalDev.Core.Helper;

namespace LocalDev.Persistence.Repositories
{
    public class ShiftRepository : Repository<Shift>
    {
        public string id = "";

        public ShiftRepository(ProjectDataContext projectDataContext) : base(projectDataContext)
        {
        }

        public ProjectDataContext ProjectDataContext
        {
            get { return Context as ProjectDataContext; }
        }

        public void Save(Shift shift)
        {
            if (String.IsNullOrEmpty(shift.Id))
            {
                shift.Id = GetAutoID();
                shift.CreatedAt = DateTime.Now;
                shift.CreatedBy = GlobalConstants.username;
                Add(shift);
                id = shift.Id;
            }
            else
            {
                Update(shift);
            }
        }

        public void Update(Shift shift)
        {
            error = false;
            errorMessage = "";
            try
            {
                var raw = FirstOrDefault(_ => _.Id.Equals(shift.Id));
                if (raw != null)
                {
                    raw.CollectInformation(shift);
                    raw.EditedAt = DateTime.Now;
                    raw.EditedBy = GlobalConstants.username;
                    id = raw.Id;
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