using LocalDev.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using LocalDev.Persistence.Repositories;
using LocalDev.Persistence;

namespace LocalDev.Core.Repositories
{
    public interface IAuthorityGroupRepository : IRepository<AuthorityGroup>
    {
        AuthorityGroup GetInfo(int? id);
        IEnumerable<AuthorityGroup> GetAll(Dictionary<AuthorityGroupRepository.SearchConditions, object> conditions);
        void Add(AuthorityGroup AuthorityGroup);
        void Update(AuthorityGroup AuthorityGroup);
        void Delete(int? id);
        void Delete(AuthorityGroup AuthorityGroup);
        //void DeleteRange(string ids);
        void DeleteRange(IEnumerable<AuthorityGroup> AuthorityGroups);
    }
}