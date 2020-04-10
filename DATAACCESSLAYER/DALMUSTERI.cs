using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYER;
using System.Data.SqlClient;
using System.Data;
namespace DATAACCESSLAYER
{
   public class DALMUSTERI
    {
        public static List<ENTITYMUSTERI>MUSTERILISTESI()
        {
            List<ENTITYMUSTERI> DEGERLER = new List<ENTITYMUSTERI>();
            SqlCommand komut = new SqlCommand("select * from TBLMUSTERI",SQLBAGLANTISI.bgl);
            if(komut.Connection.State !=ConnectionState.Open )
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                ENTITYMUSTERI ent = new ENTITYMUSTERI();
                ent.Musteriad = dr["MUSTERIAD"].ToString();
                ent.Musterisoyad = dr["MUSTERISOYAD"].ToString();
                DEGERLER.Add(ent);
            }
            komut.Connection.Close();
            dr.Close();
            return DEGERLER;
            
        }
        public static int MUSTERIEKLE(ENTITYMUSTERI p)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO TBLMUSTERI (MUSTERIAD,MUSTERISOYAD) VALUES (@P1,@P2)", SQLBAGLANTISI.bgl);
            if(komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@P1", p.Musteriad);
            komut.Parameters.AddWithValue("@P2", p.Musterisoyad);
            return komut.ExecuteNonQuery();

        }
    }
}
