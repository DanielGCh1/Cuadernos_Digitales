using facturas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnection.Connection
{
    public class MyDBSQL : DbAccess
    {
        public override void OpenConnection()
        {
            Connection = new MySqlConnection(ConnectionString);
            Connection.Open();
            
        }
        public override void CloseConnection()
        {
            if (Connection != null)
            {
                Connection.Close();
            }

        }
        public override DataTable QuerySQL(string query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable result = new DataTable();
            adapter.SelectCommand = new MySqlCommand(query, (MySqlConnection)Connection);
            adapter.Fill(result);
            return result;
        }
        public override long EjectSQL(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, (MySqlConnection)Connection);
            return cmd.ExecuteNonQuery();
        }
        public override bool IsTransaction()
        {
            return (Transaction!=null);
        }
        public override void CommitTransaction()
        {
            if (IsTransaction())
            {
                Transaction.Commit();
            }
        }
        public override void RollBackTransaction()
        {
            if (IsTransaction())
            {
                Transaction.Rollback();
            }
        }

        public override void BeginTransaction()
        {
            Transaction = Connection.BeginTransaction();
        }
    }
}
