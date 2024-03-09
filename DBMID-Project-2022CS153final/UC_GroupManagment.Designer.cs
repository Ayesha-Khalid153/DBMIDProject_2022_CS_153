
namespace DBMID_Project_2022CS153final
{
    partial class UC_GroupManagment
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
            this.btn_GroupCreate = new System.Windows.Forms.Button();
            this.tbl_Crudd = new System.Windows.Forms.TableLayoutPanel();
            this.btn_GroupRetrieve = new System.Windows.Forms.Button();
            this.lbl_GroupCreationdate = new System.Windows.Forms.Label();
            this.lbl_GroupStatus = new System.Windows.Forms.Label();
            this.lbl_Groupstudentid = new System.Windows.Forms.Label();
            this.lbl_GroupgroupID = new System.Windows.Forms.Label();
            this.lbl_ViewProjectdetails = new System.Windows.Forms.Label();
            this.tbl_Group1 = new System.Windows.Forms.TableLayoutPanel();
            this.grd_ProjectViewDetails = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tbl_grd = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_Groupmain = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_CRUD = new System.Windows.Forms.TableLayoutPanel();
            this.btn_GroupUpdate = new System.Windows.Forms.Button();
            this.tbl_GroupstudentRecord = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_ProjectControl = new System.Windows.Forms.Label();
            this.tbl_Grouprecord = new System.Windows.Forms.TableLayoutPanel();
            this.cmb_GroupID = new System.Windows.Forms.ComboBox();
            this.cmb_GroupStatus = new System.Windows.Forms.ComboBox();
            this.cmb_StudentID = new System.Windows.Forms.ComboBox();
            this.lbl_Projectassignmentdate = new System.Windows.Forms.Label();
            this.CreationDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.AssignmentDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.tbl_Crudd.SuspendLayout();
            this.tbl_Group1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ProjectViewDetails)).BeginInit();
            this.tbl_grd.SuspendLayout();
            this.tbl_Groupmain.SuspendLayout();
            this.tbl_CRUD.SuspendLayout();
            this.tbl_GroupstudentRecord.SuspendLayout();
            this.tbl_Grouprecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_GroupCreate
            // 
            this.btn_GroupCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_GroupCreate.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_GroupCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_GroupCreate.Location = new System.Drawing.Point(60, 17);
            this.btn_GroupCreate.Name = "btn_GroupCreate";
            this.btn_GroupCreate.Size = new System.Drawing.Size(75, 23);
            this.btn_GroupCreate.TabIndex = 0;
            this.btn_GroupCreate.Text = "Create";
            this.btn_GroupCreate.UseVisualStyleBackColor = false;
            this.btn_GroupCreate.Click += new System.EventHandler(this.btn_GroupCreate_Click);
            // 
            // tbl_Crudd
            // 
            this.tbl_Crudd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbl_Crudd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_Crudd.ColumnCount = 2;
            this.tbl_Crudd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Crudd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Crudd.Controls.Add(this.btn_GroupRetrieve, 1, 0);
            this.tbl_Crudd.Controls.Add(this.btn_GroupCreate, 0, 0);
            this.tbl_Crudd.Location = new System.Drawing.Point(15, 451);
            this.tbl_Crudd.Name = "tbl_Crudd";
            this.tbl_Crudd.RowCount = 1;
            this.tbl_Crudd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Crudd.Size = new System.Drawing.Size(392, 58);
            this.tbl_Crudd.TabIndex = 0;
            // 
            // btn_GroupRetrieve
            // 
            this.btn_GroupRetrieve.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_GroupRetrieve.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_GroupRetrieve.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_GroupRetrieve.Location = new System.Drawing.Point(256, 17);
            this.btn_GroupRetrieve.Name = "btn_GroupRetrieve";
            this.btn_GroupRetrieve.Size = new System.Drawing.Size(75, 23);
            this.btn_GroupRetrieve.TabIndex = 1;
            this.btn_GroupRetrieve.Text = "Retrieve";
            this.btn_GroupRetrieve.UseVisualStyleBackColor = false;
            this.btn_GroupRetrieve.Click += new System.EventHandler(this.btn_GroupRetrieve_Click);
            // 
            // lbl_GroupCreationdate
            // 
            this.lbl_GroupCreationdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_GroupCreationdate.AutoSize = true;
            this.lbl_GroupCreationdate.Location = new System.Drawing.Point(68, 242);
            this.lbl_GroupCreationdate.Name = "lbl_GroupCreationdate";
            this.lbl_GroupCreationdate.Size = new System.Drawing.Size(72, 13);
            this.lbl_GroupCreationdate.TabIndex = 21;
            this.lbl_GroupCreationdate.Text = "Creation Date";
            // 
            // lbl_GroupStatus
            // 
            this.lbl_GroupStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_GroupStatus.AutoSize = true;
            this.lbl_GroupStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_GroupStatus.Location = new System.Drawing.Point(86, 171);
            this.lbl_GroupStatus.Name = "lbl_GroupStatus";
            this.lbl_GroupStatus.Size = new System.Drawing.Size(37, 13);
            this.lbl_GroupStatus.TabIndex = 22;
            this.lbl_GroupStatus.Text = "Status";
            this.lbl_GroupStatus.UseMnemonic = false;
            // 
            // lbl_Groupstudentid
            // 
            this.lbl_Groupstudentid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Groupstudentid.AutoSize = true;
            this.lbl_Groupstudentid.Location = new System.Drawing.Point(74, 29);
            this.lbl_Groupstudentid.Name = "lbl_Groupstudentid";
            this.lbl_Groupstudentid.Size = new System.Drawing.Size(61, 13);
            this.lbl_Groupstudentid.TabIndex = 23;
            this.lbl_Groupstudentid.Text = "Student ID ";
            // 
            // lbl_GroupgroupID
            // 
            this.lbl_GroupgroupID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_GroupgroupID.AutoSize = true;
            this.lbl_GroupgroupID.Location = new System.Drawing.Point(79, 100);
            this.lbl_GroupgroupID.Name = "lbl_GroupgroupID";
            this.lbl_GroupgroupID.Size = new System.Drawing.Size(50, 13);
            this.lbl_GroupgroupID.TabIndex = 24;
            this.lbl_GroupgroupID.Text = "Group ID";
            // 
            // lbl_ViewProjectdetails
            // 
            this.lbl_ViewProjectdetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ViewProjectdetails.AutoSize = true;
            this.lbl_ViewProjectdetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_ViewProjectdetails.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ViewProjectdetails.Location = new System.Drawing.Point(81, 23);
            this.lbl_ViewProjectdetails.Name = "lbl_ViewProjectdetails";
            this.lbl_ViewProjectdetails.Size = new System.Drawing.Size(184, 26);
            this.lbl_ViewProjectdetails.TabIndex = 15;
            this.lbl_ViewProjectdetails.Text = "View Group Details";
            // 
            // tbl_Group1
            // 
            this.tbl_Group1.ColumnCount = 1;
            this.tbl_Group1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.11399F));
            this.tbl_Group1.Controls.Add(this.grd_ProjectViewDetails, 0, 0);
            this.tbl_Group1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_Group1.Location = new System.Drawing.Point(3, 76);
            this.tbl_Group1.Name = "tbl_Group1";
            this.tbl_Group1.RowCount = 1;
            this.tbl_Group1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.46205F));
            this.tbl_Group1.Size = new System.Drawing.Size(341, 357);
            this.tbl_Group1.TabIndex = 0;
            // 
            // grd_ProjectViewDetails
            // 
            this.grd_ProjectViewDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grd_ProjectViewDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_ProjectViewDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.grd_ProjectViewDetails.Location = new System.Drawing.Point(3, 30);
            this.grd_ProjectViewDetails.Name = "grd_ProjectViewDetails";
            this.grd_ProjectViewDetails.Size = new System.Drawing.Size(335, 297);
            this.grd_ProjectViewDetails.TabIndex = 0;
            this.grd_ProjectViewDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_ProjectViewDetails_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Remove";
            this.Column1.Name = "Column1";
            // 
            // tbl_grd
            // 
            this.tbl_grd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_grd.ColumnCount = 1;
            this.tbl_grd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.7449F));
            this.tbl_grd.Controls.Add(this.tbl_Group1, 0, 1);
            this.tbl_grd.Controls.Add(this.lbl_ViewProjectdetails, 0, 0);
            this.tbl_grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_grd.Location = new System.Drawing.Point(425, 3);
            this.tbl_grd.Name = "tbl_grd";
            this.tbl_grd.RowCount = 2;
            this.tbl_grd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.93548F));
            this.tbl_grd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.06451F));
            this.tbl_grd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_grd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_grd.Size = new System.Drawing.Size(347, 436);
            this.tbl_grd.TabIndex = 3;
            // 
            // tbl_Groupmain
            // 
            this.tbl_Groupmain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbl_Groupmain.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_Groupmain.ColumnCount = 2;
            this.tbl_Groupmain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.4542F));
            this.tbl_Groupmain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.5458F));
            this.tbl_Groupmain.Controls.Add(this.tbl_grd, 1, 0);
            this.tbl_Groupmain.Controls.Add(this.tbl_Crudd, 0, 1);
            this.tbl_Groupmain.Controls.Add(this.tbl_CRUD, 1, 1);
            this.tbl_Groupmain.Controls.Add(this.tbl_GroupstudentRecord, 0, 0);
            this.tbl_Groupmain.Location = new System.Drawing.Point(0, 0);
            this.tbl_Groupmain.Name = "tbl_Groupmain";
            this.tbl_Groupmain.RowCount = 2;
            this.tbl_Groupmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.52036F));
            this.tbl_Groupmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.47964F));
            this.tbl_Groupmain.Size = new System.Drawing.Size(775, 518);
            this.tbl_Groupmain.TabIndex = 4;
            // 
            // tbl_CRUD
            // 
            this.tbl_CRUD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_CRUD.ColumnCount = 2;
            this.tbl_CRUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_CRUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_CRUD.Controls.Add(this.btn_GroupUpdate, 0, 0);
            this.tbl_CRUD.Controls.Add(this.button1, 1, 0);
            this.tbl_CRUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_CRUD.Location = new System.Drawing.Point(425, 445);
            this.tbl_CRUD.Name = "tbl_CRUD";
            this.tbl_CRUD.RowCount = 1;
            this.tbl_CRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_CRUD.Size = new System.Drawing.Size(347, 70);
            this.tbl_CRUD.TabIndex = 1;
            // 
            // btn_GroupUpdate
            // 
            this.btn_GroupUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_GroupUpdate.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_GroupUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_GroupUpdate.Location = new System.Drawing.Point(49, 23);
            this.btn_GroupUpdate.Name = "btn_GroupUpdate";
            this.btn_GroupUpdate.Size = new System.Drawing.Size(75, 23);
            this.btn_GroupUpdate.TabIndex = 1;
            this.btn_GroupUpdate.Text = "Update";
            this.btn_GroupUpdate.UseVisualStyleBackColor = false;
            // 
            // tbl_GroupstudentRecord
            // 
            this.tbl_GroupstudentRecord.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_GroupstudentRecord.ColumnCount = 1;
            this.tbl_GroupstudentRecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.7449F));
            this.tbl_GroupstudentRecord.Controls.Add(this.lbl_ProjectControl, 0, 0);
            this.tbl_GroupstudentRecord.Controls.Add(this.tbl_Grouprecord, 0, 1);
            this.tbl_GroupstudentRecord.Location = new System.Drawing.Point(3, 3);
            this.tbl_GroupstudentRecord.Name = "tbl_GroupstudentRecord";
            this.tbl_GroupstudentRecord.RowCount = 2;
            this.tbl_GroupstudentRecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.93548F));
            this.tbl_GroupstudentRecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.06451F));
            this.tbl_GroupstudentRecord.Size = new System.Drawing.Size(416, 436);
            this.tbl_GroupstudentRecord.TabIndex = 2;
            // 
            // lbl_ProjectControl
            // 
            this.lbl_ProjectControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ProjectControl.AutoSize = true;
            this.lbl_ProjectControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_ProjectControl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProjectControl.Location = new System.Drawing.Point(137, 23);
            this.lbl_ProjectControl.Name = "lbl_ProjectControl";
            this.lbl_ProjectControl.Size = new System.Drawing.Size(142, 26);
            this.lbl_ProjectControl.TabIndex = 16;
            this.lbl_ProjectControl.Text = "Group Control";
            // 
            // tbl_Grouprecord
            // 
            this.tbl_Grouprecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbl_Grouprecord.ColumnCount = 2;
            this.tbl_Grouprecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tbl_Grouprecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tbl_Grouprecord.Controls.Add(this.cmb_GroupID, 1, 1);
            this.tbl_Grouprecord.Controls.Add(this.cmb_GroupStatus, 1, 2);
            this.tbl_Grouprecord.Controls.Add(this.cmb_StudentID, 1, 0);
            this.tbl_Grouprecord.Controls.Add(this.lbl_Groupstudentid, 0, 0);
            this.tbl_Grouprecord.Controls.Add(this.lbl_GroupCreationdate, 0, 3);
            this.tbl_Grouprecord.Controls.Add(this.lbl_GroupStatus, 0, 2);
            this.tbl_Grouprecord.Controls.Add(this.lbl_GroupgroupID, 0, 1);
            this.tbl_Grouprecord.Controls.Add(this.lbl_Projectassignmentdate, 0, 4);
            this.tbl_Grouprecord.Controls.Add(this.CreationDate, 1, 3);
            this.tbl_Grouprecord.Controls.Add(this.AssignmentDate, 1, 4);
            this.tbl_Grouprecord.Location = new System.Drawing.Point(3, 76);
            this.tbl_Grouprecord.Name = "tbl_Grouprecord";
            this.tbl_Grouprecord.RowCount = 5;
            this.tbl_Grouprecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_Grouprecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_Grouprecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_Grouprecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_Grouprecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_Grouprecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_Grouprecord.Size = new System.Drawing.Size(410, 357);
            this.tbl_Grouprecord.TabIndex = 0;
            // 
            // cmb_GroupID
            // 
            this.cmb_GroupID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_GroupID.FormattingEnabled = true;
            this.cmb_GroupID.Location = new System.Drawing.Point(262, 96);
            this.cmb_GroupID.Name = "cmb_GroupID";
            this.cmb_GroupID.Size = new System.Drawing.Size(106, 21);
            this.cmb_GroupID.TabIndex = 32;
            this.cmb_GroupID.Click += new System.EventHandler(this.cmb_GroupID_Click);
            // 
            // cmb_GroupStatus
            // 
            this.cmb_GroupStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_GroupStatus.FormattingEnabled = true;
            this.cmb_GroupStatus.Location = new System.Drawing.Point(262, 167);
            this.cmb_GroupStatus.Name = "cmb_GroupStatus";
            this.cmb_GroupStatus.Size = new System.Drawing.Size(106, 21);
            this.cmb_GroupStatus.TabIndex = 33;
            // 
            // cmb_StudentID
            // 
            this.cmb_StudentID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_StudentID.FormattingEnabled = true;
            this.cmb_StudentID.Location = new System.Drawing.Point(262, 25);
            this.cmb_StudentID.Name = "cmb_StudentID";
            this.cmb_StudentID.Size = new System.Drawing.Size(106, 21);
            this.cmb_StudentID.TabIndex = 35;
            this.cmb_StudentID.Click += new System.EventHandler(this.cmb_StudentID_Click);
            // 
            // lbl_Projectassignmentdate
            // 
            this.lbl_Projectassignmentdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Projectassignmentdate.AutoSize = true;
            this.lbl_Projectassignmentdate.Location = new System.Drawing.Point(62, 314);
            this.lbl_Projectassignmentdate.Name = "lbl_Projectassignmentdate";
            this.lbl_Projectassignmentdate.Size = new System.Drawing.Size(85, 13);
            this.lbl_Projectassignmentdate.TabIndex = 30;
            this.lbl_Projectassignmentdate.Text = "Assignment date";
            // 
            // CreationDate
            // 
            this.CreationDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreationDate.Checked = true;
            this.CreationDate.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.CreationDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CreationDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.CreationDate.Location = new System.Drawing.Point(215, 229);
            this.CreationDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.CreationDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.Size = new System.Drawing.Size(200, 39);
            this.CreationDate.TabIndex = 31;
            this.CreationDate.Value = new System.DateTime(2024, 3, 7, 17, 16, 36, 299);
            // 
            // AssignmentDate
            // 
            this.AssignmentDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AssignmentDate.Checked = true;
            this.AssignmentDate.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.AssignmentDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AssignmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.AssignmentDate.Location = new System.Drawing.Point(215, 301);
            this.AssignmentDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.AssignmentDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.AssignmentDate.Name = "AssignmentDate";
            this.AssignmentDate.Size = new System.Drawing.Size(200, 39);
            this.AssignmentDate.TabIndex = 36;
            this.AssignmentDate.Value = new System.DateTime(2024, 3, 7, 17, 16, 36, 299);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.SystemColors.ControlText;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(191, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add into Group";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UC_GroupManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.tbl_Groupmain);
            this.Name = "UC_GroupManagment";
            this.Size = new System.Drawing.Size(775, 518);
            this.tbl_Crudd.ResumeLayout(false);
            this.tbl_Group1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_ProjectViewDetails)).EndInit();
            this.tbl_grd.ResumeLayout(false);
            this.tbl_grd.PerformLayout();
            this.tbl_Groupmain.ResumeLayout(false);
            this.tbl_CRUD.ResumeLayout(false);
            this.tbl_GroupstudentRecord.ResumeLayout(false);
            this.tbl_GroupstudentRecord.PerformLayout();
            this.tbl_Grouprecord.ResumeLayout(false);
            this.tbl_Grouprecord.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_GroupCreate;
        private System.Windows.Forms.TableLayoutPanel tbl_Crudd;
        private System.Windows.Forms.Button btn_GroupRetrieve;
        private System.Windows.Forms.Label lbl_GroupCreationdate;
        private System.Windows.Forms.Label lbl_GroupStatus;
        private System.Windows.Forms.Label lbl_Groupstudentid;
        private System.Windows.Forms.Label lbl_GroupgroupID;
        private System.Windows.Forms.Label lbl_ViewProjectdetails;
        private System.Windows.Forms.TableLayoutPanel tbl_Group1;
        private System.Windows.Forms.DataGridView grd_ProjectViewDetails;
        private System.Windows.Forms.TableLayoutPanel tbl_grd;
        private System.Windows.Forms.TableLayoutPanel tbl_Groupmain;
        private System.Windows.Forms.TableLayoutPanel tbl_CRUD;
        private System.Windows.Forms.Button btn_GroupUpdate;
        private System.Windows.Forms.TableLayoutPanel tbl_GroupstudentRecord;
        private System.Windows.Forms.Label lbl_ProjectControl;
        private System.Windows.Forms.TableLayoutPanel tbl_Grouprecord;
        private Guna.UI2.WinForms.Guna2DateTimePicker CreationDate;
        private System.Windows.Forms.Label lbl_Projectassignmentdate;
        private System.Windows.Forms.ComboBox cmb_GroupID;
        private System.Windows.Forms.ComboBox cmb_GroupStatus;
        private System.Windows.Forms.ComboBox cmb_StudentID;
        private Guna.UI2.WinForms.Guna2DateTimePicker AssignmentDate;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.Button button1;
    }
}
