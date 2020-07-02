
using Microsoft.EntityFrameworkCore;

namespace O2Platform.Certificate.API.Data.Core
{
    public static class ExtensionsDataContext
    {
        public static DbSet<TModel> GetDataSet<TModel>(this DbContext dataContext) where TModel : class
        {
            return dataContext.Set<TModel>();
        }
    }
}