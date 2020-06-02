using LocalDev.Core.Repositories;
using System;
using LocalDev.Persistence;

namespace LocalDev.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        IAuthorityGroupRepository AuthorityGroups { get; }
        IProgramFunctionMasterRepository ProgramFunctionMasters { get; }
        IProgramFunctionAuthorityRepository ProgramFunctionAuthoritys { get; }
        IUserAuthorityRepository UserAuthoritys { get; }
        int Complete();
    }
}