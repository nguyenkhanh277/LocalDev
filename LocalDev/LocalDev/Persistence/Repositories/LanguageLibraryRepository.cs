using LocalDev.Core.Domain;
using LocalDev.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;
using LocalDev.Core;
using LocalDev.Core.Helper;

namespace LocalDev.Persistence.Repositories
{
    public class LanguageLibraryRepository : Repository<LanguageLibrary>, ILanguageLibraryRepository
    {
        public bool error = false;
        public string errorMessage = "";

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

        public LanguageLibrary GetInfo(string id)
        {
            ProjectDataContext projectDataContext = new ProjectDataContext();
            return projectDataContext.LanguageLibrarys.OrderBy(_ => _.Vietnamese).SingleOrDefault(_ => _.Id.Equals(id));
        }

        public IEnumerable<LanguageLibrary> GetAll(Dictionary<SearchConditions, object> conditions)
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
                Add(languageLibrary);
            }
            else
            {
                Update(languageLibrary);
            }
        }

        public void Add(LanguageLibrary languageLibrary)
        {
            error = false;
            errorMessage = "";
            try
            {
                languageLibrary.Id = GetAutoID();
                languageLibrary.CreatedAt = DateTime.Now;
                languageLibrary.CreatedBy = GlobalConstants.username;
                ProjectDataContext.Set<LanguageLibrary>().Add(languageLibrary);
            }
            catch (Exception ex)
            {
                error = true;
                errorMessage = ex.ToString();
            }
        }

        public void Update(LanguageLibrary languageLibrary)
        {
            error = false;
            errorMessage = "";
            try
            {
                var query = from x in ProjectDataContext.LanguageLibrarys
                            where x.Id.Equals(languageLibrary.Id)
                            select x;
                if (query.Any())
                {
                    var raw = query.FirstOrDefault();
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

        public void Delete(string id)
        {
            error = false;
            errorMessage = "";
            try
            {
                var languageLibrary = ProjectDataContext.LanguageLibrarys.Where(_ => _.Id.Equals(id)).SingleOrDefault();
                Delete(languageLibrary);
            }
            catch (Exception ex)
            {
                error = true;
                errorMessage = ex.ToString();
            }
        }

        public void Delete(LanguageLibrary languageLibrary)
        {
            error = false;
            errorMessage = "";
            try
            {
                if (languageLibrary == null) return;
                ProjectDataContext.Set<LanguageLibrary>().Remove(languageLibrary);
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
                var languageLibrarys = ProjectDataContext.LanguageLibrarys.Where(_ => (ids.Contains(_.Id)));
                DeleteRange(languageLibrarys);
            }
            catch (Exception ex)
            {
                error = true;
                errorMessage = ex.ToString();
            }
        }

        public void DeleteRange(IEnumerable<LanguageLibrary> languageLibrarys)
        {
            error = false;
            errorMessage = "";
            try
            {
                ProjectDataContext.Set<LanguageLibrary>().RemoveRange(languageLibrarys);
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