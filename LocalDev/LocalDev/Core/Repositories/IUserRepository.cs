using LocalDev.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using LocalDev.Persistence.Repositories;
using LocalDev.Persistence;

namespace LocalDev.Core.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        User GetUser(string id);
        IEnumerable<User> GetAllUser(Dictionary<UserRepository.SearchConditions, object> conditions);
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(string id);
        void DeleteUser(User user);
        void DeleteRangeUser(string ids);
        void DeleteRangeUser(IEnumerable<User> users);
    }
}