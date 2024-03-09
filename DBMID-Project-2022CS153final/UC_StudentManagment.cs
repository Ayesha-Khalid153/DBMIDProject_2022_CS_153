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
    public partial class UC_StudentManagment : UserControl
    {
        public UC_StudentManagment()
        {
            InitializeComponent();
        }

        private void btn_stdCreate_Click(object sender, EventArgs e)
        {
            int po;
            if (txt_firstName.Text != null && txt_lastname.Text != null && txt_contact.Text != null && int.TryParse(txt_contact.Text, out po) && int.TryParse(cmb_stdGender.Text, out po) && txt_Email.Text != null)
            {
                int personID = Controler.IdGetterLast("Person");
                int countStudentReg = Controler.GetNumberofRecords("Student");
                var con = Configuration.getInstance().getConnection();
                SqlCommand personCmd = new SqlCommand("INSERT INTO Person (FirstName, LastName, Contact, Email, DateOfBirth, Gender)" +
                                                       " VALUES (@firstName, @lastName, @contact, @email, @dateOfBirth, @gender)", con);
                personCmd.Parameters.AddWithValue("@firstName", txt_firstName.Text);
                personCmd.Parameters.AddWithValue("@lastName", txt_lastname.Text);
                personCmd.Parameters.AddWithValue("@contact", txt_contact.Text);
                personCmd.Parameters.AddWithValue("@email", txt_Email.Text);
                personCmd.Parameters.AddWithValue("@dateofbirth", DateTime.Parse(guna2DateTimePicker1.Text));
                personCmd.Parameters.AddWithValue("@gender", cmb_stdGender.Text);
                personCmd.ExecuteNonQuery();
                SqlCommand studentCmd = new SqlCommand("INSERT INTO Student (ID, RegistrationNo)" +
                                                       " VALUES (@ID, @RegistrationNo)", con);
                studentCmd.Parameters.AddWithValue("@ID", personID + 1);
                studentCmd.Parameters.AddWithValue("@RegistrationNo", (countStudentReg + 1) + "-UET");
                studentCmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Added");
            }
            else
            {
                MessageBox.Show("Validations Error");
            }
        }

        private void btn_stdRetrieve_Click(object sender, EventArgs e)
        {
            grd_stdMngmt.ReadOnly = true;
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select RegistrationNo , FirstName , LastName , Contact , Email , DateOfBirth , Value as Gender from Person , Student , Lookup where Person.ID = Student.ID and person.Gender = Lookup.ID", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            grd_stdMngmt.DataSource = dt;
        }

        private void btn_stdDelete_Click(object sender, EventArgs e)
        {
            if (grd_stdMngmt.SelectedCells.Count > 0)
            {
                int selectedRowIndex = grd_stdMngmt.SelectedCells[0].RowIndex;
                string salary = grd_stdMngmt.Rows[selectedRowIndex].Cells["RegistrationNo"].Value.ToString();
                string firstName = grd_stdMngmt.Rows[selectedRowIndex].Cells["FirstName"].Value.ToString();

                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("DELETE FROM Advisor WHERE RegistrationNo = @RegistrationNo", con);
                cmd.Parameters.AddWithValue("@RegistrationNo", salary);
                cmd.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("DELETE FROM Person WHERE FirstName = @FirstName", con);
                cmd2.Parameters.AddWithValue("@FirstName", firstName);
                cmd2.ExecuteNonQuery();

                MessageBox.Show("Successfully Deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                grd_stdMngmt.DataSource = GetStudentData();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private DataTable GetStudentData()
        {
            // Connection string - replace with your actual connection string
            string connectionString = "Your_Connection_String_Here";

            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Query to retrieve data
                string query = "SELECT FirstName, Salary FROM Advisor";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Open the connection
                    connection.Open();

                    // Execute the query and fill the DataTable
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        private void tbl_CRUD_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_stdUpdate_Click(object sender, EventArgs e)
        {
            //remaining
        }

        private void grd_stdMngmt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
