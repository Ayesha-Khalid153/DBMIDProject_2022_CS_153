using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMID_Project_2022CS153final
{
    public class Controler
    {
        private static string checkerType = "";

        public static string CheckerType { get => checkerType; set => checkerType = value; }

        public static int GetNumberofRecords(string tableName)
        {
            var c = Configuration.getInstance().getConnection();
            SqlCommand s = new SqlCommand("Select Count(*) from " + tableName, c);
            int count = (int)s.ExecuteScalar();
            return count;
        }

        public static int IdGetterLast(string tableName)
        {

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 Id FROM " + tableName + " ORDER BY Id DESC", con); // Use TOP 1 for SQL Server
            int lastId;
            try
            {
                object result = cmd.ExecuteScalar();
                lastId = result == null ? 0 : (int)result; // Handle null result (no records)
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return lastId;
        }
        public static void loadGrid(string table, DataGridView dataGrid)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from [" + table + "] ;", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGrid.DataSource = dt;
        }
        public static void loadGrid(string table, string condition, DataGridView dataGrid)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from [" + table + "] " + condition + " ;", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGrid.DataSource = dt;
        }
    }
}
