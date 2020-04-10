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
    public partial class Personel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<ENTITYPERSONEL> perlist = BLLPERSONEL.PERLISTE();
            Repeater1.DataSource = perlist;
            Repeater1.DataBind();
        }
    }
}