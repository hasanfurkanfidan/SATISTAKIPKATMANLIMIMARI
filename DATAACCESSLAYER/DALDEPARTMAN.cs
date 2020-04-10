using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ENTITYLAYER;
using System.Data;
using System.Data.SqlClient;

namespace DATAACCESSLAYER
{
    public class DALDEPARTMAN
    {
        public static List<ENTITYDEPARTMAN>DEPARTMANLISTESI()
        {
            List<ENTITYDEPARTMAN> degerler = new List<ENTITYDEPARTMAN>();
            SqlCommand komut = new SqlCommand("Select * from tbldepartman", SQLBAGLANTISI.bgl);
            if(komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                ENTITYDEPARTMAN ent = new ENTITYDEPARTMAN();
                ent.Departmanid = Convert.ToByte(dr["DEPARTMANID"]);
                ent.Departmanad = dr["DEPARTMANAD"].ToString();
                degerler.Add(ent);

            }
            dr.Close();
            return degerler;
        }
        public static int DEPARTMANEKLE(ENTITYDEPARTMAN DEGER)
        {
            SqlCommand komut = new SqlCommand("insert into TBLDEPARTMAN (DEPARTMANAD) VALUES (@P1)", SQLBAGLANTISI.bgl);
            if(komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@P1", DEGER.Departmanad);
            return komut.ExecuteNonQuery();
        }
    }
}
