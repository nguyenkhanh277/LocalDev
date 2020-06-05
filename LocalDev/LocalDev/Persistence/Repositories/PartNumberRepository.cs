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
        public PartNumberRepository(ProjectDataContext projectDataContext) : base(projectDataContext)
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
            PartNo,
            Model,
            Status,

            SortPartNo_Desc
        }
        #endregion

        public IEnumerable<PartNumber> Find(Dictionary<SearchConditions, object> conditions)
        {
            ProjectDataContext projectDataContext = new ProjectDataContext();
            var query = from x in projectDataContext.PartNumbers
                        select x;

            if (!query.Any()) return new List<PartNumber>();
            if (conditions != null)
            {
                #region Check conditions
                if (conditions.Keys.Contains(SearchConditions.Id))
                {
                    string value = conditions[SearchConditions.Id].ToString();
                    query = query.Where(_ => _.Id.Equals(value));
                }
                if (conditions.Keys.Contains(SearchConditions.PartNo))
                {
                    string value = conditions[SearchConditions.PartNo].ToString();
                    query = query.Where(_ => _.PartNo.Equals(value));
                }
                if (conditions.Keys.Contains(SearchConditions.Model))
                {
                    string value = conditions[SearchConditions.Model].ToString();
                    query = query.Where(_ => _.Model.Equals(value));
                }
                if (conditions.Keys.Contains(SearchConditions.Status))
                {
                    GlobalConstants.StatusValue value;
                    Enum.TryParse<GlobalConstants.StatusValue>(conditions[SearchConditions.Status].ToString(), out value);
                    query = query.Where(_ => _.Status == value);
                }
                #endregion

                #region Sort by
                if (conditions.Keys.Contains(SearchConditions.SortPartNo_Desc))
                {
                    bool value = (bool)conditions[SearchConditions.SortPartNo_Desc];
                    if (value)
                    {
                        query = query.OrderByDescending(_ => _.PartNo);
                    }
                    else
                    {
                        query = query.OrderBy(_ => _.PartNo);
                    }
                }
                #endregion
            }
            return query.ToList();
        }

        public void Save(PartNumber partNumber)
        {
            if (String.IsNullOrEmpty(partNumber.Id))
            {
                partNumber.Id = partNumber.PartNo;
                partNumber.CreatedAt = DateTime.Now;
                partNumber.CreatedBy = GlobalConstants.username;
                Add(partNumber);
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
                var raw = FirstOrDefault(x => x.Id.Equals(partNumber.Id));
                if (raw != null)
                {
                    raw.CollectInformation(partNumber);
                    raw.Id = partNumber.PartNo;
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