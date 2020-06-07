using LocalDev.Core.Domain;
using LocalDev.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;
using LocalDev.Core;
using LocalDev.Core.Helper;
using System.Linq.Expressions;

namespace LocalDev.Persistence.Repositories
{
    public class ScanBarcodeRepository : Repository<ScanBarcode>
    {
        public ScanBarcodeRepository(ProjectDataContext projectDataContext) : base(projectDataContext)
        {
        }

        public ProjectDataContext ProjectDataContext
        {
            get { return Context as ProjectDataContext; }
        }

        public void Save(ScanBarcode scanBarcode)
        {
            if (String.IsNullOrEmpty(scanBarcode.Id))
            {
                scanBarcode.Id = GetAutoID();
                scanBarcode.UserID = GlobalConstants.userID;
                scanBarcode.CreatedAt = DateTime.Now;
                scanBarcode.CreatedBy = GlobalConstants.username;
                Add(scanBarcode);
            }
            else
            {
                Update(scanBarcode);
            }
        }

        public void Update(ScanBarcode scanBarcode)
        {
            error = false;
            errorMessage = "";
            try
            {
                var raw = FirstOrDefault(_ => _.Id.Equals(scanBarcode.Id));
                if (raw != null)
                {
                    raw.CollectInformation(scanBarcode);
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

        public void Cancel(string id)
        {
            error = false;
            errorMessage = "";
            try
            {
                var scanBarcode = FirstOrDefault(_ => _.Id.Equals(id));
                if (scanBarcode != null)
                {
                    scanBarcode.Status = GlobalConstants.StatusValue.NoUse;
                    scanBarcode.EditedAt = DateTime.Now;
                    scanBarcode.EditedBy = GlobalConstants.username;
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