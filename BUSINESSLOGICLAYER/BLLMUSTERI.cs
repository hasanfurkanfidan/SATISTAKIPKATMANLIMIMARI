using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYER;
using DATAACCESSLAYER;
namespace BUSINESSLOGICLAYER
{
    public class BLLMUSTERI
    {
        public static List<ENTITYMUSTERI>BLLLISTELE()
        {
            return DALMUSTERI.MUSTERILISTESI();
        }
        public static int MUSTERIEKLE(ENTITYMUSTERI p)
        {
            if (p.Musteriad != null&&p.Musterisoyad !=null)
            {
                return DALMUSTERI.MUSTERIEKLE(p);
            }
            return -1;
        }
            
    }
}
