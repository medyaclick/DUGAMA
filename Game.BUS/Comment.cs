using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.BUS
{
    public class Comment : GameBase, IService<Comment>
    {
        public Comment(short siteId)
            : base()
        {

        }
        public List<Comment> Get()
        {
            throw new NotImplementedException();
        }

        public Comment Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Comment model)
        {
            throw new NotImplementedException();
        }

        public void Add(List<Comment> model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Comment model)
        {
            throw new NotImplementedException();
        }

        List<Comment> IService<Comment>.Get(int cacheSecond)
        {
            throw new NotImplementedException();
        }

        public Comment Get(int id, int cacheSecond)
        {
            throw new NotImplementedException();
        }
    }
}
