using System.Collections.Generic;
using System.Threading.Tasks;
using O2Platform.Certificate.API.Data.Core;
using O2Platform.Certificate.API.Data.Core.Data;
using O2Platform.Certificate.API.Data.Models.O2C;
using O2Platform.Certificate.API.Repo.Core.Interfaces;
using O2Platform.Certificate.API.Repo.Helper;

namespace O2Platform.Certificate.API.Repo.Interfaces
{
    public interface ICertificateBaseRepository<TClass>  : IBaseRepository<TClass> 
        where TClass: class, IEntity
    {
        Task<IEnumerable<TClass>> GetAllAsync(bool showAll);
        Task<TClass> LoadPhoto(TClass existEvent, O2CPhoto o2CPhoto);
        Task<List<TClass>> AddRangeAsync(List<TClass> listEntities, bool cleanData);
        Task<PagedList<TClass>> GetAllAsync(CertificateParam certificateParam, bool info);
    }
}