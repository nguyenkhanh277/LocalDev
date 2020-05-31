using LocalDev.Core.Repositories;
using System;
using LocalDev.Persistence;

namespace LocalDev.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        int Complete();
    }
}