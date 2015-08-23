using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.BUS
{
    public class CategoryOperations : GameBase, IService<Game.Domain.Category>
    {
        public List<Domain.Category> Get(int cacheSecond)
        {
            var result = db.Categories.Where(p => p.Site_Id == _siteId)
                                      .Select(p => new Game.Domain.Category
                                      {
                                          Id = p.id,
                                          Name = p.Name,
                                          ImageUrl = p.Icon_Path
                                      }).ToList();

            List<Game.Domain.Category> list = new List<Domain.Category>();
            list.Add(new Domain.Category { Name = "Çocuk Oyunları", ImageUrl = "", Url = "cocuk-oyunlari" });
            list.Add(new Domain.Category { Name = "Çocuk Oyunları2", ImageUrl = "", Url = "cocuk-oyunlari2" });
            list.Add(new Domain.Category { Name = "Çocuk Oyunları3", ImageUrl = "", Url = "cocuk-oyunlari3" });

            return list;
        }

        public Domain.Category Get(int id, int cacheSecond)
        {
            throw new NotImplementedException();
        }

        public void Add(Domain.Category model)
        {
            throw new NotImplementedException();
        }

        public void Add(List<Domain.Category> model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Domain.Category model)
        {
            throw new NotImplementedException();
        }
    }
}
