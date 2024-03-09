
namespace DBMID_Project_2022CS153final
{
    partial class UC_GroupEvaluation
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
            this.txt_groupevluationMarks = new System.Windows.Forms.TextBox();
            this.btn_groupEvaluationRetrieve = new System.Windows.Forms.Button();
            this.btn_groupEvaluationCreate = new System.Windows.Forms.Button();
            this.tbl_Crudd = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_groupEvaluationdetails = new System.Windows.Forms.Label();
            this.grd_groupEvaluationViewDetails = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tbl_groupEvaluationBack = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_groupEvaluationgrd = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_groupEvaluationmain = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_groupEvaluationCRUD = new System.Windows.Forms.TableLayoutPanel();
            this.btn_groupEvaluationUpdate = new System.Windows.Forms.Button();
            this.tbl_groupEvaluationstudentRecord = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_GroupEvaluationControl = new System.Windows.Forms.Label();
            this.tbl_groupEvaluationrecord = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_groupEvaluationDate = new System.Windows.Forms.Label();
            this.lbl_groupID = new System.Windows.Forms.Label();
            this.lbl_groupEvaluationWeightage = new System.Windows.Forms.Label();
            this.lbl_groupEvaluationMarks = new System.Windows.Forms.Label();
            this.DateTimegroupevaluation = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmb_GroupID = new System.Windows.Forms.ComboBox();
            this.cmb_EvaluationID = new System.Windows.Forms.ComboBox();
            this.tbl_Crudd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_groupEvaluationViewDetails)).BeginInit();
            this.tbl_groupEvaluationBack.SuspendLayout();
            this.tbl_groupEvaluationgrd.SuspendLayout();
            this.tbl_groupEvaluationmain.SuspendLayout();
            this.tbl_groupEvaluationCRUD.SuspendLayout();
            this.tbl_groupEvaluationstudentRecord.SuspendLayout();
            this.tbl_groupEvaluationrecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_groupevluationMarks
            // 
            this.txt_groupevluationMarks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_groupevluationMarks.Location = new System.Drawing.Point(265, 212);
            this.txt_groupevluationMarks.Name = "txt_groupevluationMarks";
            this.txt_groupevluationMarks.Size = new System.Drawing.Size(100, 20);
            this.txt_groupevluationMarks.TabIndex = 27;
            // 
            // btn_groupEvaluationRetrieve
            // 
            this.btn_groupEvaluationRetrieve.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_groupEvaluationRetrieve.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_groupEvaluationRetrieve.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_groupEvaluationRetrieve.Location = new System.Drawing.Point(256, 17);
            this.btn_groupEvaluationRetrieve.Name = "btn_groupEvaluationRetrieve";
            this.btn_groupEvaluationRetrieve.Size = new System.Drawing.Size(75, 23);
            this.btn_groupEvaluationRetrieve.TabIndex = 1;
            this.btn_groupEvaluationRetrieve.Text = "Retrieve";
            this.btn_groupEvaluationRetrieve.UseVisualStyleBackColor = false;
            this.btn_groupEvaluationRetrieve.Click += new System.EventHandler(this.btn_groupEvaluationRetrieve_Click);
            // 
            // btn_groupEvaluationCreate
            // 
            this.btn_groupEvaluationCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_groupEvaluationCreate.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_groupEvaluationCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_groupEvaluationCreate.Location = new System.Drawing.Point(60, 17);
            this.btn_groupEvaluationCreate.Name = "btn_groupEvaluationCreate";
            this.btn_groupEvaluationCreate.Size = new System.Drawing.Size(75, 23);
            this.btn_groupEvaluationCreate.TabIndex = 0;
            this.btn_groupEvaluationCreate.Text = "Create";
            this.btn_groupEvaluationCreate.UseVisualStyleBackColor = false;
            this.btn_groupEvaluationCreate.Click += new System.EventHandler(this.btn_groupEvaluationCreate_Click);
            // 
            // tbl_Crudd
            // 
            this.tbl_Crudd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbl_Crudd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_Crudd.ColumnCount = 2;
            this.tbl_Crudd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Crudd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Crudd.Controls.Add(this.btn_groupEvaluationRetrieve, 1, 0);
            this.tbl_Crudd.Controls.Add(this.btn_groupEvaluationCreate, 0, 0);
            this.tbl_Crudd.Location = new System.Drawing.Point(15, 451);
            this.tbl_Crudd.Name = "tbl_Crudd";
            this.tbl_Crudd.RowCount = 1;
            this.tbl_Crudd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Crudd.Size = new System.Drawing.Size(392, 58);
            this.tbl_Crudd.TabIndex = 0;
            // 
            // lbl_groupEvaluationdetails
            // 
            this.lbl_groupEvaluationdetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_groupEvaluationdetails.AutoSize = true;
            this.lbl_groupEvaluationdetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_groupEvaluationdetails.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_groupEvaluationdetails.Location = new System.Drawing.Point(61, 23);
            this.lbl_groupEvaluationdetails.Name = "lbl_groupEvaluationdetails";
            this.lbl_groupEvaluationdetails.Size = new System.Drawing.Size(224, 26);
            this.lbl_groupEvaluationdetails.TabIndex = 15;
            this.lbl_groupEvaluationdetails.Text = "View Evaluation Details";
            // 
            // grd_groupEvaluationViewDetails
            // 
            this.grd_groupEvaluationViewDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grd_groupEvaluationViewDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_groupEvaluationViewDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.grd_groupEvaluationViewDetails.Location = new System.Drawing.Point(3, 30);
            this.grd_groupEvaluationViewDetails.Name = "grd_groupEvaluationViewDetails";
            this.grd_groupEvaluationViewDetails.Size = new System.Drawing.Size(335, 297);
            this.grd_groupEvaluationViewDetails.TabIndex = 0;
            this.grd_groupEvaluationViewDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_groupEvaluationViewDetails_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Delete";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tbl_groupEvaluationBack
            // 
            this.tbl_groupEvaluationBack.ColumnCount = 1;
            this.tbl_groupEvaluationBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.11399F));
            this.tbl_groupEvaluationBack.Controls.Add(this.grd_groupEvaluationViewDetails, 0, 0);
            this.tbl_groupEvaluationBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_groupEvaluationBack.Location = new System.Drawing.Point(3, 76);
            this.tbl_groupEvaluationBack.Name = "tbl_groupEvaluationBack";
            this.tbl_groupEvaluationBack.RowCount = 1;
            this.tbl_groupEvaluationBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.46205F));
            this.tbl_groupEvaluationBack.Size = new System.Drawing.Size(341, 357);
            this.tbl_groupEvaluationBack.TabIndex = 0;
            // 
            // tbl_groupEvaluationgrd
            // 
            this.tbl_groupEvaluationgrd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_groupEvaluationgrd.ColumnCount = 1;
            this.tbl_groupEvaluationgrd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.7449F));
            this.tbl_groupEvaluationgrd.Controls.Add(this.tbl_groupEvaluationBack, 0, 1);
            this.tbl_groupEvaluationgrd.Controls.Add(this.lbl_groupEvaluationdetails, 0, 0);
            this.tbl_groupEvaluationgrd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_groupEvaluationgrd.Location = new System.Drawing.Point(425, 3);
            this.tbl_groupEvaluationgrd.Name = "tbl_groupEvaluationgrd";
            this.tbl_groupEvaluationgrd.RowCount = 2;
            this.tbl_groupEvaluationgrd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.93548F));
            this.tbl_groupEvaluationgrd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.06451F));
            this.tbl_groupEvaluationgrd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_groupEvaluationgrd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_groupEvaluationgrd.Size = new System.Drawing.Size(347, 436);
            this.tbl_groupEvaluationgrd.TabIndex = 3;
            // 
            // tbl_groupEvaluationmain
            // 
            this.tbl_groupEvaluationmain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbl_groupEvaluationmain.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_groupEvaluationmain.ColumnCount = 2;
            this.tbl_groupEvaluationmain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.4542F));
            this.tbl_groupEvaluationmain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.5458F));
            this.tbl_groupEvaluationmain.Controls.Add(this.tbl_groupEvaluationgrd, 1, 0);
            this.tbl_groupEvaluationmain.Controls.Add(this.tbl_Crudd, 0, 1);
            this.tbl_groupEvaluationmain.Controls.Add(this.tbl_groupEvaluationCRUD, 1, 1);
            this.tbl_groupEvaluationmain.Controls.Add(this.tbl_groupEvaluationstudentRecord, 0, 0);
            this.tbl_groupEvaluationmain.Location = new System.Drawing.Point(0, -10);
            this.tbl_groupEvaluationmain.Name = "tbl_groupEvaluationmain";
            this.tbl_groupEvaluationmain.RowCount = 2;
            this.tbl_groupEvaluationmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.52036F));
            this.tbl_groupEvaluationmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.47964F));
            this.tbl_groupEvaluationmain.Size = new System.Drawing.Size(775, 518);
            this.tbl_groupEvaluationmain.TabIndex = 6;
            // 
            // tbl_groupEvaluationCRUD
            // 
            this.tbl_groupEvaluationCRUD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_groupEvaluationCRUD.ColumnCount = 2;
            this.tbl_groupEvaluationCRUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_groupEvaluationCRUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_groupEvaluationCRUD.Controls.Add(this.btn_groupEvaluationUpdate, 0, 0);
            this.tbl_groupEvaluationCRUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_groupEvaluationCRUD.Location = new System.Drawing.Point(425, 445);
            this.tbl_groupEvaluationCRUD.Name = "tbl_groupEvaluationCRUD";
            this.tbl_groupEvaluationCRUD.RowCount = 1;
            this.tbl_groupEvaluationCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_groupEvaluationCRUD.Size = new System.Drawing.Size(347, 70);
            this.tbl_groupEvaluationCRUD.TabIndex = 1;
            // 
            // btn_groupEvaluationUpdate
            // 
            this.btn_groupEvaluationUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_groupEvaluationUpdate.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_groupEvaluationUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_groupEvaluationUpdate.Location = new System.Drawing.Point(49, 23);
            this.btn_groupEvaluationUpdate.Name = "btn_groupEvaluationUpdate";
            this.btn_groupEvaluationUpdate.Size = new System.Drawing.Size(75, 23);
            this.btn_groupEvaluationUpdate.TabIndex = 1;
            this.btn_groupEvaluationUpdate.Text = "Update";
            this.btn_groupEvaluationUpdate.UseVisualStyleBackColor = false;
            this.btn_groupEvaluationUpdate.Click += new System.EventHandler(this.btn_groupEvaluationUpdate_Click);
            // 
            // tbl_groupEvaluationstudentRecord
            // 
            this.tbl_groupEvaluationstudentRecord.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_groupEvaluationstudentRecord.ColumnCount = 1;
            this.tbl_groupEvaluationstudentRecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.7449F));
            this.tbl_groupEvaluationstudentRecord.Controls.Add(this.lbl_GroupEvaluationControl, 0, 0);
            this.tbl_groupEvaluationstudentRecord.Controls.Add(this.tbl_groupEvaluationrecord, 0, 1);
            this.tbl_groupEvaluationstudentRecord.Location = new System.Drawing.Point(3, 3);
            this.tbl_groupEvaluationstudentRecord.Name = "tbl_groupEvaluationstudentRecord";
            this.tbl_groupEvaluationstudentRecord.RowCount = 2;
            this.tbl_groupEvaluationstudentRecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.93548F));
            this.tbl_groupEvaluationstudentRecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.06451F));
            this.tbl_groupEvaluationstudentRecord.Size = new System.Drawing.Size(416, 436);
            this.tbl_groupEvaluationstudentRecord.TabIndex = 2;
            // 
            // lbl_GroupEvaluationControl
            // 
            this.lbl_GroupEvaluationControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_GroupEvaluationControl.AutoSize = true;
            this.lbl_GroupEvaluationControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_GroupEvaluationControl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GroupEvaluationControl.Location = new System.Drawing.Point(122, 23);
            this.lbl_GroupEvaluationControl.Name = "lbl_GroupEvaluationControl";
            this.lbl_GroupEvaluationControl.Size = new System.Drawing.Size(171, 26);
            this.lbl_GroupEvaluationControl.TabIndex = 16;
            this.lbl_GroupEvaluationControl.Text = "Group Evaluation";
            // 
            // tbl_groupEvaluationrecord
            // 
            this.tbl_groupEvaluationrecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbl_groupEvaluationrecord.ColumnCount = 2;
            this.tbl_groupEvaluationrecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tbl_groupEvaluationrecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tbl_groupEvaluationrecord.Controls.Add(this.lbl_groupEvaluationDate, 0, 3);
            this.tbl_groupEvaluationrecord.Controls.Add(this.lbl_groupID, 0, 0);
            this.tbl_groupEvaluationrecord.Controls.Add(this.lbl_groupEvaluationWeightage, 0, 2);
            this.tbl_groupEvaluationrecord.Controls.Add(this.lbl_groupEvaluationMarks, 0, 1);
            this.tbl_groupEvaluationrecord.Controls.Add(this.txt_groupevluationMarks, 1, 2);
            this.tbl_groupEvaluationrecord.Controls.Add(this.DateTimegroupevaluation, 1, 3);
            this.tbl_groupEvaluationrecord.Controls.Add(this.cmb_GroupID, 1, 0);
            this.tbl_groupEvaluationrecord.Controls.Add(this.cmb_EvaluationID, 1, 1);
            this.tbl_groupEvaluationrecord.Location = new System.Drawing.Point(3, 76);
            this.tbl_groupEvaluationrecord.Name = "tbl_groupEvaluationrecord";
            this.tbl_groupEvaluationrecord.RowCount = 4;
            this.tbl_groupEvaluationrecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl_groupEvaluationrecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl_groupEvaluationrecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl_groupEvaluationrecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl_groupEvaluationrecord.Size = new System.Drawing.Size(410, 357);
            this.tbl_groupEvaluationrecord.TabIndex = 0;
            // 
            // lbl_groupEvaluationDate
            // 
            this.lbl_groupEvaluationDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_groupEvaluationDate.AutoSize = true;
            this.lbl_groupEvaluationDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_groupEvaluationDate.Location = new System.Drawing.Point(63, 305);
            this.lbl_groupEvaluationDate.Name = "lbl_groupEvaluationDate";
            this.lbl_groupEvaluationDate.Size = new System.Drawing.Size(83, 13);
            this.lbl_groupEvaluationDate.TabIndex = 28;
            this.lbl_groupEvaluationDate.Text = "Evaluation Date";
            this.lbl_groupEvaluationDate.UseMnemonic = false;
            // 
            // lbl_groupID
            // 
            this.lbl_groupID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_groupID.AutoSize = true;
            this.lbl_groupID.Location = new System.Drawing.Point(79, 38);
            this.lbl_groupID.Name = "lbl_groupID";
            this.lbl_groupID.Size = new System.Drawing.Size(50, 13);
            this.lbl_groupID.TabIndex = 23;
            this.lbl_groupID.Text = "Group ID";
            // 
            // lbl_groupEvaluationWeightage
            // 
            this.lbl_groupEvaluationWeightage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_groupEvaluationWeightage.AutoSize = true;
            this.lbl_groupEvaluationWeightage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_groupEvaluationWeightage.Location = new System.Drawing.Point(63, 216);
            this.lbl_groupEvaluationWeightage.Name = "lbl_groupEvaluationWeightage";
            this.lbl_groupEvaluationWeightage.Size = new System.Drawing.Size(82, 13);
            this.lbl_groupEvaluationWeightage.TabIndex = 22;
            this.lbl_groupEvaluationWeightage.Text = "Obtained Marks";
            this.lbl_groupEvaluationWeightage.UseMnemonic = false;
            // 
            // lbl_groupEvaluationMarks
            // 
            this.lbl_groupEvaluationMarks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_groupEvaluationMarks.AutoSize = true;
            this.lbl_groupEvaluationMarks.Location = new System.Drawing.Point(69, 127);
            this.lbl_groupEvaluationMarks.Name = "lbl_groupEvaluationMarks";
            this.lbl_groupEvaluationMarks.Size = new System.Drawing.Size(71, 13);
            this.lbl_groupEvaluationMarks.TabIndex = 24;
            this.lbl_groupEvaluationMarks.Text = "Evaluation ID";
            // 
            // DateTimegroupevaluation
            // 
            this.DateTimegroupevaluation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateTimegroupevaluation.Checked = true;
            this.DateTimegroupevaluation.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.DateTimegroupevaluation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimegroupevaluation.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimegroupevaluation.Location = new System.Drawing.Point(215, 292);
            this.DateTimegroupevaluation.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimegroupevaluation.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimegroupevaluation.Name = "DateTimegroupevaluation";
            this.DateTimegroupevaluation.Size = new System.Drawing.Size(200, 39);
            this.DateTimegroupevaluation.TabIndex = 32;
            this.DateTimegroupevaluation.Value = new System.DateTime(2024, 3, 7, 17, 16, 36, 299);
            // 
            // cmb_GroupID
            // 
            this.cmb_GroupID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_GroupID.FormattingEnabled = true;
            this.cmb_GroupID.Location = new System.Drawing.Point(255, 34);
            this.cmb_GroupID.Name = "cmb_GroupID";
            this.cmb_GroupID.Size = new System.Drawing.Size(121, 21);
            this.cmb_GroupID.TabIndex = 33;
            this.cmb_GroupID.Click += new System.EventHandler(this.cmb_GroupID_Click);
            // 
            // cmb_EvaluationID
            // 
            this.cmb_EvaluationID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_EvaluationID.FormattingEnabled = true;
            this.cmb_EvaluationID.Location = new System.Drawing.Point(255, 123);
            this.cmb_EvaluationID.Name = "cmb_EvaluationID";
            this.cmb_EvaluationID.Size = new System.Drawing.Size(121, 21);
            this.cmb_EvaluationID.TabIndex = 33;
            this.cmb_EvaluationID.Click += new System.EventHandler(this.cmb_EvaluationID_Click);
            // 
            // UC_GroupEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.tbl_groupEvaluationmain);
            this.Name = "UC_GroupEvaluation";
            this.Size = new System.Drawing.Size(775, 498);
            this.tbl_Crudd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_groupEvaluationViewDetails)).EndInit();
            this.tbl_groupEvaluationBack.ResumeLayout(false);
            this.tbl_groupEvaluationgrd.ResumeLayout(false);
            this.tbl_groupEvaluationgrd.PerformLayout();
            this.tbl_groupEvaluationmain.ResumeLayout(false);
            this.tbl_groupEvaluationCRUD.ResumeLayout(false);
            this.tbl_groupEvaluationstudentRecord.ResumeLayout(false);
            this.tbl_groupEvaluationstudentRecord.PerformLayout();
            this.tbl_groupEvaluationrecord.ResumeLayout(false);
            this.tbl_groupEvaluationrecord.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_groupevluationMarks;
        private System.Windows.Forms.Button btn_groupEvaluationRetrieve;
        private System.Windows.Forms.Button btn_groupEvaluationCreate;
        private System.Windows.Forms.TableLayoutPanel tbl_Crudd;
        private System.Windows.Forms.Label lbl_groupEvaluationdetails;
        private System.Windows.Forms.DataGridView grd_groupEvaluationViewDetails;
        private System.Windows.Forms.TableLayoutPanel tbl_groupEvaluationBack;
        private System.Windows.Forms.TableLayoutPanel tbl_groupEvaluationgrd;
        private System.Windows.Forms.TableLayoutPanel tbl_groupEvaluationmain;
        private System.Windows.Forms.TableLayoutPanel tbl_groupEvaluationCRUD;
        private System.Windows.Forms.Button btn_groupEvaluationUpdate;
        private System.Windows.Forms.TableLayoutPanel tbl_groupEvaluationstudentRecord;
        private System.Windows.Forms.Label lbl_GroupEvaluationControl;
        private System.Windows.Forms.TableLayoutPanel tbl_groupEvaluationrecord;
        private System.Windows.Forms.Label lbl_groupEvaluationDate;
        private System.Windows.Forms.Label lbl_groupID;
        private System.Windows.Forms.Label lbl_groupEvaluationWeightage;
        private System.Windows.Forms.Label lbl_groupEvaluationMarks;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimegroupevaluation;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.ComboBox cmb_GroupID;
        private System.Windows.Forms.ComboBox cmb_EvaluationID;
    }
}
