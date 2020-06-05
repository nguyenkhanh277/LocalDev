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

        #region Conditions for search
        public enum SearchConditions
        {
            Id,
            PartNumber,
            FromDate,
            ToDate,
            Line,
            Shift,
            Status,

            SortPrintDate_Desc
        }
        #endregion

        public IEnumerable<Barcode> Find(Dictionary<SearchConditions, object> conditions)
        {
            ProjectDataContext projectDataContext = new ProjectDataContext();
            var query = from x in projectDataContext.Barcodes
                        join y in projectDataContext.PartNumbers on x.PartNumberID equals y.Id
                        select new { x, y };

            if (!query.Any()) return new List<Barcode>();
            if (conditions != null)
            {
                #region Check conditions
                if (conditions.Keys.Contains(SearchConditions.Id))
                {
                    string value = conditions[SearchConditions.Id].ToString();
                    query = query.Where(_ => _.x.Id.Equals(value));
                }
                if (conditions.Keys.Contains(SearchConditions.PartNumber))
                {
                    string value = conditions[SearchConditions.PartNumber].ToString();
                    query = query.Where(_ => _.y.PartNo.Equals(value));
                }
                if (conditions.Keys.Contains(SearchConditions.Line))
                {
                    string value = conditions[SearchConditions.Line].ToString();
                    query = query.Where(_ => _.x.Line.Equals(value));
                }
                if (conditions.Keys.Contains(SearchConditions.Shift))
                {
                    string value = conditions[SearchConditions.Shift].ToString();
                    query = query.Where(_ => _.x.Shift.Equals(value));
                }
                if (conditions.Keys.Contains(SearchConditions.Status))
                {
                    GlobalConstants.StatusValue value;
                    Enum.TryParse<GlobalConstants.StatusValue>(conditions[SearchConditions.Status].ToString(), out value);
                    query = query.Where(_ => _.x.Status == value);
                }
                #endregion

                #region Sort by
                if (conditions.Keys.Contains(SearchConditions.SortPrintDate_Desc))
                {
                    bool value = (bool)conditions[SearchConditions.SortPrintDate_Desc];
                    if (value)
                    {
                        query = query.OrderByDescending(_ => _.x.PrintDate);
                    }
                    else
                    {
                        query = query.OrderBy(_ => _.x.PrintDate);
                    }
                }
                #endregion
            }
            return query.Select(_ => _.x).ToList();
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