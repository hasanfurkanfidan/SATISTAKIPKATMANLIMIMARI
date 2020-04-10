using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DATAACCESSLAYER;
using BUSINESSLOGICLAYER;
using ENTITYLAYER;
using System.Data;
using System.Data.SqlClient;
namespace OOPSTOK
{
    public partial class PERSONELEKLE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                SqlCommand komut = new SqlCommand("Select * from TBLDEPARTMAN", SQLBAGLANTISI.bgl);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DropDownList1.DataValueField = "DEPARTMANID";
                DropDownList1.DataTextField = "DEPARTMANAD";
                DropDownList1.DataSource = dt;
                DropDownList1.DataBind();
            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            ENTITYPERSONEL ent = new ENTITYPERSONEL();
            ent.Personelad = TextBox1.Text;
            ent.Personelsoyad = TextBox2.Text;
            ent.Personelmaas = Convert.ToDecimal(TextBox3.Text);
            ent.Personeldepartman =Convert.ToByte(DropDownList1.SelectedValue);

            BLLPERSONEL.PERSONELEKLE(ent);
            Response.Redirect("Personel.aspx");
        }
    }
}