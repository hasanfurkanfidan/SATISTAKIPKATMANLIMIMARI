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
    public partial class MUSTERIEKLE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            ENTITYMUSTERI ent = new ENTITYMUSTERI();
            ent.Musteriad = TextBox1.Text;
            ent.Musterisoyad = TextBox2.Text;
            BLLMUSTERI.MUSTERIEKLE(ent);
        }
    }
}