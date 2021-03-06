using LocalDev.Core.Repositories;
using System;
using LocalDev.Persistence;

namespace LocalDev.Core
{
    public interface IUnitOfWork : IDisposable
    {
        int Complete();
    }
}