using LocalDev.Core.Domain;
using LocalDev.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;
using LocalDev.Core;
using LocalDev.Core.Helper;

namespace LocalDev.Persistence.Repositories
{
    public class LanguageLibraryRepository : Repository<LanguageLibrary>
    {
        public LanguageLibraryRepository(ProjectDataContext projectDataContext) : base(projectDataContext)
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

            SortVietnamese_Desc
        }
        #endregion

        public IEnumerable<LanguageLibrary> Find(Dictionary<SearchConditions, object> conditions)
        {
            ProjectDataContext projectDataContext = new ProjectDataContext();
            var query = from x in projectDataContext.LanguageLibrarys
                        select x;

            if (!query.Any()) return new List<LanguageLibrary>();
            if (conditions != null)
            {
                #region Check conditions
                if (conditions.Keys.Contains(SearchConditions.Id))
                {
                    string value = conditions[SearchConditions.Id].ToString();
                    query = query.Where(_ => _.Id.Equals(value));
                }
                #endregion

                #region Sort by
                if (conditions.Keys.Contains(SearchConditions.SortVietnamese_Desc))
                {
                    bool value = (bool)conditions[SearchConditions.SortVietnamese_Desc];
                    if (value)
                    {
                        query = query.OrderByDescending(_ => _.Vietnamese);
                    }
                    else
                    {
                        query = query.OrderBy(_ => _.Vietnamese);
                    }
                }
                #endregion
            }
            return query.ToList();
        }

        public void Save(LanguageLibrary languageLibrary)
        {
            if (String.IsNullOrEmpty(languageLibrary.Id))
            {
                languageLibrary.Id = GetAutoID();
                languageLibrary.CreatedAt = DateTime.Now;
                languageLibrary.CreatedBy = GlobalConstants.username;
                Add(languageLibrary);
            }
            else
            {
                Update(languageLibrary);
            }
        }

        public void Update(LanguageLibrary languageLibrary)
        {
            error = false;
            errorMessage = "";
            try
            {
                var raw = FirstOrDefault(x => x.Id.Equals(languageLibrary.Id));
                if (raw != null)
                {
                    raw.CollectInformation(languageLibrary);
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