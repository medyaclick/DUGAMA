using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.DATA;
using Game.Domain;

namespace Game.BUS
{
    public class GameOperations : GameBase, IService<Game.Domain.Game>
    {
        private static GameOperations _gameOp = null;
        private GameOperations()
            : base()
        {

        }
        public static GameOperations Initilize()
        {
            if (_gameOp == null)
                _gameOp = new GameOperations();

            return _gameOp;
        }

        public List<Domain.Game> Get(int cacheSecond)
        {
            var games = db.Games.Where(p => p.Site_Id == _siteId).Select(p => new Game.Domain.Game { Name = p.Name }).ToList();

            return games;
        }
        public Domain.Game Get(int id, int cacheSecond)
        {
            string hashKey = GetKey(id);
            var cacheResult = cacheManager.Get<Game.Domain.Game>(hashKey);

            if (cacheResult != null)
                return cacheResult;

            var result = db.Games.Where(p => p.Site_Id == _siteId && p.id == id).Select(p =>
                new Game.Domain.Game { Name = p.Name }).FirstOrDefault();

            if (result == null)
                throw new Exception("Kayıt bulunamadı");

            cacheManager.Add<Game.Domain.Game>(hashKey, new Game.Domain.Game { Name = "UĞur" }, cacheSecond);
            return result;
        }
        public List<Domain.Game> GetNewGames(int cacheSecond, int top = 20)
        {
            List<Domain.Game> list = new List<Domain.Game>();
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://img.sunoyun.com/2/2014-08/3d-araba-gezisi.jpg", Url = "sd-araba-gezisi" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://img.sunoyun.com/2/2014-08/3d-araba-gezisi.jpg", Url = "sd-araba-gezisi" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://img.sunoyun.com/2/2014-08/3d-araba-gezisi.jpg", Url = "sd-araba-gezisi" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://img.sunoyun.com/2/2014-08/3d-araba-gezisi.jpg", Url = "sd-araba-gezisi" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://img.sunoyun.com/2/2014-08/3d-araba-gezisi.jpg", Url = "sd-araba-gezisi" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://img.sunoyun.com/2/2014-08/3d-araba-gezisi.jpg", Url = "sd-araba-gezisi" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://img.sunoyun.com/2/2014-08/3d-araba-gezisi.jpg", Url = "sd-araba-gezisi" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://img.sunoyun.com/2/2014-08/3d-araba-gezisi.jpg", Url = "sd-araba-gezisi" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://img.sunoyun.com/2/2014-08/3d-araba-gezisi.jpg", Url = "sd-araba-gezisi" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://img.sunoyun.com/2/2014-08/3d-araba-gezisi.jpg", Url = "sd-araba-gezisi" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://img.sunoyun.com/2/2014-08/3d-araba-gezisi.jpg", Url = "sd-araba-gezisi" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://img.sunoyun.com/2/2014-08/3d-araba-gezisi.jpg", Url = "sd-araba-gezisi" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://img.sunoyun.com/2/2014-08/3d-araba-gezisi.jpg", Url = "sd-araba-gezisi" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://img.sunoyun.com/2/2014-08/3d-araba-gezisi.jpg", Url = "sd-araba-gezisi" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://img.sunoyun.com/2/2014-08/3d-araba-gezisi.jpg", Url = "sd-araba-gezisi" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://img.sunoyun.com/2/2014-08/3d-araba-gezisi.jpg", Url = "sd-araba-gezisi" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://img.sunoyun.com/2/2014-08/3d-araba-gezisi.jpg", Url = "sd-araba-gezisi" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://img.sunoyun.com/2/2014-08/3d-araba-gezisi.jpg", Url = "sd-araba-gezisi" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://img.sunoyun.com/2/2014-08/3d-araba-gezisi.jpg", Url = "sd-araba-gezisi" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://img.sunoyun.com/2/2014-08/3d-araba-gezisi.jpg", Url = "sd-araba-gezisi" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://img.sunoyun.com/2/2014-08/3d-araba-gezisi.jpg", Url = "sd-araba-gezisi" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://img.sunoyun.com/2/2014-08/3d-araba-gezisi.jpg", Url = "sd-araba-gezisi" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://img.sunoyun.com/2/2014-08/3d-araba-gezisi.jpg", Url = "sd-araba-gezisi" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://img.sunoyun.com/2/2014-08/3d-araba-gezisi.jpg", Url = "sd-araba-gezisi" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://img.sunoyun.com/2/2014-08/3d-araba-gezisi.jpg", Url = "sd-araba-gezisi" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://img.sunoyun.com/2/2014-08/3d-araba-gezisi.jpg", Url = "sd-araba-gezisi" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://img.sunoyun.com/2/2014-08/3d-araba-gezisi.jpg", Url = "sd-araba-gezisi" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://img.sunoyun.com/2/2014-08/3d-araba-gezisi.jpg", Url = "sd-araba-gezisi" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://img.sunoyun.com/2/2014-08/3d-araba-gezisi.jpg", Url = "sd-araba-gezisi" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://img.sunoyun.com/2/2014-08/3d-araba-gezisi.jpg", Url = "sd-araba-gezisi" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://img.sunoyun.com/2/2014-08/3d-araba-gezisi.jpg", Url = "sd-araba-gezisi" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://img.sunoyun.com/2/2014-08/3d-araba-gezisi.jpg", Url = "sd-araba-gezisi" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://img.sunoyun.com/2/2014-08/3d-araba-gezisi.jpg", Url = "sd-araba-gezisi" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://img.sunoyun.com/2/2014-08/3d-araba-gezisi.jpg", Url = "sd-araba-gezisi" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://img.sunoyun.com/2/2014-08/3d-araba-gezisi.jpg", Url = "sd-araba-gezisi" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://img.sunoyun.com/2/2014-08/3d-araba-gezisi.jpg", Url = "sd-araba-gezisi" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://img.sunoyun.com/2/2014-08/3d-araba-gezisi.jpg", Url = "sd-araba-gezisi" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://img.sunoyun.com/2/2014-08/3d-araba-gezisi.jpg", Url = "sd-araba-gezisi" });

            return list;


            string hashKey = GetKey(cacheSecond, top);
            var cacheResult = cacheManager.Get<List<Game.Domain.Game>>(hashKey);

            if (cacheResult != null)
                return cacheResult;

            var result = db.Games.Where(p => p.Site_Id == _siteId).OrderByDescending(p => p.id).Select(p => new Game.Domain.Game { Name = p.Name, ImageUrl = p.Name, Url = p.Name_Url }).Take(top).ToList();

            if (result == null)
                throw new Exception("Kayıt bulunamadı");

            cacheManager.Add<List<Game.Domain.Game>>(hashKey, result, cacheSecond);

            return result;
        }

