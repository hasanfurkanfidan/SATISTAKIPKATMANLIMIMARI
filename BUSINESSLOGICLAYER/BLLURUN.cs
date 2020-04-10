using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYER;
using DATAACCESSLAYER;

namespace BUSINESSLOGICLAYER
{
   public class BLLURUN
    {
      public static  List<ENTITYURUN>URUNLISTELE()
        {
            return DALURUN.URUNLISTELE();
        }
        public static int URUNEKLE(ENTITYURUN ent)
        {
            if(ent.Urunad !=null&&ent.Urunadet>0&&ent.Urunfiyat>-1)
            {
                DALURUN.URUNEKLE(ent);
            }
            return -1;
        }
            
    }
   
}
