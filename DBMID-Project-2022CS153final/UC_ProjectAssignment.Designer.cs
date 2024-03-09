
namespace DBMID_Project_2022CS153final
{
    partial class UC_ProjectAssignment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ProjectCreate = new System.Windows.Forms.Button();
            this.tbl_Crudd = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ProjectRetrieve = new System.Windows.Forms.Button();
            this.lbl_projectid = new System.Windows.Forms.Label();
            this.lbl_ProjectgroupID = new System.Windows.Forms.Label();
            this.DateTimeProjectAssignment = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbl_Projectassignmentdate = new System.Windows.Forms.Label();
            this.cmb_ProjectID = new System.Windows.Forms.ComboBox();
            this.tbl_frm1 = new System.Windows.Forms.TableLayoutPanel();
            this.grd_ProjectAssignmentDetails = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbl_ViewProjectdetails = new System.Windows.Forms.Label();
            this.tbl_grd = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_Projectmain = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_CRUD = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ProjectUpdate = new System.Windows.Forms.Button();
            this.btn_addGroup = new System.Windows.Forms.Button();
            this.tbl_ProjectstudentRecord = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_ProjectControl = new System.Windows.Forms.Label();
            this.tbl_Projectrecord = new System.Windows.Forms.TableLayoutPanel();
            this.cmb_GroupID = new System.Windows.Forms.ComboBox();
            this.tbl_Crudd.SuspendLayout();
            this.tbl_frm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ProjectAssignmentDetails)).BeginInit();
            this.tbl_grd.SuspendLayout();
            this.tbl_Projectmain.SuspendLayout();
            this.tbl_CRUD.SuspendLayout();
            this.tbl_ProjectstudentRecord.SuspendLayout();
            this.tbl_Projectrecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ProjectCreate
            // 
            this.btn_ProjectCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ProjectCreate.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_ProjectCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ProjectCreate.Location = new System.Drawing.Point(60, 17);
            this.btn_ProjectCreate.Name = "btn_ProjectCreate";
            this.btn_ProjectCreate.Size = new System.Drawing.Size(75, 23);
            this.btn_ProjectCreate.TabIndex = 0;
            this.btn_ProjectCreate.Text = "Create";
            this.btn_ProjectCreate.UseVisualStyleBackColor = false;
            this.btn_ProjectCreate.Click += new System.EventHandler(this.btn_ProjectCreate_Click);
            // 
            // tbl_Crudd
            // 
            this.tbl_Crudd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbl_Crudd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_Crudd.ColumnCount = 2;
            this.tbl_Crudd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Crudd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Crudd.Controls.Add(this.btn_ProjectRetrieve, 1, 0);
            this.tbl_Crudd.Controls.Add(this.btn_ProjectCreate, 0, 0);
            this.tbl_Crudd.Location = new System.Drawing.Point(15, 463);
            this.tbl_Crudd.Name = "tbl_Crudd";
            this.tbl_Crudd.RowCount = 1;
            this.tbl_Crudd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Crudd.Size = new System.Drawing.Size(392, 58);
            this.tbl_Crudd.TabIndex = 0;
            // 
            // btn_ProjectRetrieve
            // 
            this.btn_ProjectRetrieve.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ProjectRetrieve.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_ProjectRetrieve.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ProjectRetrieve.Location = new System.Drawing.Point(256, 17);
            this.btn_ProjectRetrieve.Name = "btn_ProjectRetrieve";
            this.btn_ProjectRetrieve.Size = new System.Drawing.Size(75, 23);
            this.btn_ProjectRetrieve.TabIndex = 1;
            this.btn_ProjectRetrieve.Text = "Retrieve";
            this.btn_ProjectRetrieve.UseVisualStyleBackColor = false;
            this.btn_ProjectRetrieve.Click += new System.EventHandler(this.btn_ProjectRetrieve_Click);
            // 
            // lbl_projectid
            // 
            this.lbl_projectid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_projectid.AutoSize = true;
            this.lbl_projectid.Location = new System.Drawing.Point(76, 30);
            this.lbl_projectid.Name = "lbl_projectid";
            this.lbl_projectid.Size = new System.Drawing.Size(57, 13);
            this.lbl_projectid.TabIndex = 23;
            this.lbl_projectid.Text = "Project ID ";
            // 
            // lbl_ProjectgroupID
            // 
            this.lbl_ProjectgroupID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ProjectgroupID.AutoSize = true;
            this.lbl_ProjectgroupID.Location = new System.Drawing.Point(79, 103);
            this.lbl_ProjectgroupID.Name = "lbl_ProjectgroupID";
            this.lbl_ProjectgroupID.Size = new System.Drawing.Size(50, 13);
            this.lbl_ProjectgroupID.TabIndex = 24;
            this.lbl_ProjectgroupID.Text = "Group ID";
            // 
            // DateTimeProjectAssignment
            // 
            this.DateTimeProjectAssignment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateTimeProjectAssignment.Checked = true;
            this.DateTimeProjectAssignment.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.DateTimeProjectAssignment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimeProjectAssignment.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimeProjectAssignment.Location = new System.Drawing.Point(215, 163);
            this.DateTimeProjectAssignment.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimeProjectAssignment.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimeProjectAssignment.Name = "DateTimeProjectAssignment";
            this.DateTimeProjectAssignment.Size = new System.Drawing.Size(200, 39);
            this.DateTimeProjectAssignment.TabIndex = 31;
            this.DateTimeProjectAssignment.Value = new System.DateTime(2024, 3, 7, 17, 16, 36, 299);
            // 
            // lbl_Projectassignmentdate
            // 
            this.lbl_Projectassignmentdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Projectassignmentdate.AutoSize = true;
            this.lbl_Projectassignmentdate.Location = new System.Drawing.Point(62, 176);
            this.lbl_Projectassignmentdate.Name = "lbl_Projectassignmentdate";
            this.lbl_Projectassignmentdate.Size = new System.Drawing.Size(85, 13);
            this.lbl_Projectassignmentdate.TabIndex = 30;
            this.lbl_Projectassignmentdate.Text = "Assignment date";
            // 
            // cmb_ProjectID
            // 
            this.cmb_ProjectID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_ProjectID.FormattingEnabled = true;
            this.cmb_ProjectID.Location = new System.Drawing.Point(255, 26);
            this.cmb_ProjectID.Name = "cmb_ProjectID";
            this.cmb_ProjectID.Size = new System.Drawing.Size(121, 21);
            this.cmb_ProjectID.TabIndex = 34;
            this.cmb_ProjectID.Click += new System.EventHandler(this.cmb_ProjectID_Click);
            // 
            // tbl_frm1
            // 
            this.tbl_frm1.ColumnCount = 1;
            this.tbl_frm1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.11399F));
            this.tbl_frm1.Controls.Add(this.grd_ProjectAssignmentDetails, 0, 0);
            this.tbl_frm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_frm1.Location = new System.Drawing.Point(3, 78);
            this.tbl_frm1.Name = "tbl_frm1";
            this.tbl_frm1.RowCount = 1;
            this.tbl_frm1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.46205F));
            this.tbl_frm1.Size = new System.Drawing.Size(341, 367);
            this.tbl_frm1.TabIndex = 0;
            // 
            // grd_ProjectAssignmentDetails
            // 
            this.grd_ProjectAssignmentDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grd_ProjectAssignmentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_ProjectAssignmentDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.grd_ProjectAssignmentDetails.Location = new System.Drawing.Point(3, 35);
            this.grd_ProjectAssignmentDetails.Name = "grd_ProjectAssignmentDetails";
            this.grd_ProjectAssignmentDetails.Size = new System.Drawing.Size(335, 297);
            this.grd_ProjectAssignmentDetails.TabIndex = 0;
            this.grd_ProjectAssignmentDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_ProjectViewDetails_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Delete";
            this.Column1.Name = "Column1";
            // 
            // lbl_ViewProjectdetails
            // 
            this.lbl_ViewProjectdetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ViewProjectdetails.AutoSize = true;
            this.lbl_ViewProjectdetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_ViewProjectdetails.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ViewProjectdetails.Location = new System.Drawing.Point(23, 24);
            this.lbl_ViewProjectdetails.Name = "lbl_ViewProjectdetails";
            this.lbl_ViewProjectdetails.Size = new System.Drawing.Size(300, 26);
            this.lbl_ViewProjectdetails.TabIndex = 15;
            this.lbl_ViewProjectdetails.Text = "View Project Assignment Details";
            // 
            // tbl_grd
            // 
            this.tbl_grd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_grd.ColumnCount = 1;
            this.tbl_grd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.7449F));
            this.tbl_grd.Controls.Add(this.tbl_frm1, 0, 1);
            this.tbl_grd.Controls.Add(this.lbl_ViewProjectdetails, 0, 0);
            this.tbl_grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_grd.Location = new System.Drawing.Point(425, 3);
            this.tbl_grd.Name = "tbl_grd";
            this.tbl_grd.RowCount = 2;
            this.tbl_grd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.93548F));
            this.tbl_grd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.06451F));
            this.tbl_grd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_grd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_grd.Size = new System.Drawing.Size(347, 448);
            this.tbl_grd.TabIndex = 3;
            // 
            // tbl_Projectmain
            // 
            this.tbl_Projectmain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbl_Projectmain.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_Projectmain.ColumnCount = 2;
            this.tbl_Projectmain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.4542F));
            this.tbl_Projectmain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.5458F));
            this.tbl_Projectmain.Controls.Add(this.tbl_grd, 1, 0);
            this.tbl_Projectmain.Controls.Add(this.tbl_Crudd, 0, 1);
            this.tbl_Projectmain.Controls.Add(this.tbl_CRUD, 1, 1);
            this.tbl_Projectmain.Controls.Add(this.tbl_ProjectstudentRecord, 0, 0);
            this.tbl_Projectmain.Location = new System.Drawing.Point(0, -11);
            this.tbl_Projectmain.Name = "tbl_Projectmain";
            this.tbl_Projectmain.RowCount = 2;
            this.tbl_Projectmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.52036F));
            this.tbl_Projectmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.47964F));
            this.tbl_Projectmain.Size = new System.Drawing.Size(775, 531);
            this.tbl_Projectmain.TabIndex = 4;
            // 
            // tbl_CRUD
            // 
            this.tbl_CRUD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_CRUD.ColumnCount = 2;
            this.tbl_CRUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_CRUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_CRUD.Controls.Add(this.btn_ProjectUpdate, 0, 0);
            this.tbl_CRUD.Controls.Add(this.btn_addGroup, 1, 0);
            this.tbl_CRUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_CRUD.Location = new System.Drawing.Point(425, 457);
            this.tbl_CRUD.Name = "tbl_CRUD";
            this.tbl_CRUD.RowCount = 1;
            this.tbl_CRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_CRUD.Size = new System.Drawing.Size(347, 71);
            this.tbl_CRUD.TabIndex = 1;
            // 
            // btn_ProjectUpdate
            // 
            this.btn_ProjectUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ProjectUpdate.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_ProjectUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ProjectUpdate.Location = new System.Drawing.Point(49, 24);
            this.btn_ProjectUpdate.Name = "btn_ProjectUpdate";
            this.btn_ProjectUpdate.Size = new System.Drawing.Size(75, 23);
            this.btn_ProjectUpdate.TabIndex = 1;
            this.btn_ProjectUpdate.Text = "Update";
            this.btn_ProjectUpdate.UseVisualStyleBackColor = false;
            // 
            // btn_addGroup
            // 
            this.btn_addGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_addGroup.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_addGroup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_addGroup.Location = new System.Drawing.Point(199, 24);
            this.btn_addGroup.Name = "btn_addGroup";
            this.btn_addGroup.Size = new System.Drawing.Size(122, 23);
            this.btn_addGroup.TabIndex = 1;
            this.btn_addGroup.Text = "Add Into Group";
            this.btn_addGroup.UseVisualStyleBackColor = false;
            // 
            // tbl_ProjectstudentRecord
            // 
            this.tbl_ProjectstudentRecord.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_ProjectstudentRecord.ColumnCount = 1;
            this.tbl_ProjectstudentRecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.7449F));
            this.tbl_ProjectstudentRecord.Controls.Add(this.lbl_ProjectControl, 0, 0);
            this.tbl_ProjectstudentRecord.Controls.Add(this.tbl_Projectrecord, 0, 1);
            this.tbl_ProjectstudentRecord.Location = new System.Drawing.Point(3, 3);
            this.tbl_ProjectstudentRecord.Name = "tbl_ProjectstudentRecord";
            this.tbl_ProjectstudentRecord.RowCount = 2;
            this.tbl_ProjectstudentRecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.93548F));
            this.tbl_ProjectstudentRecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.06451F));
            this.tbl_ProjectstudentRecord.Size = new System.Drawing.Size(416, 448);
            this.tbl_ProjectstudentRecord.TabIndex = 2;
            // 
            // lbl_ProjectControl
            // 
            this.lbl_ProjectControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ProjectControl.AutoSize = true;
            this.lbl_ProjectControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_ProjectControl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProjectControl.Location = new System.Drawing.Point(115, 24);
            this.lbl_ProjectControl.Name = "lbl_ProjectControl";
            this.lbl_ProjectControl.Size = new System.Drawing.Size(185, 26);
            this.lbl_ProjectControl.TabIndex = 16;
            this.lbl_ProjectControl.Text = "Project Assignment";
            // 
            // tbl_Projectrecord
            // 
            this.tbl_Projectrecord.ColumnCount = 2;
            this.tbl_Projectrecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tbl_Projectrecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tbl_Projectrecord.Controls.Add(this.lbl_projectid, 0, 0);
            this.tbl_Projectrecord.Controls.Add(this.cmb_ProjectID, 1, 0);
            this.tbl_Projectrecord.Controls.Add(this.cmb_GroupID, 1, 1);
            this.tbl_Projectrecord.Controls.Add(this.lbl_ProjectgroupID, 0, 1);
            this.tbl_Projectrecord.Controls.Add(this.lbl_Projectassignmentdate, 0, 2);
            this.tbl_Projectrecord.Controls.Add(this.DateTimeProjectAssignment, 1, 2);
            this.tbl_Projectrecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_Projectrecord.Location = new System.Drawing.Point(3, 78);
            this.tbl_Projectrecord.Name = "tbl_Projectrecord";
            this.tbl_Projectrecord.RowCount = 5;
            this.tbl_Projectrecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_Projectrecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_Projectrecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_Projectrecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_Projectrecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_Projectrecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_Projectrecord.Size = new System.Drawing.Size(410, 367);
            this.tbl_Projectrecord.TabIndex = 0;
            // 
            // cmb_GroupID
            // 
            this.cmb_GroupID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_GroupID.FormattingEnabled = true;
            this.cmb_GroupID.Location = new System.Drawing.Point(255, 99);
            this.cmb_GroupID.Name = "cmb_GroupID";
            this.cmb_GroupID.Size = new System.Drawing.Size(121, 21);
            this.cmb_GroupID.TabIndex = 34;
            this.cmb_GroupID.Click += new System.EventHandler(this.cmb_GroupID_Click);
            // 
            // UC_ProjectAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbl_Projectmain);
            this.Name = "UC_ProjectAssignment";
            this.Size = new System.Drawing.Size(775, 508);
            this.tbl_Crudd.ResumeLayout(false);
            this.tbl_frm1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_ProjectAssignmentDetails)).EndInit();
            this.tbl_grd.ResumeLayout(false);
            this.tbl_grd.PerformLayout();
            this.tbl_Projectmain.ResumeLayout(false);
            this.tbl_CRUD.ResumeLayout(false);
            this.tbl_ProjectstudentRecord.ResumeLayout(false);
            this.tbl_ProjectstudentRecord.PerformLayout();
            this.tbl_Projectrecord.ResumeLayout(false);
            this.tbl_Projectrecord.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ProjectCreate;
        private System.Windows.Forms.TableLayoutPanel tbl_Crudd;
        private System.Windows.Forms.Button btn_ProjectRetrieve;
        private System.Windows.Forms.Label lbl_projectid;
        private System.Windows.Forms.Label lbl_ProjectgroupID;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimeProjectAssignment;
        private System.Windows.Forms.Label lbl_Projectassignmentdate;
        private System.Windows.Forms.ComboBox cmb_ProjectID;
        private System.Windows.Forms.TableLayoutPanel tbl_frm1;
        private System.Windows.Forms.DataGridView grd_ProjectAssignmentDetails;
        private System.Windows.Forms.Label lbl_ViewProjectdetails;
        private System.Windows.Forms.TableLayoutPanel tbl_grd;
        private System.Windows.Forms.TableLayoutPanel tbl_Projectmain;
        private System.Windows.Forms.TableLayoutPanel tbl_CRUD;
        private System.Windows.Forms.Button btn_ProjectUpdate;
        private System.Windows.Forms.TableLayoutPanel tbl_ProjectstudentRecord;
        private System.Windows.Forms.Label lbl_ProjectControl;
        private System.Windows.Forms.TableLayoutPanel tbl_Projectrecord;
        private System.Windows.Forms.ComboBox cmb_GroupID;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.Button btn_addGroup;
    }
}
