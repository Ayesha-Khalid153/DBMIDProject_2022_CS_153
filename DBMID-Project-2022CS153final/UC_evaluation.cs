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
    public partial class UC_evaluation : UserControl
    {
        public static int id;
        public UC_evaluation()
        {
            InitializeComponent();
        }



        private void btn_EvaluationCreate_Click(object sender, EventArgs e)
        {
            if (txt_EvaluationName.Text == "" || txt_EvaluationMarks.Text == "" || txt_EvaluationWeightage.Text == "")
            {
                MessageBox.Show("Please fill all the fields.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd2 = new SqlCommand("Insert into Evaluation values (@Name , @TotalMarks , @TotalWeightage)", con);
                cmd2.Parameters.AddWithValue("@Name", txt_EvaluationName.Text);
                cmd2.Parameters.AddWithValue("@TotalMarks", int.Parse(txt_EvaluationMarks.Text));
                cmd2.Parameters.AddWithValue("@TotalWeightage", int.Parse(txt_EvaluationWeightage.Text));

                cmd2.ExecuteNonQuery();
                MessageBox.Show("Successfully saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }

        private void btn_EvaluationRetrieve_Click(object sender, EventArgs e)
        {
            grd_EvaluationViewDetails.ReadOnly = true;
            var con = Configuration.getInstance().getConnection();
            //con.Open();
            SqlCommand cmd = new SqlCommand("Select Name , TotalMarks , TotalWeightage  from Evaluation ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            grd_EvaluationViewDetails.DataSource = dt;
        }

        private void btn_EvaluationUpdate_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd1 = new SqlCommand("UPDATE Evaluation SET  Name = @Name , TotalMarks = @TotalMarks , TotalWeightage = @TotalWeightage   WHERE id = @id", con);
            cmd1.Parameters.AddWithValue("@Name", txt_EvaluationName.Text);
            cmd1.Parameters.AddWithValue("@TotalMarks", int.Parse(txt_EvaluationMarks.Text));
            cmd1.Parameters.AddWithValue("@TotalWeightage", int.Parse(txt_EvaluationWeightage.Text));
            cmd1.Parameters.AddWithValue("@id", id);


            cmd1.ExecuteNonQuery();

            MessageBox.Show("Edited Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void grd_EvaluationViewDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grd_EvaluationViewDetails.Columns[e.ColumnIndex].Name == "Delete")
            {
                string value = grd_EvaluationViewDetails.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("DELETE FROM Evaluation WHERE Name = @Name", con);
                cmd.Parameters.AddWithValue("@Name", value);
                cmd.ExecuteNonQuery();


                MessageBox.Show("Deleted Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
    }
}
