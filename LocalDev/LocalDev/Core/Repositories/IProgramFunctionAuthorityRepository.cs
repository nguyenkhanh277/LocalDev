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
        void Add(ProgramFunctionAuthority programFunctionAuthority);
        void Update(ProgramFunctionAuthority programFunctionAuthority);
        void Delete(string id);
        void Delete(ProgramFunctionAuthority programFunctionAuthority);
        void DeleteRange(string ids);
        void DeleteRange(IEnumerable<ProgramFunctionAuthority> programFunctionAuthoritys);
        void DeleteByProgramAndFunction(string programName, string functionName);
    }
}