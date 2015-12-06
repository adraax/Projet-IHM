using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_project_VERON_MERLIN
{
    public class ConnexionOracle
    {
        private OracleConnection connec;
        private DbProviderFactory dbpf;
        private DbDataAdapter dba;

        public ConnexionOracle()
        {
            connec = new OracleConnection();
            connec.ConnectionString = "User Id=om141055; Password=om141055; Data Source=//ufrsciencestech.u-bourgogne.fr:25559/ense2015";
            dbpf = DbProviderFactories.GetFactory("Oracle.DataAccess.Client");
            connec.Open();

            // initialisation de la connexion conn et de dbpf
            dba = dbpf.CreateDataAdapter();
        }

        public DataSet Select(string commande)
        {
            dba.SelectCommand = connec.CreateCommand();
            dba.SelectCommand.CommandText = commande;
            DataSet ds = new DataSet();
            dba.Fill(ds, "Data");
            return ds;
        }

        public void Insert(string commande)
        {
            try
            {
                dba.InsertCommand = connec.CreateCommand();
                dba.InsertCommand.CommandText = commande;
                dba.InsertCommand.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                Trace.WriteLine($"Erreur Insert : {e.Message}");
            }

        }

        public void Update(string commande)
        {
            try
            {
                dba.UpdateCommand = connec.CreateCommand();
                dba.UpdateCommand.CommandText = commande;
                dba.UpdateCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Trace.WriteLine($"Erreur Update : {e.Message}");
            }

        }

        public void Delete(string commande)
        {
            try
            {
                dba.DeleteCommand = connec.CreateCommand();
                dba.DeleteCommand.CommandText = commande;
                dba.DeleteCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Trace.WriteLine($"Erreur Delete : {e.Message}");
            }

        }
    }
}
