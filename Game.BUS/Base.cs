using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.DATA;
using Game.Caching;
using Game.Utilities.Encryption;

namespace Game.BUS
{
    public class GameBase
    {
        protected static MasterGameDB db;
        protected short _siteId { get; private set; }
        protected CacheManagement cacheManager;
        public GameBase()
        {
            _siteId = Site.SiteId;
            db = MasterGameDB.Initilize();
            db.Configuration.LazyLoadingEnabled = false;
            db.Configuration.AutoDetectChangesEnabled = false;
            cacheManager = new CacheManagement();
        }
        protected string GetKey(params object[] parameters)
        {
            System.Diagnostics.StackFrame frame = new System.Diagnostics.StackFrame(1);
            var method = frame.GetMethod();
            //var ddd = method.GetParameters();
            var name = string.Join(",", method.DeclaringType.Name, method.Name, string.Join(",", parameters));

            return Encryption.GetMd5(name);
        }
    }
    public static class DbSetExtensions
    {
        public static TEntity FirstOrDefaultCache<TEntity>(this System.Data.Entity.DbSet<TEntity> queryable, System.Linq.Expressions.Expression<Func<TEntity, bool>> condition)
            where TEntity : class
        {
            return queryable
                .Local.Where(condition.Compile()).FirstOrDefault() // find in local cache
                   ?? queryable.Where(condition).FirstOrDefault(); // if local cache returns null check the db
        }
    }
}
