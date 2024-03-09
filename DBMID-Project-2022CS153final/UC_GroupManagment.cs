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
    public partial class UC_GroupManagment : UserControl
    {
        public UC_GroupManagment()
        {
            InitializeComponent();
        }

        private void btn_GroupCreate_Click(object sender, EventArgs e)
        {
            if (cmb_StudentID.Text == "" || cmb_GroupID.Text == "" || cmb_GroupStatus.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (cmb_GroupStatus.Text != "Active" && cmb_GroupStatus.Text != "In Active")
            {
                MessageBox.Show("Selected Status is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd2 = new SqlCommand("Insert into GroupStudent values (@GroupID , @StudentID , @Status , @AssignmentDate)", con);
                cmd2.Parameters.AddWithValue("@GroupID", cmb_GroupID.Text);
                cmd2.Parameters.AddWithValue("@StudentID", cmb_StudentID.Text);

                if (cmb_StudentID.Text == "Active")
                {
                    cmd2.Parameters.AddWithValue("@Status", 3);
                }

                else if (cmb_StudentID.Text == "In Active")
                {
                    cmd2.Parameters.AddWithValue("@Status", 4);
                }

                cmd2.Parameters.AddWithValue("@AssignmentDate", AssignmentDate.Text);

                cmd2.ExecuteNonQuery();


                MessageBox.Show("Saved Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmb_GroupID.SelectedIndex = -1;
                cmb_StudentID.SelectedIndex = -1;
                cmb_GroupStatus.SelectedIndex = -1;
            }
        }

        private void btn_GroupRetrieve_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Created_On from [Group]", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grd_ProjectViewDetails.DataSource = dt;
            grd_ProjectViewDetails.Columns["Created_On"].DefaultCellStyle.ForeColor = Color.Black;
        }

        private void cmb_StudentID_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd2 = new SqlCommand("Select Id From Student", con);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            List<object> dataList2 = new List<object>();
            while (reader2.Read())
            {
                object data2 = reader2["Id"];
                dataList2.Add(data2);
            }
            reader2.Close();

            cmb_StudentID.DataSource = dataList2;
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
            List<object> dataList = new List<object>();

            while (reader.Read())
            {
                object data = reader["Id"];
                dataList.Add(data);
            }
            reader.Close();

            cmb_GroupID.DataSource = dataList;
        }

        private void grd_ProjectViewDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grd_ProjectViewDetails.Columns[e.ColumnIndex].Name == "DELETE")
            {
                string value = grd_ProjectViewDetails.Rows[e.RowIndex].Cells["Created_On"].Value.ToString();
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("DELETE FROM [Group] WHERE Created_On = @Created_On", con);
                cmd.Parameters.AddWithValue("@Created_On", value);
                cmd.ExecuteNonQuery();
                grd_ProjectViewDetails.DataSource = null;
                MessageBox.Show("Successfully Deleted.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_GroupCreationdate.Visible = true;
            CreationDate.Visible = true;
            string value = CreationDate.Text;
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd2 = new SqlCommand("Insert into [Group] values (@Created_On)", con);
            cmd2.Parameters.AddWithValue("@Created_On", value);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Saved Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
