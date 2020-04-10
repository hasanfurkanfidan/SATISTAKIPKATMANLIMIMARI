using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ENTITYLAYER;
using BUSINESSLOGICLAYER;

namespace OOPSTOK
{
    public partial class SATISLAR : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<ENTITYSATIS> degerler = BALSATIS.SATISLISTELE();
            Repeater1.DataSource = degerler;
            Repeater1.DataBind();
        }
    }
}