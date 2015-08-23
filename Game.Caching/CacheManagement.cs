using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Game.Caching
{
    public class CacheManagement
    {
        /// <summary>
        /// Key'i verilen datayı cach'ten temizler
        /// </summary>
        /// <param name="Key"></param>
        public void Remove(string Key)
        {
            HttpContext.Current.Cache.Remove(Key);
        }
        /// <summary>
        /// Verilen Key'e göre datayı cacheler
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Key">Cache data ismi</param>
        /// <param name="data">Cache data</param>
        /// <param name="Minute">Dakika</param>
        public void Add<T>(string Key, T data, int second)
        {
            HttpContext.Current.Cache.Insert(Key, data, null, DateTime.Now.AddSeconds(second), System.Web.Caching.Cache.NoSlidingExpiration);
        }
        /// <summary>
        /// Verilen Key'e göre Cache'ten data döndürür
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Key"></param>
        /// <returns></returns>
        public T Get<T>(string Key)
        {
            return (T)HttpContext.Current.Cache[Key];
        }

        public bool IsExists(string key)
        {
            throw new NotImplementedException();
        }
    }
}
