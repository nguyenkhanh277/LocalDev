using LocalDev.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using LocalDev.Persistence.Repositories;
using LocalDev.Persistence;

namespace LocalDev.Core.Repositories
{
    public interface IProgramFunctionMasterRepository : IRepository<ProgramFunctionMaster>
    {
        ProgramFunctionMaster GetInfo(string id);
        IEnumerable<ProgramFunctionMaster> GetAll(Dictionary<ProgramFunctionMasterRepository.SearchConditions, object> conditions);
        void Add(ProgramFunctionMaster ProgramFunctionMaster);
        void Update(ProgramFunctionMaster ProgramFunctionMaster);
        void Delete(string id);
        void Delete(ProgramFunctionMaster ProgramFunctionMaster);
        void DeleteRange(string ids);
        void DeleteRange(IEnumerable<ProgramFunctionMaster> ProgramFunctionMasters);
    }
}