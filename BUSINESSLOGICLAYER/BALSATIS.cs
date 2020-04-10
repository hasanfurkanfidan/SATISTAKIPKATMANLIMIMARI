using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYER;
using DATAACCESSLAYER;
namespace BUSINESSLOGICLAYER
{
   public class BALSATIS
    {
       public static List<ENTITYSATIS> SATISLISTELE()
        {
            return DALSATIS.SATISLISTELE();
        }
        public static int SATISYAP(ENTITYMUSTERI MUS,ENTITYURUN UR,ENTITYPERSONEL PER , ENTITYSATIS SAT)
        {
            return DALSATIS.SATISYAP(MUS, UR, PER, SAT);
        }
    }
}
