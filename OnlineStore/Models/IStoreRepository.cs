using System;
using System.Linq;

namespace OnlineStore.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}
