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
    public class ScanBarcodeDetailRepository : Repository<ScanBarcodeDetail>
    {
        public ScanBarcodeDetailRepository(ProjectDataContext projectDataContext) : base(projectDataContext)
        {
        }

        public ProjectDataContext ProjectDataContext
        {
            get { return Context as ProjectDataContext; }
        }

        public void Save(ScanBarcodeDetail scanBarcodeDetail)
        {
            if (String.IsNullOrEmpty(scanBarcodeDetail.Id))
            {
                scanBarcodeDetail.Id = GetAutoID();
                scanBarcodeDetail.UserID = GlobalConstants.userID;
                scanBarcodeDetail.CreatedAt = DateTime.Now;
                scanBarcodeDetail.CreatedBy = GlobalConstants.username;
                Add(scanBarcodeDetail);
            }
            else
            {
                Update(scanBarcodeDetail);
            }
        }

        public void Update(ScanBarcodeDetail scanBarcodeDetail)
        {
            error = false;
            errorMessage = "";
            try
            {
                var raw = FirstOrDefault(_ => _.Id.Equals(scanBarcodeDetail.Id));
                if (raw != null)
                {
                    raw.CollectInformation(scanBarcodeDetail);
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
                var scanBarcodeDetail = FirstOrDefault(_ => _.Id.Equals(id));
                if (scanBarcodeDetail != null)
                {
                    scanBarcodeDetail.Status = GlobalConstants.StatusValue.NoUse;
                    scanBarcodeDetail.EditedAt = DateTime.Now;
                    scanBarcodeDetail.EditedBy = GlobalConstants.username;
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