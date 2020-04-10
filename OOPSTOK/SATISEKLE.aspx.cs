using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using ENTITYLAYER;
using BUSINESSLOGICLAYER;
using DATAACCESSLAYER;
namespace OOPSTOK
{
    public partial class SATISEKLE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                SqlCommand komut = new SqlCommand("Select URUNID,URUNAD from TBLURUNLER", SQLBAGLANTISI.bgl);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DropDownList1.DataValueField = "URUNID";
            DropDownList1.DataTextField = "URUNAD";
            DropDownList1.DataSource = dt;
            DropDownList1.DataBind();
            SqlCommand komut1 = new SqlCommand("Select PERSONELID,PERSONELAD FROM TBLPERSONEL", SQLBAGLANTISI.bgl);
            SqlDataAdapter da1 = new SqlDataAdapter(komut1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            DropDownList2.DataValueField = "PERSONELID";
            DropDownList2.DataTextField = "PERSONELAD";
            DropDownList2.DataSource = dt1;
            DropDownList2.DataBind();
            SqlCommand komut2 = new SqlCommand("Select MUSTERIID,MUSTERIAD FROM TBLMUSTERI", SQLBAGLANTISI.bgl);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            DropDownList3.DataValueField = "MUSTERIID";
            DropDownList3.DataTextField = "MUSTERIAD";
            DropDownList3.DataSource = dt2;
            DropDownList3.DataBind();
        }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            ENTITYURUN ent = new ENTITYURUN();
            ENTITYPERSONEL ent1 = new ENTITYPERSONEL();
            ENTITYMUSTERI ent2 = new ENTITYMUSTERI();
            ENTITYSATIS ent3 = new ENTITYSATIS();
            DropDownList1.DataValueField = "URUNID";

            ent.Urunid =Convert.ToInt32( DropDownList1.SelectedIndex);
            ent1.Personelid = Convert.ToInt32(DropDownList2.SelectedIndex);
            ent2.Musteriid = Convert.ToInt32(DropDownList3.SelectedIndex);
            ent3.TUTAR = Convert.ToDecimal(TextBox1.Text);
            BALSATIS.SATISYAP(ent2, ent, ent1, ent3);


        }
    }
}