using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYER;
using System.Data;
using System.Data.SqlClient;
namespace DATAACCESSLAYER
{
    public class DALSATIS
    {
       public static List<ENTITYSATIS> SATISLISTELE()
        {
            List<ENTITYSATIS> degerler = new List<ENTITYSATIS>();
            SqlCommand komut = new SqlCommand("SATISLAR", SQLBAGLANTISI.bgl);
            komut.CommandType = CommandType.StoredProcedure;

            if(komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                ENTITYSATIS ent = new ENTITYSATIS();
                ent.Musteriad = dr["MUSTERI"].ToString();
                ent.Satisid = Convert.ToInt32(dr["SATISID"]);
                ent.Urunad = dr["URUNAD"].ToString();
                ent.Personelad = dr["PERSONEL"].ToString();
               // ent.Personelsoyad = dr["PERSONELSOYAD"].ToString();
                ent.Musteriad = dr["MUSTERI"].ToString();
                ent.TUTAR = Convert.ToDecimal(dr["TUTAR"]);
                //ent.Musterisoyad = dr["MUSTERISOYAD"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
       public static int SATISYAP(ENTITYMUSTERI mus,ENTITYURUN ur,ENTITYPERSONEL per,ENTITYSATIS sat)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO TBlSATIS(URUN,PERSONEL,TUTAR,MUSTERI) values(@p1,@p2,@p3,@p4)", SQLBAGLANTISI.bgl);
            if(komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", mus.Musteriid);
            komut.Parameters.AddWithValue("@p2", ur.Urunid);
            komut.Parameters.AddWithValue("@p3", sat.TUTAR);
            komut.Parameters.AddWithValue("@p4",mus.Musteriid);

            return komut.ExecuteNonQuery();
        }
    }
}
