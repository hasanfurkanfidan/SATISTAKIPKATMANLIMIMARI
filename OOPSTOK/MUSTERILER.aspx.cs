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
    public partial class MUSTERILER : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<ENTITYMUSTERI> MUSTLIST = DALMUSTERI.MUSTERILISTESI();
            Repeater1.DataSource = MUSTLIST;
            Repeater1.DataBind();
        }
    }
}