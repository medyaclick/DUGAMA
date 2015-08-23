using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.BUS
{
    interface IService<T>
    {
        List<T> Get(int cacheSecond);
        T Get(int id, int cacheSecond);
        void Add(T model);
        void Add(List<T> model);
        void Delete(int id);
        void Update(int id, T model);
    }
}
