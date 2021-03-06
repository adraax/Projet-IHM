﻿using Oracle.DataAccess.Client;
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
            connec.ConnectionString = string.Format("User Id=om141055; Password=om141055; Data Source=//{0}", Properties.Settings.Default.connexion);
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
                Trace.WriteLine(string.Format("Erreur Insert : {0}", e.Message));
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
                Trace.WriteLine(string.Format("Erreur Update : {0}", e.Message));
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
                Trace.WriteLine(string.Format("Erreur Delete : {0}", e.Message));
            }

        }
    }
}
