using LocalDev.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using LocalDev.Persistence.Repositories;
using LocalDev.Persistence;

namespace LocalDev.Core.Repositories
{
    public interface ILanguageLibraryRepository : IRepository<LanguageLibrary>
    {
        LanguageLibrary GetInfo(string id);
        IEnumerable<LanguageLibrary> GetAll(Dictionary<LanguageLibraryRepository.SearchConditions, object> conditions);
        void Add(LanguageLibrary languageLibrary);
        void Update(LanguageLibrary languageLibrary);
        void Delete(string id);
        void Delete(LanguageLibrary languageLibrary);
        void DeleteRange(string ids);
        void DeleteRange(IEnumerable<LanguageLibrary> languageLibrarys);
    }
}