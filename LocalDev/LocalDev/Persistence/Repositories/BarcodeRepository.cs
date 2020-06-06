using LocalDev.Core.Domain;
using LocalDev.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;
using LocalDev.Core;
using LocalDev.Core.Helper;

namespace LocalDev.Persistence.Repositories
{
    public class BarcodeRepository : Repository<Barcode>
    {
        public BarcodeRepository(ProjectDataContext projectDataContext) : base(projectDataContext)
        {
        }

        public ProjectDataContext ProjectDataContext
        {
            get { return Context as ProjectDataContext; }
        }

        public void Save(Barcode barcode)
        {
            if (String.IsNullOrEmpty(barcode.Id))
            {
                barcode.Id = GetAutoID();
                barcode.CreatedAt = DateTime.Now;
                barcode.CreatedBy = GlobalConstants.username;
                Add(barcode);
            }
            else
            {
                Update(barcode);
            }
        }

        public void Update(Barcode barcode)
        {
            error = false;
            errorMessage = "";
            try
            {
                var raw = FirstOrDefault(x => x.Id.Equals(barcode.Id));
                if (raw != null)
                {
                    raw.CollectInformation(barcode);
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