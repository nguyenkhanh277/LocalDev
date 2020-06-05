using LocalDev.Core.Repositories;
using System;
using LocalDev.Persistence;

namespace LocalDev.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IPartNumberRepository partNumbers { get; }
        ILanguageLibraryRepository languageLibrarys { get; }
        IUserRepository users { get; }
        IAuthorityGroupRepository authorityGroups { get; }
        IProgramFunctionMasterRepository programFunctionMasters { get; }
        IProgramFunctionAuthorityRepository programFunctionAuthoritys { get; }
        IUserAuthorityRepository userAuthoritys { get; }
        int Complete();
    }
}