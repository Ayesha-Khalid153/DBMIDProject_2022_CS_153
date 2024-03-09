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
    public partial class Project : UserControl
    {
        public Project()
        {
            InitializeComponent();
        }

        private void btn_ProjectCreate_Click(object sender, EventArgs e)
        {
            if (txt_Projectdescription.Text == "" || txt_Projecttitle.Text == "")
            {
                MessageBox.Show("Please fill all the fields.");
            }

            else
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd2 = new SqlCommand("Insert into Project values (@Description , @title)", con);
                cmd2.Parameters.AddWithValue("@Description", txt_Projectdescription.Text);
                cmd2.Parameters.AddWithValue("@title", txt_Projecttitle.Text);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Hide();
            }
        }

        private void btn_ProjectRetrieve_Click(object sender, EventArgs e)
        {
            grd_ProjectViewDetails.ReadOnly = true;
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Description , Title from project", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            grd_ProjectViewDetails.DataSource = dt;
        }

        private void grd_ProjectViewDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grd_ProjectViewDetails.Columns[e.ColumnIndex].Name == "Delete")
            {
                string value = grd_ProjectViewDetails.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("DELETE FROM Project WHERE Description = @Description", con);
                cmd.Parameters.AddWithValue("@Description", value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (grd_ProjectViewDetails.Columns[e.ColumnIndex].Name == "Edit")
            {
                string value1 = grd_ProjectViewDetails.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                string value2 = grd_ProjectViewDetails.Rows[e.RowIndex].Cells["Title"].Value.ToString();
                Project f = new Project();
                f.Show();
            }
        }
    }
}
