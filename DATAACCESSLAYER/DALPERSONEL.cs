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
    public class DALPERSONEL
    {
        public static List<ENTITYPERSONEL> PERLIST()
        {
            List<ENTITYPERSONEL> degerler = new List<ENTITYPERSONEL>();
            SqlCommand komut = new SqlCommand("PERSONEL",SQLBAGLANTISI.bgl);
            komut.CommandType = CommandType.StoredProcedure;
            if(komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                ENTITYPERSONEL ent = new ENTITYPERSONEL();
                ent.Personelid = Convert.ToInt32(dr["PERSONELID"]);
                ent.Personelad = dr["PERSONELAD"].ToString();
                ent.Perdep = dr["DEPARTMANAD"].ToString();
                ent.Personelfotograf = dr["PERSONELFOTOGRAF"].ToString();
                ent.Personelsoyad = dr["PERSONELSOYAD"].ToString();
                ent.Personelmaas = Convert.ToDecimal(dr["PERSONELMAAS"]);
                degerler.Add(ent);

            }
            dr.Close();
            return degerler;
        }
        public static int PERSONELEKLE(ENTITYPERSONEL p)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO TBLPERSONEL (PERSONELAD,PERSONELSOYAD,PERSONELDEPARTMAN,PERSONELMAAS)VALUES(@P1,@P2,@P3,@P4)", SQLBAGLANTISI.bgl);
            if(komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@P1", p.Personelad);
            komut.Parameters.AddWithValue("@P2", p.Personelsoyad);
            komut.Parameters.AddWithValue("@P3", p.Personeldepartman);
            komut.Parameters.AddWithValue("@P4", p.Personelmaas);
            

            return komut.ExecuteNonQuery();

        }
            
    }
}
