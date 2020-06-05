using LocalDev.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using LocalDev.Persistence.Repositories;
using LocalDev.Persistence;

namespace LocalDev.Core.Repositories
{
    public interface IUserAuthorityRepository : IRepository<UserAuthority>
    {
        UserAuthority GetInfo(string id);
        IEnumerable<UserAuthority> GetAll(Dictionary<UserAuthorityRepository.SearchConditions, object> conditions);
        void Add(UserAuthority userAuthority);
        void Update(UserAuthority userAuthority);
        void Delete(string id);
        void Delete(UserAuthority userAuthority);
        void DeleteRange(string ids);
        void DeleteRange(IEnumerable<UserAuthority> userAuthoritys);
        void DeleteByUserID(string userID);
    }
}