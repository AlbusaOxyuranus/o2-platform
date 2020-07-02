using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using O2Platform.Certificate.API.Data.Core.Data;

namespace O2Platform.Certificate.API.Repo.Core.Interfaces
{
    public interface IBaseRepository<TClass> : IRepository<TClass>
        where TClass : class, IEntity
    {
        Task<IEnumerable<TClass>> GetAllAsync();
        Task<TClass> GetAsync(Guid id);
        Task<TClass> AddOrUpdateAsync(TClass entity);
        Task<List<TClass>> AddRangeAsync(List<TClass> listEntities);
        Task<TClass> UpdateAsync(TClass entity);
        Task<bool> SaveAllAsync();
        Task<TClass> DeleteAsync(Guid byId);
    }
}