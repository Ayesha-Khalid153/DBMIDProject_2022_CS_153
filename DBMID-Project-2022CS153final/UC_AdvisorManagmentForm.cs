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
    public partial class UC_AdvisorManagmentForm : UserControl
    {
        public UC_AdvisorManagmentForm()
        {
            InitializeComponent();
        }

        private void btn_advCreate_Click(object sender, EventArgs e)
        {
            int errorHandler;

            int personId = Controler.IdGetterLast("Person");
            var con = Configuration.getInstance().getConnection();

            SqlCommand checker = new SqlCommand("Select id from Lookup where Value = @value", con);
            checker.Parameters.AddWithValue("@value", cmb_Designation.Text);

            int selectedId = 6;
            SqlDataReader reader = checker.ExecuteReader();

            if (reader.Read())
            {
                selectedId = reader.GetInt32(0);
            }

            else
            {
                selectedId = -1;
            }

            SqlCommand person = new SqlCommand("Insert into Person values (@FirstName,@LastName,@Contact,@Email,@DateOfBirth,@Gender)", con);
            person.Parameters.AddWithValue("@FirstName", txtFrstName.Text);
            person.Parameters.AddWithValue("@LastName", txtlastName.Text);
            person.Parameters.AddWithValue("@Contact",txt_Contact.Text);
            person.Parameters.AddWithValue("@Email", txt_Email.Text);
            person.Parameters.AddWithValue("@DateOfBirth", DateTime.Parse(gDateTimePickeDOB.Text));
            person.Parameters.AddWithValue("@Gender", int.Parse(cmb_sadvGender.Text));
            person.ExecuteNonQuery();

            SqlCommand adv = new SqlCommand("Insert into Advisor values (@Id,@Designation,Salary)", con);
            adv.Parameters.AddWithValue("@Id", personId + 1);
            adv.Parameters.AddWithValue("@Designation", selectedId);
            adv.Parameters.AddWithValue("@Salary", int.Parse(txt_advSalary.Text));
            adv.ExecuteNonQuery();
            MessageBox.Show("Work is Done");
        }

        private void btn_advRetrieve_Click(object sender, EventArgs e)
        {
            grd_advViewRecord.ReadOnly = true;
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select FirstName , LastName , Contact , Email , DateOfBirth , Value as Gender , Value as Designation , Salary from Person , Advisor , Lookup where Person.ID = Advisor.ID and person.Gender = Lookup.ID", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grd_advViewRecord.DataSource = dt;
        }

        private void btn_advUpdate_Click(object sender, EventArgs e)
        {
            if (grd_advViewRecord.SelectedCells.Count > 0)
            {
                int selectedRowIndex = grd_advViewRecord.SelectedCells[0].RowIndex;
                string salary = grd_advViewRecord.Rows[selectedRowIndex].Cells["Salary"].Value.ToString();
                string firstName = grd_advViewRecord.Rows[selectedRowIndex].Cells["FirstName"].Value.ToString();

                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("DELETE FROM Advisor WHERE Salary = @Salary", con);
                cmd.Parameters.AddWithValue("@Salary", salary);
                cmd.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("DELETE FROM Person WHERE FirstName = @FirstName", con);
                cmd2.Parameters.AddWithValue("@FirstName", firstName);
                cmd2.ExecuteNonQuery();

                MessageBox.Show("Successfully Deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                grd_advViewRecord.DataSource = GetAdvisorData();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private DataTable GetAdvisorData()
        {
            // Connection string - replace with your actual connection string
            string connectionString = "2022CS153FYP_Project";

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
    }
}
