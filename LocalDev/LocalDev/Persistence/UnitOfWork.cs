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
            //partNumbers = new PartNumberRepository(_projectDataContext);
            //languageLibrarys = new LanguageLibraryRepository(_projectDataContext);
            //users = new UserRepository(_projectDataContext);
            //authorityGroups = new AuthorityGroupRepository(_projectDataContext);
            //programFunctionMasters = new ProgramFunctionMasterRepository(_projectDataContext);
            //programFunctionAuthoritys = new ProgramFunctionAuthorityRepository(_projectDataContext);
            //userAuthoritys = new UserAuthorityRepository(_projectDataContext);
        }

        //public IPartNumberRepository partNumbers { get; private set; }
        //public ILanguageLibraryRepository languageLibrarys { get; private set; }
        //public IUserRepository users { get; private set; }
        //public IAuthorityGroupRepository authorityGroups { get; private set; }
        //public IProgramFunctionMasterRepository programFunctionMasters { get; private set; }
        //public IProgramFunctionAuthorityRepository programFunctionAuthoritys { get; private set; }
        //public IUserAuthorityRepository userAuthoritys { get; private set; }

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