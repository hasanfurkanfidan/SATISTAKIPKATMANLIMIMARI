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
    public partial class URUNEKLE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            ENTITYURUN ent = new ENTITYURUN();
            ent.Urunad = TextBox1.Text;
            ent.Urunadet =Convert.ToInt16(TextBox2.Text);
            ent.Urunfiyat =Convert.ToDecimal(TextBox3.Text);
            BLLURUN.URUNEKLE(ent);
        }
    }
}