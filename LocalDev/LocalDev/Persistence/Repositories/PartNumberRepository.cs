using LocalDev.Core.Domain;
using LocalDev.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;
using LocalDev.Core;
using LocalDev.Core.Helper;

namespace LocalDev.Persistence.Repositories
{
    public class PartNumberRepository : Repository<PartNumber>
    {
        public string id = "";

        public PartNumberRepository(ProjectDataContext projectDataContext) : base(projectDataContext)
        {
        }

        public ProjectDataContext ProjectDataContext
        {
            get { return Context as ProjectDataContext; }
        }

        public void Save(PartNumber partNumber)
        {
            if (String.IsNullOrEmpty(partNumber.Id))
            {
                partNumber.Id = partNumber.PartNo;
                partNumber.CreatedAt = DateTime.Now;
                partNumber.CreatedBy = GlobalConstants.username;
                Add(partNumber);
                id = partNumber.Id;
            }
            else
            {
                Update(partNumber);
            }
        }

        public void Update(PartNumber partNumber)
        {
            error = false;
            errorMessage = "";
            try
            {
                var raw = FirstOrDefault(_ => _.Id.Equals(partNumber.Id));
                if (raw != null)
                {
                    raw.CollectInformation(partNumber);
                    raw.Id = partNumber.PartNo;
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