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
    public partial class UC_GroupEvaluation : UserControl
    {
        public UC_GroupEvaluation()
        {
            InitializeComponent();
        }

        private void btn_groupEvaluationCreate_Click(object sender, EventArgs e)
        {
            if (cmb_GroupID.Text == "" || cmb_EvaluationID.Text == "" || txt_groupevluationMarks.Text == "" || DateTimegroupevaluation.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }

            else
            {
                var con = Configuration.getInstance().getConnection();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("Insert into GroupEvaluation  values (@GroupID, @EvaluationID, @ObtainedMarks , @EvaluationDate)", con);
                cmd.Parameters.AddWithValue("@GroupID", cmb_GroupID.Text);
                cmd.Parameters.AddWithValue("@EvaluationID", cmb_EvaluationID.Text);

                cmd.Parameters.AddWithValue("@ObtainedMarks", txt_groupevluationMarks.Text);
                cmd.Parameters.AddWithValue("@EvaluationDate", DateTimegroupevaluation.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmb_GroupID.SelectedIndex = -1;
                cmb_EvaluationID.SelectedIndex = -1;
            }
        }

        private void btn_groupEvaluationRetrieve_Click(object sender, EventArgs e)
        {
            grd_groupEvaluationViewDetails.ReadOnly = true;
            var con = Configuration.getInstance().getConnection();
            ///con.Open();
            SqlCommand cmd = new SqlCommand("Select * from GroupEvaluation", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            grd_groupEvaluationViewDetails.DataSource = dt;
        }

        private void grd_groupEvaluationViewDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string value = grd_groupEvaluationViewDetails.Rows[e.RowIndex].Cells["EvaluationID"].Value.ToString();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM GroupEvaluation WHERE EvaluationID = @EvaluationID", con);
            cmd.Parameters.AddWithValue("@EvaluationID", value);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            grd_groupEvaluationViewDetails.DataSource = null;
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

        private void cmb_EvaluationID_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select Id From Evaluation", con);
            SqlDataReader reader = cmd.ExecuteReader();
            List<object> dataList = new List<object>();
            while (reader.Read())
            {
                object data = reader["Id"];
                dataList.Add(data);
            }
            reader.Close();

            cmb_EvaluationID.DataSource = dataList;
        }

        private void btn_groupEvaluationUpdate_Click(object sender, EventArgs e)
        {
            //remaining
        }
    }
}
