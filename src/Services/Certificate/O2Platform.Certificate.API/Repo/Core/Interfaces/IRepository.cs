using System.Threading.Tasks;
using O2Platform.Certificate.API.Data.Core.Data;

namespace O2Platform.Certificate.API.Repo.Core.Interfaces
{
    public interface IRepository<TClass> 
        where TClass : class, IEntity
    {
        Task<TClass> ExistAsync<TType, TKey>(TKey typeValue, string nameProperty);
    }
}