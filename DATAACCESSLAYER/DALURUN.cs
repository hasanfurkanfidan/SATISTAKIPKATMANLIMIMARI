using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ENTITYLAYER;
using System.Data;
namespace DATAACCESSLAYER
{
    public class DALURUN
    {
       public static List<ENTITYURUN> URUNLISTELE()
        {
            List<ENTITYURUN> degerler = new List<ENTITYURUN>();
            SqlCommand komut = new SqlCommand("Select * from TBLURUNLER", SQLBAGLANTISI.bgl);
            if(komut.Connection.State !=ConnectionState.Open )
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                ENTITYURUN ent = new ENTITYURUN();
                ent.Urunad = dr["URUNAD"].ToString();
                ent.Urunfiyat = Convert.ToDecimal(dr["URUNFIYAT"]);
                ent.Urunid = Convert.ToInt32(dr["URUNID"]);
                ent.Urunadet = Convert.ToInt32(dr["URUNADET"]);
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;

        }
        public static int URUNEKLE(ENTITYURUN ent)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO TBLURUNLER (URUNAD,URUNFIYAT,URUNADET) VALUES (@P1,@P2,@P3)", SQLBAGLANTISI.bgl);
            if(komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();

            }
            komut.Parameters.AddWithValue("@P1", ent.Urunad);
            komut.Parameters.AddWithValue("@p2", ent.Urunfiyat);
            komut.Parameters.AddWithValue("@P3", ent.Urunadet);

            return komut.ExecuteNonQuery();
        }
    }
}
