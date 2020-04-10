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
    public partial class DEPARTMANEKLE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ENTITYDEPARTMAN ent = new ENTITYDEPARTMAN();
            ent.Departmanad = TextBox1.Text;
            BLLDEPARTMAN.DEPARTMANEKLE(ent);
        }
    }
}