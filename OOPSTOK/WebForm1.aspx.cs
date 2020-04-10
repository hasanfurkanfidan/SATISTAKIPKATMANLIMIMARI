using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ENTITYLAYER;
using DATAACCESSLAYER;
using BUSINESSLOGICLAYER;
namespace OOPSTOK
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<ENTITYDEPARTMAN> DEPLIST = BLLDEPARTMAN.BLLDEPARTMANLISTELE();
            Repeater1.DataSource = DEPLIST;
            Repeater1.DataBind();
           
        }
    }
}