
namespace DBMID_Project_2022CS153final
{
    partial class UC_AdvisorManagmentForm
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
            this.btn_advRetrieve = new System.Windows.Forms.Button();
            this.lbl_AdvGender = new System.Windows.Forms.Label();
            this.txtFrstName = new System.Windows.Forms.TextBox();
            this.txtlastName = new System.Windows.Forms.TextBox();
            this.txt_Contact = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.tbl_Crudd = new System.Windows.Forms.TableLayoutPanel();
            this.btn_advCreate = new System.Windows.Forms.Button();
            this.lbl_ViewAdvisorRecord = new System.Windows.Forms.Label();
            this.grd_advViewRecord = new System.Windows.Forms.DataGridView();
            this.tbl_frm1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_AdvisorFirstName = new System.Windows.Forms.Label();
            this.lbl_AdvisorLastName = new System.Windows.Forms.Label();
            this.lbl_AdvContact = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_grd = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_CRUD = new System.Windows.Forms.TableLayoutPanel();
            this.btn_advDelete = new System.Windows.Forms.Button();
            this.btn_advUpdate = new System.Windows.Forms.Button();
            this.tbl_studentRecord = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_AdvisorRecord = new System.Windows.Forms.Label();
            this.tbl_record = new System.Windows.Forms.TableLayoutPanel();
            this.txt_advSalary = new System.Windows.Forms.TextBox();
            this.lbl_advDesignation = new System.Windows.Forms.Label();
            this.lbl_advEmail = new System.Windows.Forms.Label();
            this.lbl_stdDOB = new System.Windows.Forms.Label();
            this.cmb_sadvGender = new System.Windows.Forms.ComboBox();
            this.gDateTimePickeDOB = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbl_advSalary = new System.Windows.Forms.Label();
            this.cmb_Designation = new System.Windows.Forms.ComboBox();
            this.tbl_Crudd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_advViewRecord)).BeginInit();
            this.tbl_frm1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tbl_grd.SuspendLayout();
            this.tbl_CRUD.SuspendLayout();
            this.tbl_studentRecord.SuspendLayout();
            this.tbl_record.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_advRetrieve
            // 
            this.btn_advRetrieve.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_advRetrieve.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_advRetrieve.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_advRetrieve.Location = new System.Drawing.Point(256, 17);
            this.btn_advRetrieve.Name = "btn_advRetrieve";
            this.btn_advRetrieve.Size = new System.Drawing.Size(75, 23);
            this.btn_advRetrieve.TabIndex = 1;
            this.btn_advRetrieve.Text = "Retrieve";
            this.btn_advRetrieve.UseVisualStyleBackColor = false;
            this.btn_advRetrieve.Click += new System.EventHandler(this.btn_advRetrieve_Click);
            // 
            // lbl_AdvGender
            // 
            this.lbl_AdvGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_AdvGender.AutoSize = true;
            this.lbl_AdvGender.Location = new System.Drawing.Point(83, 196);
            this.lbl_AdvGender.Name = "lbl_AdvGender";
            this.lbl_AdvGender.Size = new System.Drawing.Size(42, 13);
            this.lbl_AdvGender.TabIndex = 25;
            this.lbl_AdvGender.Text = "Gender";
            // 
            // txtFrstName
            // 
            this.txtFrstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFrstName.Location = new System.Drawing.Point(265, 12);
            this.txtFrstName.Name = "txtFrstName";
            this.txtFrstName.Size = new System.Drawing.Size(100, 20);
            this.txtFrstName.TabIndex = 16;
            // 
            // txtlastName
            // 
            this.txtlastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtlastName.Location = new System.Drawing.Point(265, 57);
            this.txtlastName.Name = "txtlastName";
            this.txtlastName.Size = new System.Drawing.Size(100, 20);
            this.txtlastName.TabIndex = 17;
            // 
            // txt_Contact
            // 
            this.txt_Contact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Contact.Location = new System.Drawing.Point(265, 102);
            this.txt_Contact.Name = "txt_Contact";
            this.txt_Contact.Size = new System.Drawing.Size(100, 20);
            this.txt_Contact.TabIndex = 18;
            // 
            // txt_Email
            // 
            this.txt_Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Email.Location = new System.Drawing.Point(265, 147);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(100, 20);
            this.txt_Email.TabIndex = 19;
            // 
            // tbl_Crudd
            // 
            this.tbl_Crudd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbl_Crudd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_Crudd.ColumnCount = 2;
            this.tbl_Crudd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Crudd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Crudd.Controls.Add(this.btn_advRetrieve, 1, 0);
            this.tbl_Crudd.Controls.Add(this.btn_advCreate, 0, 0);
            this.tbl_Crudd.Location = new System.Drawing.Point(15, 456);
            this.tbl_Crudd.Name = "tbl_Crudd";
            this.tbl_Crudd.RowCount = 1;
            this.tbl_Crudd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Crudd.Size = new System.Drawing.Size(392, 58);
            this.tbl_Crudd.TabIndex = 0;
            // 
            // btn_advCreate
            // 
            this.btn_advCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_advCreate.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_advCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_advCreate.Location = new System.Drawing.Point(60, 17);
            this.btn_advCreate.Name = "btn_advCreate";
            this.btn_advCreate.Size = new System.Drawing.Size(75, 23);
            this.btn_advCreate.TabIndex = 0;
            this.btn_advCreate.Text = "Create";
            this.btn_advCreate.UseVisualStyleBackColor = false;
            this.btn_advCreate.Click += new System.EventHandler(this.btn_advCreate_Click);
            // 
            // lbl_ViewAdvisorRecord
            // 
            this.lbl_ViewAdvisorRecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ViewAdvisorRecord.AutoSize = true;
            this.lbl_ViewAdvisorRecord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_ViewAdvisorRecord.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ViewAdvisorRecord.Location = new System.Drawing.Point(71, 24);
            this.lbl_ViewAdvisorRecord.Name = "lbl_ViewAdvisorRecord";
            this.lbl_ViewAdvisorRecord.Size = new System.Drawing.Size(204, 26);
            this.lbl_ViewAdvisorRecord.TabIndex = 15;
            this.lbl_ViewAdvisorRecord.Text = "View  Advisor Record";
            // 
            // grd_advViewRecord
            // 
            this.grd_advViewRecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grd_advViewRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_advViewRecord.Location = new System.Drawing.Point(3, 32);
            this.grd_advViewRecord.Name = "grd_advViewRecord";
            this.grd_advViewRecord.Size = new System.Drawing.Size(335, 297);
            this.grd_advViewRecord.TabIndex = 0;
            // 
            // tbl_frm1
            // 
            this.tbl_frm1.ColumnCount = 1;
            this.tbl_frm1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.11399F));
            this.tbl_frm1.Controls.Add(this.grd_advViewRecord, 0, 0);
            this.tbl_frm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_frm1.Location = new System.Drawing.Point(3, 77);
            this.tbl_frm1.Name = "tbl_frm1";
            this.tbl_frm1.RowCount = 1;
            this.tbl_frm1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.46205F));
            this.tbl_frm1.Size = new System.Drawing.Size(341, 361);
            this.tbl_frm1.TabIndex = 0;
            // 
            // lbl_AdvisorFirstName
            // 
            this.lbl_AdvisorFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_AdvisorFirstName.AutoSize = true;
            this.lbl_AdvisorFirstName.Location = new System.Drawing.Point(76, 16);
            this.lbl_AdvisorFirstName.Name = "lbl_AdvisorFirstName";
            this.lbl_AdvisorFirstName.Size = new System.Drawing.Size(57, 13);
            this.lbl_AdvisorFirstName.TabIndex = 21;
            this.lbl_AdvisorFirstName.Text = "First Name";
            // 
            // lbl_AdvisorLastName
            // 
            this.lbl_AdvisorLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_AdvisorLastName.AutoSize = true;
            this.lbl_AdvisorLastName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_AdvisorLastName.Location = new System.Drawing.Point(75, 61);
            this.lbl_AdvisorLastName.Name = "lbl_AdvisorLastName";
            this.lbl_AdvisorLastName.Size = new System.Drawing.Size(58, 13);
            this.lbl_AdvisorLastName.TabIndex = 22;
            this.lbl_AdvisorLastName.Text = "Last Name";
            this.lbl_AdvisorLastName.UseMnemonic = false;
            // 
            // lbl_AdvContact
            // 
            this.lbl_AdvContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_AdvContact.AutoSize = true;
            this.lbl_AdvContact.Location = new System.Drawing.Point(82, 106);
            this.lbl_AdvContact.Name = "lbl_AdvContact";
            this.lbl_AdvContact.Size = new System.Drawing.Size(44, 13);
            this.lbl_AdvContact.TabIndex = 23;
            this.lbl_AdvContact.Text = "Contact";
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.52036F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.47964F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(775, 523);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tbl_grd
            // 
            this.tbl_grd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_grd.ColumnCount = 1;
            this.tbl_grd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.7449F));
            this.tbl_grd.Controls.Add(this.tbl_frm1, 0, 1);
            this.tbl_grd.Controls.Add(this.lbl_ViewAdvisorRecord, 0, 0);
            this.tbl_grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_grd.Location = new System.Drawing.Point(425, 3);
            this.tbl_grd.Name = "tbl_grd";
            this.tbl_grd.RowCount = 2;
            this.tbl_grd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.93548F));
            this.tbl_grd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.06451F));
            this.tbl_grd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_grd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_grd.Size = new System.Drawing.Size(347, 441);
            this.tbl_grd.TabIndex = 3;
            // 
            // tbl_CRUD
            // 
            this.tbl_CRUD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_CRUD.ColumnCount = 2;
            this.tbl_CRUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_CRUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_CRUD.Controls.Add(this.btn_advDelete, 0, 0);
            this.tbl_CRUD.Controls.Add(this.btn_advUpdate, 0, 0);
            this.tbl_CRUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_CRUD.Location = new System.Drawing.Point(425, 450);
            this.tbl_CRUD.Name = "tbl_CRUD";
            this.tbl_CRUD.RowCount = 1;
            this.tbl_CRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_CRUD.Size = new System.Drawing.Size(347, 70);
            this.tbl_CRUD.TabIndex = 1;
            // 
            // btn_advDelete
            // 
            this.btn_advDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_advDelete.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_advDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_advDelete.Location = new System.Drawing.Point(222, 23);
            this.btn_advDelete.Name = "btn_advDelete";
            this.btn_advDelete.Size = new System.Drawing.Size(75, 23);
            this.btn_advDelete.TabIndex = 2;
            this.btn_advDelete.Text = "Delete";
            this.btn_advDelete.UseVisualStyleBackColor = false;
            // 
            // btn_advUpdate
            // 
            this.btn_advUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_advUpdate.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_advUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_advUpdate.Location = new System.Drawing.Point(49, 23);
            this.btn_advUpdate.Name = "btn_advUpdate";
            this.btn_advUpdate.Size = new System.Drawing.Size(75, 23);
            this.btn_advUpdate.TabIndex = 1;
            this.btn_advUpdate.Text = "Update";
            this.btn_advUpdate.UseVisualStyleBackColor = false;
            this.btn_advUpdate.Click += new System.EventHandler(this.btn_advUpdate_Click);
            // 
            // tbl_studentRecord
            // 
            this.tbl_studentRecord.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_studentRecord.ColumnCount = 1;
            this.tbl_studentRecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.7449F));
            this.tbl_studentRecord.Controls.Add(this.lbl_AdvisorRecord, 0, 0);
            this.tbl_studentRecord.Controls.Add(this.tbl_record, 0, 1);
            this.tbl_studentRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_studentRecord.Location = new System.Drawing.Point(3, 3);
            this.tbl_studentRecord.Name = "tbl_studentRecord";
            this.tbl_studentRecord.RowCount = 2;
            this.tbl_studentRecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.93548F));
            this.tbl_studentRecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.06451F));
            this.tbl_studentRecord.Size = new System.Drawing.Size(416, 441);
            this.tbl_studentRecord.TabIndex = 2;
            // 
            // lbl_AdvisorRecord
            // 
            this.lbl_AdvisorRecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_AdvisorRecord.AutoSize = true;
            this.lbl_AdvisorRecord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_AdvisorRecord.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AdvisorRecord.Location = new System.Drawing.Point(131, 24);
            this.lbl_AdvisorRecord.Name = "lbl_AdvisorRecord";
            this.lbl_AdvisorRecord.Size = new System.Drawing.Size(154, 26);
            this.lbl_AdvisorRecord.TabIndex = 16;
            this.lbl_AdvisorRecord.Text = "Advisor Control";
            // 
            // tbl_record
            // 
            this.tbl_record.ColumnCount = 2;
            this.tbl_record.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tbl_record.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tbl_record.Controls.Add(this.txt_advSalary, 1, 7);
            this.tbl_record.Controls.Add(this.lbl_advDesignation, 0, 6);
            this.tbl_record.Controls.Add(this.lbl_AdvisorFirstName, 0, 0);
            this.tbl_record.Controls.Add(this.txtFrstName, 1, 0);
            this.tbl_record.Controls.Add(this.lbl_AdvisorLastName, 0, 1);
            this.tbl_record.Controls.Add(this.txtlastName, 1, 1);
            this.tbl_record.Controls.Add(this.lbl_AdvContact, 0, 2);
            this.tbl_record.Controls.Add(this.txt_Contact, 1, 2);
            this.tbl_record.Controls.Add(this.lbl_advEmail, 0, 3);
            this.tbl_record.Controls.Add(this.lbl_AdvGender, 0, 4);
            this.tbl_record.Controls.Add(this.lbl_stdDOB, 0, 5);
            this.tbl_record.Controls.Add(this.txt_Email, 1, 3);
            this.tbl_record.Controls.Add(this.cmb_sadvGender, 1, 4);
            this.tbl_record.Controls.Add(this.gDateTimePickeDOB, 1, 5);
            this.tbl_record.Controls.Add(this.lbl_advSalary, 0, 7);
            this.tbl_record.Controls.Add(this.cmb_Designation, 1, 6);
            this.tbl_record.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_record.Location = new System.Drawing.Point(3, 77);
            this.tbl_record.Name = "tbl_record";
            this.tbl_record.RowCount = 8;
            this.tbl_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tbl_record.Size = new System.Drawing.Size(410, 361);
            this.tbl_record.TabIndex = 0;
            // 
            // txt_advSalary
            // 
            this.txt_advSalary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_advSalary.Location = new System.Drawing.Point(265, 328);
            this.txt_advSalary.Name = "txt_advSalary";
            this.txt_advSalary.Size = new System.Drawing.Size(100, 20);
            this.txt_advSalary.TabIndex = 35;
            // 
            // lbl_advDesignation
            // 
            this.lbl_advDesignation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_advDesignation.AutoSize = true;
            this.lbl_advDesignation.Location = new System.Drawing.Point(73, 286);
            this.lbl_advDesignation.Name = "lbl_advDesignation";
            this.lbl_advDesignation.Size = new System.Drawing.Size(63, 13);
            this.lbl_advDesignation.TabIndex = 32;
            this.lbl_advDesignation.Text = "Designation";
            // 
            // lbl_advEmail
            // 
            this.lbl_advEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_advEmail.AutoSize = true;
            this.lbl_advEmail.Location = new System.Drawing.Point(88, 151);
            this.lbl_advEmail.Name = "lbl_advEmail";
            this.lbl_advEmail.Size = new System.Drawing.Size(32, 13);
            this.lbl_advEmail.TabIndex = 24;
            this.lbl_advEmail.Text = "Email";
            // 
            // lbl_stdDOB
            // 
            this.lbl_stdDOB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_stdDOB.AutoSize = true;
            this.lbl_stdDOB.Location = new System.Drawing.Point(71, 241);
            this.lbl_stdDOB.Name = "lbl_stdDOB";
            this.lbl_stdDOB.Size = new System.Drawing.Size(66, 13);
            this.lbl_stdDOB.TabIndex = 30;
            this.lbl_stdDOB.Text = "Date of Birth";
            // 
            // cmb_sadvGender
            // 
            this.cmb_sadvGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_sadvGender.FormattingEnabled = true;
            this.cmb_sadvGender.Location = new System.Drawing.Point(262, 192);
            this.cmb_sadvGender.Name = "cmb_sadvGender";
            this.cmb_sadvGender.Size = new System.Drawing.Size(106, 21);
            this.cmb_sadvGender.TabIndex = 29;
            // 
            // gDateTimePickeDOB
            // 
            this.gDateTimePickeDOB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gDateTimePickeDOB.Checked = true;
            this.gDateTimePickeDOB.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.gDateTimePickeDOB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gDateTimePickeDOB.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.gDateTimePickeDOB.Location = new System.Drawing.Point(215, 228);
            this.gDateTimePickeDOB.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gDateTimePickeDOB.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gDateTimePickeDOB.Name = "gDateTimePickeDOB";
            this.gDateTimePickeDOB.Size = new System.Drawing.Size(200, 39);
            this.gDateTimePickeDOB.TabIndex = 31;
            this.gDateTimePickeDOB.Value = new System.DateTime(2024, 3, 7, 17, 16, 36, 299);
            // 
            // lbl_advSalary
            // 
            this.lbl_advSalary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_advSalary.AutoSize = true;
            this.lbl_advSalary.Location = new System.Drawing.Point(86, 331);
            this.lbl_advSalary.Name = "lbl_advSalary";
            this.lbl_advSalary.Size = new System.Drawing.Size(36, 13);
            this.lbl_advSalary.TabIndex = 33;
            this.lbl_advSalary.Text = "Salary";
            // 
            // cmb_Designation
            // 
            this.cmb_Designation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Designation.FormattingEnabled = true;
            this.cmb_Designation.Location = new System.Drawing.Point(262, 282);
            this.cmb_Designation.Name = "cmb_Designation";
            this.cmb_Designation.Size = new System.Drawing.Size(106, 21);
            this.cmb_Designation.TabIndex = 29;
            // 
            // UC_AdvisorManagmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_AdvisorManagmentForm";
            this.Size = new System.Drawing.Size(775, 523);
            this.tbl_Crudd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_advViewRecord)).EndInit();
            this.tbl_frm1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tbl_grd.ResumeLayout(false);
            this.tbl_grd.PerformLayout();
            this.tbl_CRUD.ResumeLayout(false);
            this.tbl_studentRecord.ResumeLayout(false);
            this.tbl_studentRecord.PerformLayout();
            this.tbl_record.ResumeLayout(false);
            this.tbl_record.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_advRetrieve;
        private System.Windows.Forms.Label lbl_AdvGender;
        private System.Windows.Forms.TextBox txtFrstName;
        private System.Windows.Forms.TextBox txtlastName;
        private System.Windows.Forms.TextBox txt_Contact;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TableLayoutPanel tbl_Crudd;
        private System.Windows.Forms.Button btn_advCreate;
        private System.Windows.Forms.Label lbl_ViewAdvisorRecord;
        private System.Windows.Forms.DataGridView grd_advViewRecord;
        private System.Windows.Forms.TableLayoutPanel tbl_frm1;
        private System.Windows.Forms.Label lbl_AdvisorFirstName;
        private System.Windows.Forms.Label lbl_AdvisorLastName;
        private System.Windows.Forms.Label lbl_AdvContact;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tbl_grd;
        private System.Windows.Forms.TableLayoutPanel tbl_CRUD;
        private System.Windows.Forms.Button btn_advDelete;
        private System.Windows.Forms.Button btn_advUpdate;
        private System.Windows.Forms.TableLayoutPanel tbl_studentRecord;
        private System.Windows.Forms.Label lbl_AdvisorRecord;
        private System.Windows.Forms.TableLayoutPanel tbl_record;
        private System.Windows.Forms.Label lbl_advEmail;
        private System.Windows.Forms.ComboBox cmb_sadvGender;
        private System.Windows.Forms.Label lbl_stdDOB;
        private System.Windows.Forms.TextBox txt_advSalary;
        private System.Windows.Forms.Label lbl_advDesignation;
        private Guna.UI2.WinForms.Guna2DateTimePicker gDateTimePickeDOB;
        private System.Windows.Forms.Label lbl_advSalary;
        private System.Windows.Forms.ComboBox cmb_Designation;
    }
}
