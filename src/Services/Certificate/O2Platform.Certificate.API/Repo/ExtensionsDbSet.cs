using Microsoft.EntityFrameworkCore;

namespace O2Platform.Certificate.API.Repo
{
    public static class  ExtensionsDbSet
    {
        public static void Clear<T>(this DbSet<T> dbSet) where T : class
        {
            dbSet.RemoveRange(dbSet);
        }
    }
}