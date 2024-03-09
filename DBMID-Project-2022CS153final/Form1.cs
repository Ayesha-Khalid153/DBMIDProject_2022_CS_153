using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMID_Project_2022CS153final
{
    public partial class frmInitializer : Form
    {
        public frmInitializer()
        {
            InitializeComponent();
        }

        private void tbldashboardpicture_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblAdvisorManagmentform_Click(object sender, EventArgs e)
        {
            loadforms(new UC_AdvisorManagmentForm());
        }
        private void loadforms(UC_AdvisorManagmentForm frm)
        {
            try
            {
                this.tbldashboardpicture.Controls.Clear();
                UserControl f = frm as UserControl;

                f.Dock = DockStyle.Fill;
                this.tbldashboardpicture.Controls.Add(f);
                this.tbldashboardpicture.Tag = f;
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblGroupManagment_Click(object sender, EventArgs e)
        {
            loadforms(new UC_GroupManagment());
        }
        private void loadforms(UC_GroupManagment frm)
        {
            try
            {
                this.tbldashboardpicture.Controls.Clear();
                UserControl f = frm as UserControl;

                f.Dock = DockStyle.Fill;
                this.tbldashboardpicture.Controls.Add(f);
                this.tbldashboardpicture.Tag = f;
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lblAdvisorAssignment_Click(object sender, EventArgs e)
        {
            loadforms(new UC_AdvisorAssignment());
        }
        private void loadforms(UC_AdvisorAssignment frm)
        {
            try
            {
                this.tbldashboardpicture.Controls.Clear();
                UserControl f = frm as UserControl;

                f.Dock = DockStyle.Fill;
                this.tbldashboardpicture.Controls.Add(f);
                this.tbldashboardpicture.Tag = f;
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void lblevaluation_Click(object sender, EventArgs e)
        {
            loadforms(new UC_evaluation());
        }
        private void loadforms(UC_evaluation frm)
        {
            try
            {
                this.tbldashboardpicture.Controls.Clear();
                UserControl f = frm as UserControl;

                f.Dock = DockStyle.Fill;
                this.tbldashboardpicture.Controls.Add(f);
                this.tbldashboardpicture.Tag = f;
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lblMarksSheet_Click(object sender, EventArgs e)
        {
            loadforms(new UC_GroupEvaluation());
        }
        private void loadforms(UC_GroupEvaluation frm)
        {
            try
            {
                this.tbldashboardpicture.Controls.Clear();
                UserControl f = frm as UserControl;

                f.Dock = DockStyle.Fill;
                this.tbldashboardpicture.Controls.Add(f);
                this.tbldashboardpicture.Tag = f;
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lblReports_Click(object sender, EventArgs e)
        {
            loadforms(new UC_Reports());
        }
        private void loadforms(UC_Reports frm)
        {
            try
            {
                this.tbldashboardpicture.Controls.Clear();
                UserControl f = frm as UserControl;

                f.Dock = DockStyle.Fill;
                this.tbldashboardpicture.Controls.Add(f);
                this.tbldashboardpicture.Tag = f;
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lblStudentManagment_Click(object sender, EventArgs e)
        {
            loadforms(new UC_StudentManagment());
        }
        private void loadforms(UC_StudentManagment frm)
        {
            try
            {
                this.tbldashboardpicture.Controls.Clear();
                UserControl f = frm as UserControl;

                f.Dock = DockStyle.Fill;
                this.tbldashboardpicture.Controls.Add(f);
                this.tbldashboardpicture.Tag = f;
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbldashboardleft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblProjectOperationfrm_Click(object sender, EventArgs e)
        {
            loadforms(new Project());
        }
        private void loadforms(Project frm)
        {
            try
            {
                this.tbldashboardpicture.Controls.Clear();
                UserControl f = frm as UserControl;

                f.Dock = DockStyle.Fill;
                this.tbldashboardpicture.Controls.Add(f);
                this.tbldashboardpicture.Tag = f;
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblQuit_Click(object sender, EventArgs e)
        {

        }
    }
}
