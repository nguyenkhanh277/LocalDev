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