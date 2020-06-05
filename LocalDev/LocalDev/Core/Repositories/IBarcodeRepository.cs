using LocalDev.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using LocalDev.Persistence.Repositories;
using LocalDev.Persistence;

namespace LocalDev.Core.Repositories
{
    public interface IBarcodeRepository : IRepository<Barcode>
    {
        Barcode GetInfo(string id);
        IEnumerable<Barcode> GetAll(Dictionary<BarcodeRepository.SearchConditions, object> conditions);
        void Add(Barcode barcode);
        void Update(Barcode barcode);
        void Delete(string id);
        void Delete(Barcode barcode);
        void DeleteRange(string ids);
        void DeleteRange(IEnumerable<Barcode> barcodes);
    }
}