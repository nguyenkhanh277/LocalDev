using System.Data.Entity;
using LocalDev.Core;
using LocalDev.Core.Repositories;
using LocalDev.Persistence.Repositories;

namespace LocalDev.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private ProjectDataContext _projectDataContext;

        public UnitOfWork(ProjectDataContext projectDataContext)
        {
            this._projectDataContext = projectDataContext;
            Users = new UserRepository(_projectDataContext);
        }

        public IUserRepository Users { get; private set; }

        public int Complete()
        {
            return _projectDataContext.SaveChanges();
        }

        public void Dispose()
        {
            _projectDataContext.Dispose();
        }
    }
}