        public List<Domain.Game> GetPopularGames(int cacheSecond, int top = 20)
        {
            List<Domain.Game> list = new List<Domain.Game>();
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://images.oyunskor.com/resim/2010/3/candycrush.jpg", Url = "sd-araba-gezisi", Point = "75.1" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://images.oyunskor.com/resim/2010/3/candycrush.jpg", Url = "sd-araba-gezisi", Point = "30.3" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://images.oyunskor.com/resim/2010/3/candycrush.jpg", Url = "sd-araba-gezisi", Point = "10.5" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://images.oyunskor.com/resim/2010/3/candycrush.jpg", Url = "sd-araba-gezisi", Point = "98.2" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://images.oyunskor.com/resim/2010/3/candycrush.jpg", Url = "sd-araba-gezisi", Point = "65.3" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://images.oyunskor.com/resim/2010/3/candycrush.jpg", Url = "sd-araba-gezisi", Point = "95.9" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://images.oyunskor.com/resim/2010/3/candycrush.jpg", Url = "sd-araba-gezisi", Point = "15.3" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://images.oyunskor.com/resim/2010/3/candycrush.jpg", Url = "sd-araba-gezisi", Point = "45.7" });
            list.Add(new Domain.Game { Name = "3D Araba Gezisi", ImageUrl = "http://images.oyunskor.com/resim/2010/3/candycrush.jpg", Url = "sd-araba-gezisi", Point = "50.1" });
            return list;


            string hashKey = GetKey(cacheSecond, top);
            var cacheResult = cacheManager.Get<List<Game.Domain.Game>>(hashKey);

            if (cacheResult != null)
                return cacheResult;

            var result = db.Games.Where(p => p.Site_Id == _siteId).OrderByDescending(p => p.id).Select(p => new Game.Domain.Game { Name = p.Name, ImageUrl = p.Name, Url = p.Name_Url }).Take(top).ToList();

            if (result == null)
                throw new Exception("Kayıt bulunamadı");

            cacheManager.Add<List<Game.Domain.Game>>(hashKey, result, cacheSecond);

            return result;
        }

        public void Add(Domain.Game model)
        {
            db.Games.Add(new Games { Name = model.Name });
            db.SaveChanges();
        }

        public void Add(List<Domain.Game> model)
        {
            foreach (var item in model)
            {
                db.Games.Add(new Games { Name = item.Name });
            }
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            //var result = db.Games.Where(p => p.id == id).FirstOrDefault();
            var result = db.Games.Find(id);

            if (result == null)
                throw new Exception("Silinecek kayıt bulunamadı");

            db.Games.Remove(result);
            db.SaveChanges();
        }

        public void Update(int id, Domain.Game model)
        {
            var result = db.Games.Find(id);
            if (result == null)
                throw new Exception("Güncellenecek kayıt bulunamadı");

            result.Name = model.Name;
            db.SaveChanges();
        }
    }
}
