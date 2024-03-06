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

namespace DBMIDProject_2022_CS_153
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into Students values (@ID, @Name, @Department, @Session, @CGPA, @Adress)", con);
            cmd.Parameters.AddWithValue("@ID", txt_ID.Text);
            cmd.Parameters.AddWithValue("@Name", txt_Name.Text);
            cmd.Parameters.AddWithValue("@Department", txt_Department.Text);
            cmd.Parameters.AddWithValue("@Session", txt_Session.Text);
            cmd.Parameters.AddWithValue("@CGPA", float.Parse(txt_CGPA.Text));
            cmd.Parameters.AddWithValue("@Adress", txt_Adress.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully saved");
        }

        private void btn_Retrieve_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Students", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Update Students SET Name = @Name, Department = @Department, Session = @Session,CGPA =  @CGPA, Adress = @Adress Where ID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", txt_ID.Text);
            cmd.Parameters.AddWithValue("@Name", txt_Name.Text);
            cmd.Parameters.AddWithValue("@Department", txt_Department.Text);
            cmd.Parameters.AddWithValue("@Session", txt_Session.Text);
            cmd.Parameters.AddWithValue("@CGPA", float.Parse(txt_CGPA.Text));
            cmd.Parameters.AddWithValue("@Adress", txt_Adress.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Updated");
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM Students Where ID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", txt_ID.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Delete");
        }
    }
}
