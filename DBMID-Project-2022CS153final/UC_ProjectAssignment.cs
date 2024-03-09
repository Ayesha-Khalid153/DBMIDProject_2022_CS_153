using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMID_Project_2022CS153final
{
    public partial class UC_ProjectAssignment : UserControl
    {
        public UC_ProjectAssignment()
        {
            InitializeComponent();
        }

        private void btn_ProjectRetrieve_Click(object sender, EventArgs e)
        {
            grd_ProjectAssignmentDetails.ReadOnly = true;
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select ProjectID , GroupID , AssignmentDate  from GroupProject", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            grd_ProjectAssignmentDetails.DataSource = dt;
        }

        private void btn_ProjectCreate_Click(object sender, EventArgs e)
        {
            if (cmb_GroupID.Text == "" || cmb_ProjectID.Text == "" || DateTimeProjectAssignment.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                var con = Configuration.getInstance().getConnection();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("Insert into GroupProject (ProjectId, GroupId, AssignmentDate) values (@ProjectId, @GroupId, @AssignmentDate)", con);
                cmd.Parameters.AddWithValue("@ProjectId", cmb_ProjectID.Text);
                cmd.Parameters.AddWithValue("@GroupId", cmb_GroupID.Text);
                cmd.Parameters.AddWithValue("@AssignmentDate", DateTimeProjectAssignment.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmb_GroupID.SelectedIndex = -1;
                cmb_ProjectID.SelectedIndex = -1;
            }
        }

        private void grd_ProjectViewDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grd_ProjectAssignmentDetails.Columns[e.ColumnIndex].Name == "Delete")
            {
                string value = grd_ProjectAssignmentDetails.Rows[e.RowIndex].Cells["ProjectID"].Value.ToString();
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("DELETE FROM GroupProject WHERE ProjectID = @ProjectID", con);
                cmd.Parameters.AddWithValue("@ProjectID", value);
                cmd.ExecuteNonQuery();


                MessageBox.Show("Successfully Deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grd_ProjectAssignmentDetails.DataSource = null;
            }
        }

        private void cmb_ProjectID_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select Id From Project", con);
            SqlDataReader reader = cmd.ExecuteReader();
            // Create list to store retrieved data
            List<object> dataList = new List<object>();
            // Loop through reader and add retrieved data to list
            while (reader.Read())
            {
                // Retrieve data from reader
                object data = reader["Id"]; // ider apnay column ka name likha bs
                // Add data to list
                dataList.Add(data);
            }
            // Close reader and connection
            reader.Close();

            cmb_ProjectID.DataSource = dataList;
        }

        private void cmb_GroupID_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select Id From [Group]", con);
            SqlDataReader reader = cmd.ExecuteReader();
            // Create list to store retrieved data
            List<object> dataList = new List<object>();
            // Loop through reader and add retrieved data to list
            while (reader.Read())
            {
                // Retrieve data from reader
                object data = reader["Id"]; // ider apnay column ka name likha bs
                // Add data to list
                dataList.Add(data);
            }
            // Close reader and connection
            reader.Close();

            cmb_GroupID.DataSource = dataList;
        }
    }
}
