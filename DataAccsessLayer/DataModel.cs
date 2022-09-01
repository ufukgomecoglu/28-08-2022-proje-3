using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer
{
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;
        public DataModel()
        {
            con = new SqlConnection(ConnectionString.ConStr);
            cmd = con.CreateCommand();
        }
        public List<Universite> GetUni()
        {
            try
            {
                cmd.CommandText = "SELECT ID,Isim FROM yok_universiteler";
                con.Open();
                List<Universite> universiteler = new List<Universite>();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    universiteler.Add(new Universite { ID=reader.GetInt32(0),Isim=reader.GetString(1)});
                }
                return universiteler;
            }
            catch (Exception)
            {

                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public List<Fakulte> GetFakulte(int uniID)
        {
            try
            {
                cmd.CommandText = "SELECT ID,UniversiteID,Isim FROM yok_fakulteler WHERE UniversiteID=@UniversiteID";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@UniversiteID", uniID);
                con.Open();
                List<Fakulte> fakulteler = new List<Fakulte>();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    fakulteler.Add(new Fakulte { ID = reader.GetString(0), UniversiteID = reader.GetInt32(1), Isim = reader.GetString(2) });
                }
                return fakulteler;
            }
            catch (Exception)
            {

                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public List<Bolum> GetBolum(string FakID,int UniID)
        {
           
            try
            {
                cmd.CommandText = "SELECT ID,Isim FROM yok_Bolumler WHERE UniversiteID=@UniversiteID AND fakulteID=@fakulteID ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@UniversiteID", UniID);
                cmd.Parameters.AddWithValue("@fakulteID", FakID);
                con.Open();
                List<Bolum> bolumler = new List<Bolum>();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    bolumler.Add(new Bolum { ID = reader.GetInt32(0), Isim = reader.GetString(1) });
                }
                return bolumler;
            }
            catch (Exception)
            {

                return null;
            }
            finally {con.Close();}
        }
    }
}
