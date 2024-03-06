
namespace DBMIDProject_2022_CS_153
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_AttendanceID = new System.Windows.Forms.Label();
            this.txt_AttendanceID = new System.Windows.Forms.TextBox();
            this.txt_AttendanceCourse = new System.Windows.Forms.TextBox();
            this.txt_Attendancetime = new System.Windows.Forms.TextBox();
            this.txt_AttendanceStatus = new System.Windows.Forms.TextBox();
            this.lbl_AttendanceCourse = new System.Windows.Forms.Label();
            this.lbl_AttendanceStatus = new System.Windows.Forms.Label();
            this.tbl_record = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Attendancetime = new System.Windows.Forms.Label();
            this.tbl_studentRecord = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_StudentAttandanceRecord = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_grd = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_frm1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_ViewAttandanceRecord = new System.Windows.Forms.Label();
            this.tbl_Crudd = new System.Windows.Forms.TableLayoutPanel();
            this.btn_AttandanceRetrieve = new System.Windows.Forms.Button();
            this.btn_AttandanceCreate = new System.Windows.Forms.Button();
            this.tbl_CRUD = new System.Windows.Forms.TableLayoutPanel();
            this.btn_AttandanceDelete = new System.Windows.Forms.Button();
            this.btn_AttandanceUpdate = new System.Windows.Forms.Button();
            this.tbl_record.SuspendLayout();
            this.tbl_studentRecord.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tbl_grd.SuspendLayout();
            this.tbl_frm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tbl_Crudd.SuspendLayout();
            this.tbl_CRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_AttendanceID
            // 
            this.lbl_AttendanceID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_AttendanceID.AutoSize = true;
            this.lbl_AttendanceID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_AttendanceID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AttendanceID.Location = new System.Drawing.Point(92, 42);
            this.lbl_AttendanceID.Name = "lbl_AttendanceID";
            this.lbl_AttendanceID.Size = new System.Drawing.Size(25, 17);
            this.lbl_AttendanceID.TabIndex = 1;
            this.lbl_AttendanceID.Text = "ID";
            // 
            // txt_AttendanceID
            // 
            this.txt_AttendanceID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_AttendanceID.Location = new System.Drawing.Point(373, 41);
            this.txt_AttendanceID.Name = "txt_AttendanceID";
            this.txt_AttendanceID.Size = new System.Drawing.Size(100, 20);
            this.txt_AttendanceID.TabIndex = 15;
            // 
            // txt_AttendanceCourse
            // 
            this.txt_AttendanceCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_AttendanceCourse.Location = new System.Drawing.Point(373, 148);
            this.txt_AttendanceCourse.Name = "txt_AttendanceCourse";
            this.txt_AttendanceCourse.Size = new System.Drawing.Size(100, 20);
            this.txt_AttendanceCourse.TabIndex = 16;
            // 
            // txt_Attendancetime
            // 
            this.txt_Attendancetime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Attendancetime.Location = new System.Drawing.Point(373, 259);
            this.txt_Attendancetime.Name = "txt_Attendancetime";
            this.txt_Attendancetime.Size = new System.Drawing.Size(100, 20);
            this.txt_Attendancetime.TabIndex = 17;
            // 
            // txt_AttendanceStatus
            // 
            this.txt_AttendanceStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_AttendanceStatus.Location = new System.Drawing.Point(373, 359);
            this.txt_AttendanceStatus.Name = "txt_AttendanceStatus";
            this.txt_AttendanceStatus.Size = new System.Drawing.Size(100, 20);
            this.txt_AttendanceStatus.TabIndex = 18;
            // 
            // lbl_AttendanceCourse
            // 
            this.lbl_AttendanceCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_AttendanceCourse.AutoSize = true;
            this.lbl_AttendanceCourse.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AttendanceCourse.Location = new System.Drawing.Point(55, 149);
            this.lbl_AttendanceCourse.Name = "lbl_AttendanceCourse";
            this.lbl_AttendanceCourse.Size = new System.Drawing.Size(98, 17);
            this.lbl_AttendanceCourse.TabIndex = 21;
            this.lbl_AttendanceCourse.Text = "Course Name";
            // 
            // lbl_AttendanceStatus
            // 
            this.lbl_AttendanceStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_AttendanceStatus.AutoSize = true;
            this.lbl_AttendanceStatus.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AttendanceStatus.Location = new System.Drawing.Point(80, 360);
            this.lbl_AttendanceStatus.Name = "lbl_AttendanceStatus";
            this.lbl_AttendanceStatus.Size = new System.Drawing.Size(48, 17);
            this.lbl_AttendanceStatus.TabIndex = 23;
            this.lbl_AttendanceStatus.Text = "Status";
            // 
            // tbl_record
            // 
            this.tbl_record.ColumnCount = 2;
            this.tbl_record.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tbl_record.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 428F));
            this.tbl_record.Controls.Add(this.lbl_AttendanceID, 0, 0);
            this.tbl_record.Controls.Add(this.txt_AttendanceID, 1, 0);
            this.tbl_record.Controls.Add(this.txt_AttendanceCourse, 1, 1);
            this.tbl_record.Controls.Add(this.txt_Attendancetime, 1, 2);
            this.tbl_record.Controls.Add(this.txt_AttendanceStatus, 1, 3);
            this.tbl_record.Controls.Add(this.lbl_AttendanceCourse, 0, 1);
            this.tbl_record.Controls.Add(this.lbl_Attendancetime, 0, 2);
            this.tbl_record.Controls.Add(this.lbl_AttendanceStatus, 0, 3);
            this.tbl_record.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_record.Location = new System.Drawing.Point(3, 88);
            this.tbl_record.Name = "tbl_record";
            this.tbl_record.RowCount = 4;
            this.tbl_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tbl_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tbl_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tbl_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tbl_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_record.Size = new System.Drawing.Size(637, 413);
            this.tbl_record.TabIndex = 0;
            // 
            // lbl_Attendancetime
            // 
            this.lbl_Attendancetime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Attendancetime.AutoSize = true;
            this.lbl_Attendancetime.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Attendancetime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Attendancetime.Location = new System.Drawing.Point(83, 261);
            this.lbl_Attendancetime.Name = "lbl_Attendancetime";
            this.lbl_Attendancetime.Size = new System.Drawing.Size(42, 17);
            this.lbl_Attendancetime.TabIndex = 22;
            this.lbl_Attendancetime.Text = "Time";
            this.lbl_Attendancetime.UseMnemonic = false;
            // 
            // tbl_studentRecord
            // 
            this.tbl_studentRecord.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_studentRecord.ColumnCount = 1;
            this.tbl_studentRecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.7449F));
            this.tbl_studentRecord.Controls.Add(this.lbl_StudentAttandanceRecord, 0, 0);
            this.tbl_studentRecord.Controls.Add(this.tbl_record, 0, 1);
            this.tbl_studentRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_studentRecord.Location = new System.Drawing.Point(3, 3);
            this.tbl_studentRecord.Name = "tbl_studentRecord";
            this.tbl_studentRecord.RowCount = 2;
            this.tbl_studentRecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.93548F));
            this.tbl_studentRecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.06451F));
            this.tbl_studentRecord.Size = new System.Drawing.Size(643, 504);
            this.tbl_studentRecord.TabIndex = 2;
            // 
            // lbl_StudentAttandanceRecord
            // 
            this.lbl_StudentAttandanceRecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_StudentAttandanceRecord.AutoSize = true;
            this.lbl_StudentAttandanceRecord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_StudentAttandanceRecord.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StudentAttandanceRecord.Location = new System.Drawing.Point(192, 29);
            this.lbl_StudentAttandanceRecord.Name = "lbl_StudentAttandanceRecord";
            this.lbl_StudentAttandanceRecord.Size = new System.Drawing.Size(258, 26);
            this.lbl_StudentAttandanceRecord.TabIndex = 16;
            this.lbl_StudentAttandanceRecord.Text = "Student Attendance Record";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.4542F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.5458F));
            this.tableLayoutPanel1.Controls.Add(this.tbl_grd, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbl_Crudd, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbl_CRUD, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbl_studentRecord, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, -7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.52036F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.47964F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1193, 597);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tbl_grd
            // 
            this.tbl_grd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_grd.ColumnCount = 1;
            this.tbl_grd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.7449F));
            this.tbl_grd.Controls.Add(this.tbl_frm1, 0, 1);
            this.tbl_grd.Controls.Add(this.lbl_ViewAttandanceRecord, 0, 0);
            this.tbl_grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_grd.Location = new System.Drawing.Point(652, 3);
            this.tbl_grd.Name = "tbl_grd";
            this.tbl_grd.RowCount = 2;
            this.tbl_grd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.93548F));
            this.tbl_grd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.06451F));
            this.tbl_grd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_grd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_grd.Size = new System.Drawing.Size(538, 504);
            this.tbl_grd.TabIndex = 3;
            // 
            // tbl_frm1
            // 
            this.tbl_frm1.ColumnCount = 1;
            this.tbl_frm1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.11399F));
            this.tbl_frm1.Controls.Add(this.dataGridView1, 0, 0);
            this.tbl_frm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_frm1.Location = new System.Drawing.Point(3, 88);
            this.tbl_frm1.Name = "tbl_frm1";
            this.tbl_frm1.RowCount = 1;
            this.tbl_frm1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.46205F));
            this.tbl_frm1.Size = new System.Drawing.Size(532, 413);
            this.tbl_frm1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(84, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(363, 400);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbl_ViewAttandanceRecord
            // 
            this.lbl_ViewAttandanceRecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ViewAttandanceRecord.AutoSize = true;
            this.lbl_ViewAttandanceRecord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_ViewAttandanceRecord.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ViewAttandanceRecord.Location = new System.Drawing.Point(152, 29);
            this.lbl_ViewAttandanceRecord.Name = "lbl_ViewAttandanceRecord";
            this.lbl_ViewAttandanceRecord.Size = new System.Drawing.Size(233, 26);
            this.lbl_ViewAttandanceRecord.TabIndex = 15;
            this.lbl_ViewAttandanceRecord.Text = "View Attendance Record";
            // 
            // tbl_Crudd
            // 
            this.tbl_Crudd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbl_Crudd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_Crudd.ColumnCount = 2;
            this.tbl_Crudd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Crudd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Crudd.Controls.Add(this.btn_AttandanceRetrieve, 1, 0);
            this.tbl_Crudd.Controls.Add(this.btn_AttandanceCreate, 0, 0);
            this.tbl_Crudd.Location = new System.Drawing.Point(5, 517);
            this.tbl_Crudd.Name = "tbl_Crudd";
            this.tbl_Crudd.RowCount = 1;
            this.tbl_Crudd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Crudd.Size = new System.Drawing.Size(638, 72);
            this.tbl_Crudd.TabIndex = 0;
            // 
            // btn_AttandanceRetrieve
            // 
            this.btn_AttandanceRetrieve.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AttandanceRetrieve.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_AttandanceRetrieve.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_AttandanceRetrieve.Location = new System.Drawing.Point(441, 24);
            this.btn_AttandanceRetrieve.Name = "btn_AttandanceRetrieve";
            this.btn_AttandanceRetrieve.Size = new System.Drawing.Size(75, 23);
            this.btn_AttandanceRetrieve.TabIndex = 1;
            this.btn_AttandanceRetrieve.Text = "Retrieve";
            this.btn_AttandanceRetrieve.UseVisualStyleBackColor = false;
            this.btn_AttandanceRetrieve.Click += new System.EventHandler(this.btn_AttandanceRetrieve_Click);
            // 
            // btn_AttandanceCreate
            // 
            this.btn_AttandanceCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AttandanceCreate.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_AttandanceCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_AttandanceCreate.Location = new System.Drawing.Point(122, 24);
            this.btn_AttandanceCreate.Name = "btn_AttandanceCreate";
            this.btn_AttandanceCreate.Size = new System.Drawing.Size(75, 23);
            this.btn_AttandanceCreate.TabIndex = 0;
            this.btn_AttandanceCreate.Text = "Create";
            this.btn_AttandanceCreate.UseVisualStyleBackColor = false;
            this.btn_AttandanceCreate.Click += new System.EventHandler(this.btn_AttandanceCreate_Click);
            // 
            // tbl_CRUD
            // 
            this.tbl_CRUD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_CRUD.ColumnCount = 2;
            this.tbl_CRUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_CRUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_CRUD.Controls.Add(this.btn_AttandanceDelete, 0, 0);
            this.tbl_CRUD.Controls.Add(this.btn_AttandanceUpdate, 0, 0);
            this.tbl_CRUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_CRUD.Location = new System.Drawing.Point(652, 513);
            this.tbl_CRUD.Name = "tbl_CRUD";
            this.tbl_CRUD.RowCount = 1;
            this.tbl_CRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_CRUD.Size = new System.Drawing.Size(538, 81);
            this.tbl_CRUD.TabIndex = 1;
            // 
            // btn_AttandanceDelete
            // 
            this.btn_AttandanceDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AttandanceDelete.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_AttandanceDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_AttandanceDelete.Location = new System.Drawing.Point(366, 29);
            this.btn_AttandanceDelete.Name = "btn_AttandanceDelete";
            this.btn_AttandanceDelete.Size = new System.Drawing.Size(75, 23);
            this.btn_AttandanceDelete.TabIndex = 2;
            this.btn_AttandanceDelete.Text = "Delete";
            this.btn_AttandanceDelete.UseVisualStyleBackColor = false;
            this.btn_AttandanceDelete.Click += new System.EventHandler(this.btn_AttandanceDelete_Click);
            // 
            // btn_AttandanceUpdate
            // 
            this.btn_AttandanceUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AttandanceUpdate.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_AttandanceUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_AttandanceUpdate.Location = new System.Drawing.Point(97, 29);
            this.btn_AttandanceUpdate.Name = "btn_AttandanceUpdate";
            this.btn_AttandanceUpdate.Size = new System.Drawing.Size(75, 23);
            this.btn_AttandanceUpdate.TabIndex = 1;
            this.btn_AttandanceUpdate.Text = "Update";
            this.btn_AttandanceUpdate.UseVisualStyleBackColor = false;
            this.btn_AttandanceUpdate.Click += new System.EventHandler(this.btn_AttandanceUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 583);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tbl_record.ResumeLayout(false);
            this.tbl_record.PerformLayout();
            this.tbl_studentRecord.ResumeLayout(false);
            this.tbl_studentRecord.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tbl_grd.ResumeLayout(false);
            this.tbl_grd.PerformLayout();
            this.tbl_frm1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tbl_Crudd.ResumeLayout(false);
            this.tbl_CRUD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_AttendanceID;
        private System.Windows.Forms.TextBox txt_AttendanceID;
        private System.Windows.Forms.TextBox txt_AttendanceCourse;
        private System.Windows.Forms.TextBox txt_Attendancetime;
        private System.Windows.Forms.TextBox txt_AttendanceStatus;
        private System.Windows.Forms.Label lbl_AttendanceCourse;
        private System.Windows.Forms.Label lbl_AttendanceStatus;
        private System.Windows.Forms.TableLayoutPanel tbl_record;
        private System.Windows.Forms.Label lbl_Attendancetime;
        private System.Windows.Forms.TableLayoutPanel tbl_studentRecord;
        private System.Windows.Forms.Label lbl_StudentAttandanceRecord;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tbl_grd;
        private System.Windows.Forms.TableLayoutPanel tbl_frm1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_ViewAttandanceRecord;
        private System.Windows.Forms.TableLayoutPanel tbl_Crudd;
        private System.Windows.Forms.Button btn_AttandanceRetrieve;
        private System.Windows.Forms.Button btn_AttandanceCreate;
        private System.Windows.Forms.TableLayoutPanel tbl_CRUD;
        private System.Windows.Forms.Button btn_AttandanceDelete;
        private System.Windows.Forms.Button btn_AttandanceUpdate;
    }
}