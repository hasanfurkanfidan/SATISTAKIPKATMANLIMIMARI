using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYER;
using DATAACCESSLAYER;

namespace BUSINESSLOGICLAYER
{
    public class BLLPERSONEL
    {
        public static List<ENTITYPERSONEL>PERLISTE()
        {
            return DALPERSONEL.PERLIST();
        }
        public static int PERSONELEKLE(ENTITYPERSONEL p)
        {
            if(p.Personelad!=null)
            {
                DALPERSONEL.PERSONELEKLE(p);
            }
            return -1;
        }
    }
}
