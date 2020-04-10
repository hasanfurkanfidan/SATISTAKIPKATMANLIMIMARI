using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ENTITYLAYER;
using BUSINESSLOGICLAYER;
using DATAACCESSLAYER;
namespace OOPSTOK
{
    public partial class URUN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<ENTITYURUN> URUNLIST = BLLURUN.URUNLISTELE();
            Repeater1.DataSource = URUNLIST;
            Repeater1.DataBind();
        }
    }
}