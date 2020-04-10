using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYER;
using DATAACCESSLAYER;
namespace BUSINESSLOGICLAYER
{
    public class BLLDEPARTMAN
    {
        public static List<ENTITYDEPARTMAN>BLLDEPARTMANLISTELE()
        {
            return DALDEPARTMAN.DEPARTMANLISTESI();
        }
        public static int DEPARTMANEKLE(ENTITYDEPARTMAN DEGER)
        {
            if (DEGER.Departmanad != null&&DEGER.Departmanad != " ")
            {
                return DALDEPARTMAN.DEPARTMANEKLE(DEGER);
            }
            return -1;
        }
    }
    
}
