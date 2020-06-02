using LocalDev.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using LocalDev.Persistence.Repositories;
using LocalDev.Persistence;

namespace LocalDev.Core.Repositories
{
    public interface IProgramFunctionAuthorityRepository : IRepository<ProgramFunctionAuthority>
    {
        ProgramFunctionAuthority GetInfo(string id);
        IEnumerable<ProgramFunctionAuthority> GetAll(Dictionary<ProgramFunctionAuthorityRepository.SearchConditions, object> conditions);
        void Add(ProgramFunctionAuthority ProgramFunctionAuthority);
        void Update(ProgramFunctionAuthority ProgramFunctionAuthority);
        void Delete(string id);
        void Delete(ProgramFunctionAuthority ProgramFunctionAuthority);
        void DeleteRange(string ids);
        void DeleteRange(IEnumerable<ProgramFunctionAuthority> ProgramFunctionAuthoritys);
        void DeleteByProgramAndFunction(string programName, string functionName);
    }
}