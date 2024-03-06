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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_AttandanceCreate_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into Attendance values (@ID, @CourseName, @Time, @Status)", con);
            cmd.Parameters.AddWithValue("@ID", txt_AttendanceID.Text);
            cmd.Parameters.AddWithValue("@CourseName", txt_AttendanceCourse.Text);
            cmd.Parameters.AddWithValue("@Time", txt_Attendancetime.Text);
            bool t = false;
            if (txt_AttendanceStatus.Text != "0")
                t = true;
            cmd.Parameters.AddWithValue("@Status", t);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully saved");
        }

        private void btn_AttandanceRetrieve_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Update Attendance SET ID = @ID, CourseName = @CourseName, Time  = @Time, Status = @Status Where ID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", txt_AttendanceID.Text);
            cmd.Parameters.AddWithValue("@CourseName", txt_AttendanceCourse.Text);
            cmd.Parameters.AddWithValue("@Time", txt_Attendancetime.Text);
            bool t = false;
            if (txt_AttendanceStatus.Text != "0")
                t = true;
            cmd.Parameters.AddWithValue("@Status", t);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Updated");
        }

        private void btn_AttandanceUpdate_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Update Attendance SET ID = @ID, CourseName = @CourseName, Time  = @Time, Status = @Status Where ID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", txt_AttendanceID.Text);
            cmd.Parameters.AddWithValue("@CourseName", txt_AttendanceCourse.Text);
            cmd.Parameters.AddWithValue("@Time", txt_Attendancetime.Text);
            bool t = false;
            if (txt_AttendanceStatus.Text != "0")
                t = true;
            cmd.Parameters.AddWithValue("@Status", t);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Updated");
        }

        private void btn_AttandanceDelete_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM Attendance Where ID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", txt_AttendanceID.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Delete");
        }
    }
}
