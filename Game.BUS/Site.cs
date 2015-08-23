using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.BUS
{
    public class Site : GameBase
    {
        public static short SiteId = 0;
        public Site()
            : base()
        {
        }
        public void SetSiteId(string host)
        {
            SiteId = db.Web_Sites.Where(p => p.Url == host).Select(p => p.id).FirstOrDefault();
        }
    }
}
