using System.IO;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System;

namespace EasyPlant
{
    public static class ParametrageBase
    {

        public static string connectionString, serverName, dataBaseName, connectionMode, cheminDataBase;
        public static void parametrerBase()
        {
            string cheminFichier = ConfigurationManager.AppSettings["FichierParametresBase"];
             dataBaseName = ConfigurationManager.AppSettings["DataBaseName"];
            string line;
            int counter = 1;
            // Read the file and display it line by line.  
            var fs = new FileStream(cheminFichier, FileMode.Open, FileAccess.Read);
            var sr = new StreamReader(fs, Encoding.UTF8);
            while ((line = sr.ReadLine()) != null)
            {
                if (counter == 1)
                {
                    serverName = line.ToString().Trim();
                }
                if (counter == 2)
                {
                    cheminDataBase= line.ToString().Trim(); 
                }
                if (counter == 3)
                {
                    connectionMode= line.ToString().Trim(); 
                }
                counter++;
            }
            connectionString = "Data Source=" + serverName + " ;Initial Catalog=" + dataBaseName + " ;Integrated Security=True";
            fs.Close();
        }

        public static string attachDatabase()
        {
            string result = "OK";
            string dataBaseName = ConfigurationManager.AppSettings["DataBaseName"];
            string cnxString= "Data Source=" + serverName + " ;Initial Catalog=master ;Integrated Security=True";
            SqlConnection con = new SqlConnection(cnxString);
            string filename1 = cheminDataBase +"\\" + dataBaseName + ".mdf";
            string filename2 = cheminDataBase + "\\" + dataBaseName + "_log.ldf";
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select name from sys.databases", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                string[] array = dt
                    .AsEnumerable()
                    .Select(row => row.Field<string>("Name"))
                    .ToArray();

                if (!array.Contains(dataBaseName, StringComparer.OrdinalIgnoreCase))
                {
                    //use master
                    //go
                    //select db_name(database_id) as [Database Name],type_desc as [File Type], physical_name as [Database File Location] from sys.master_files
                    //where database_id >= 5--exclude system databases


                    //USE[master]
                    //GO
                    //EXEC sp_attach_db @dbname = N'BDPlant',   
                    //@filename1 = 'C:\EasyPlant\BDPlant.mdf',   
                    //@filename2 = 'C:\EasyPlant\BDPlant_log.ldf';
                    SqlCommand cmd = new SqlCommand("sp_attach_db");
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@dbname", dataBaseName);
                    cmd.Parameters.AddWithValue("@filename1", filename1);
                    cmd.Parameters.AddWithValue("@filename2", filename2);
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
            }
            catch (Exception ex)
            {
                con.Close();
                result = ex.Message;
            }
            return result;
        }

    }
}
