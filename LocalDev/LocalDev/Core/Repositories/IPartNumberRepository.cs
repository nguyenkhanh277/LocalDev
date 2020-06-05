using LocalDev.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using LocalDev.Persistence.Repositories;
using LocalDev.Persistence;

namespace LocalDev.Core.Repositories
{
    public interface IPartNumberRepository : IRepository<PartNumber>
    {
        PartNumber GetInfo(string id);
        IEnumerable<PartNumber> GetAll(Dictionary<PartNumberRepository.SearchConditions, object> conditions);
        void Add(PartNumber partNumber);
        void Update(PartNumber partNumber);
        void Delete(string id);
        void Delete(PartNumber partNumber);
        void DeleteRange(string ids);
        void DeleteRange(IEnumerable<PartNumber> partNumbers);
    }
}