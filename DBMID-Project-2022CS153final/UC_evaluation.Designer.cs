
namespace DBMID_Project_2022CS153final
{
    partial class UC_evaluation
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
            this.lbl_EvaluationControl = new System.Windows.Forms.Label();
            this.tbl_Evaluationrecord = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_EvaluationName = new System.Windows.Forms.Label();
            this.lbl_EvaluationWeightage = new System.Windows.Forms.Label();
            this.lbl_EvaluationMarks = new System.Windows.Forms.Label();
            this.txt_EvaluationName = new System.Windows.Forms.TextBox();
            this.txt_EvaluationMarks = new System.Windows.Forms.TextBox();
            this.txt_EvaluationWeightage = new System.Windows.Forms.TextBox();
            this.tbl_EvaluationstudentRecord = new System.Windows.Forms.TableLayoutPanel();
            this.btn_EvaluationUpdate = new System.Windows.Forms.Button();
            this.tbl_EvaluationCRUD = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_Evaluationmain = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_Evaluationgrd = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_EvaluationBack = new System.Windows.Forms.TableLayoutPanel();
            this.grd_EvaluationViewDetails = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbl_Evaluationdetails = new System.Windows.Forms.Label();
            this.tbl_Crudd = new System.Windows.Forms.TableLayoutPanel();
            this.btn_EvaluationRetrieve = new System.Windows.Forms.Button();
            this.btn_EvaluationCreate = new System.Windows.Forms.Button();
            this.tbl_Evaluationrecord.SuspendLayout();
            this.tbl_EvaluationstudentRecord.SuspendLayout();
            this.tbl_EvaluationCRUD.SuspendLayout();
            this.tbl_Evaluationmain.SuspendLayout();
            this.tbl_Evaluationgrd.SuspendLayout();
            this.tbl_EvaluationBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_EvaluationViewDetails)).BeginInit();
            this.tbl_Crudd.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_EvaluationControl
            // 
            this.lbl_EvaluationControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_EvaluationControl.AutoSize = true;
            this.lbl_EvaluationControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_EvaluationControl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EvaluationControl.Location = new System.Drawing.Point(117, 23);
            this.lbl_EvaluationControl.Name = "lbl_EvaluationControl";
            this.lbl_EvaluationControl.Size = new System.Drawing.Size(182, 26);
            this.lbl_EvaluationControl.TabIndex = 16;
            this.lbl_EvaluationControl.Text = "Evaluation Control";
            // 
            // tbl_Evaluationrecord
            // 
            this.tbl_Evaluationrecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbl_Evaluationrecord.ColumnCount = 2;
            this.tbl_Evaluationrecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tbl_Evaluationrecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tbl_Evaluationrecord.Controls.Add(this.lbl_EvaluationName, 0, 0);
            this.tbl_Evaluationrecord.Controls.Add(this.lbl_EvaluationWeightage, 0, 2);
            this.tbl_Evaluationrecord.Controls.Add(this.lbl_EvaluationMarks, 0, 1);
            this.tbl_Evaluationrecord.Controls.Add(this.txt_EvaluationName, 1, 0);
            this.tbl_Evaluationrecord.Controls.Add(this.txt_EvaluationMarks, 1, 1);
            this.tbl_Evaluationrecord.Controls.Add(this.txt_EvaluationWeightage, 1, 2);
            this.tbl_Evaluationrecord.Location = new System.Drawing.Point(3, 76);
            this.tbl_Evaluationrecord.Name = "tbl_Evaluationrecord";
            this.tbl_Evaluationrecord.RowCount = 3;
            this.tbl_Evaluationrecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_Evaluationrecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_Evaluationrecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_Evaluationrecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_Evaluationrecord.Size = new System.Drawing.Size(410, 357);
            this.tbl_Evaluationrecord.TabIndex = 0;
            // 
            // lbl_EvaluationName
            // 
            this.lbl_EvaluationName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_EvaluationName.AutoSize = true;
            this.lbl_EvaluationName.Location = new System.Drawing.Point(85, 53);
            this.lbl_EvaluationName.Name = "lbl_EvaluationName";
            this.lbl_EvaluationName.Size = new System.Drawing.Size(38, 13);
            this.lbl_EvaluationName.TabIndex = 23;
            this.lbl_EvaluationName.Text = "Name ";
            // 
            // lbl_EvaluationWeightage
            // 
            this.lbl_EvaluationWeightage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_EvaluationWeightage.AutoSize = true;
            this.lbl_EvaluationWeightage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_EvaluationWeightage.Location = new System.Drawing.Point(75, 291);
            this.lbl_EvaluationWeightage.Name = "lbl_EvaluationWeightage";
            this.lbl_EvaluationWeightage.Size = new System.Drawing.Size(59, 13);
            this.lbl_EvaluationWeightage.TabIndex = 22;
            this.lbl_EvaluationWeightage.Text = "Weightage";
            this.lbl_EvaluationWeightage.UseMnemonic = false;
            // 
            // lbl_EvaluationMarks
            // 
            this.lbl_EvaluationMarks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_EvaluationMarks.AutoSize = true;
            this.lbl_EvaluationMarks.Location = new System.Drawing.Point(86, 172);
            this.lbl_EvaluationMarks.Name = "lbl_EvaluationMarks";
            this.lbl_EvaluationMarks.Size = new System.Drawing.Size(36, 13);
            this.lbl_EvaluationMarks.TabIndex = 24;
            this.lbl_EvaluationMarks.Text = "Marks";
            // 
            // txt_EvaluationName
            // 
            this.txt_EvaluationName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_EvaluationName.Location = new System.Drawing.Point(265, 49);
            this.txt_EvaluationName.Name = "txt_EvaluationName";
            this.txt_EvaluationName.Size = new System.Drawing.Size(100, 20);
            this.txt_EvaluationName.TabIndex = 25;
            // 
            // txt_EvaluationMarks
            // 
            this.txt_EvaluationMarks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_EvaluationMarks.Location = new System.Drawing.Point(265, 168);
            this.txt_EvaluationMarks.Name = "txt_EvaluationMarks";
            this.txt_EvaluationMarks.Size = new System.Drawing.Size(100, 20);
            this.txt_EvaluationMarks.TabIndex = 26;
            // 
            // txt_EvaluationWeightage
            // 
            this.txt_EvaluationWeightage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_EvaluationWeightage.Location = new System.Drawing.Point(265, 287);
            this.txt_EvaluationWeightage.Name = "txt_EvaluationWeightage";
            this.txt_EvaluationWeightage.Size = new System.Drawing.Size(100, 20);
            this.txt_EvaluationWeightage.TabIndex = 27;
            // 
            // tbl_EvaluationstudentRecord
            // 
            this.tbl_EvaluationstudentRecord.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_EvaluationstudentRecord.ColumnCount = 1;
            this.tbl_EvaluationstudentRecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.7449F));
            this.tbl_EvaluationstudentRecord.Controls.Add(this.lbl_EvaluationControl, 0, 0);
            this.tbl_EvaluationstudentRecord.Controls.Add(this.tbl_Evaluationrecord, 0, 1);
            this.tbl_EvaluationstudentRecord.Location = new System.Drawing.Point(3, 3);
            this.tbl_EvaluationstudentRecord.Name = "tbl_EvaluationstudentRecord";
            this.tbl_EvaluationstudentRecord.RowCount = 2;
            this.tbl_EvaluationstudentRecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.93548F));
            this.tbl_EvaluationstudentRecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.06451F));
            this.tbl_EvaluationstudentRecord.Size = new System.Drawing.Size(416, 436);
            this.tbl_EvaluationstudentRecord.TabIndex = 2;
            // 
            // btn_EvaluationUpdate
            // 
            this.btn_EvaluationUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_EvaluationUpdate.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_EvaluationUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_EvaluationUpdate.Location = new System.Drawing.Point(49, 23);
            this.btn_EvaluationUpdate.Name = "btn_EvaluationUpdate";
            this.btn_EvaluationUpdate.Size = new System.Drawing.Size(75, 23);
            this.btn_EvaluationUpdate.TabIndex = 1;
            this.btn_EvaluationUpdate.Text = "Update";
            this.btn_EvaluationUpdate.UseVisualStyleBackColor = false;
            this.btn_EvaluationUpdate.Click += new System.EventHandler(this.btn_EvaluationUpdate_Click);
            // 
            // tbl_EvaluationCRUD
            // 
            this.tbl_EvaluationCRUD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_EvaluationCRUD.ColumnCount = 2;
            this.tbl_EvaluationCRUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_EvaluationCRUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_EvaluationCRUD.Controls.Add(this.btn_EvaluationUpdate, 0, 0);
            this.tbl_EvaluationCRUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_EvaluationCRUD.Location = new System.Drawing.Point(425, 445);
            this.tbl_EvaluationCRUD.Name = "tbl_EvaluationCRUD";
            this.tbl_EvaluationCRUD.RowCount = 1;
            this.tbl_EvaluationCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_EvaluationCRUD.Size = new System.Drawing.Size(347, 70);
            this.tbl_EvaluationCRUD.TabIndex = 1;
            // 
            // tbl_Evaluationmain
            // 
            this.tbl_Evaluationmain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbl_Evaluationmain.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_Evaluationmain.ColumnCount = 2;
            this.tbl_Evaluationmain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.4542F));
            this.tbl_Evaluationmain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.5458F));
            this.tbl_Evaluationmain.Controls.Add(this.tbl_Evaluationgrd, 1, 0);
            this.tbl_Evaluationmain.Controls.Add(this.tbl_Crudd, 0, 1);
            this.tbl_Evaluationmain.Controls.Add(this.tbl_EvaluationCRUD, 1, 1);
            this.tbl_Evaluationmain.Controls.Add(this.tbl_EvaluationstudentRecord, 0, 0);
            this.tbl_Evaluationmain.Location = new System.Drawing.Point(0, -1);
            this.tbl_Evaluationmain.Name = "tbl_Evaluationmain";
            this.tbl_Evaluationmain.RowCount = 2;
            this.tbl_Evaluationmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.52036F));
            this.tbl_Evaluationmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.47964F));
            this.tbl_Evaluationmain.Size = new System.Drawing.Size(775, 518);
            this.tbl_Evaluationmain.TabIndex = 5;
            // 
            // tbl_Evaluationgrd
            // 
            this.tbl_Evaluationgrd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_Evaluationgrd.ColumnCount = 1;
            this.tbl_Evaluationgrd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.7449F));
            this.tbl_Evaluationgrd.Controls.Add(this.tbl_EvaluationBack, 0, 1);
            this.tbl_Evaluationgrd.Controls.Add(this.lbl_Evaluationdetails, 0, 0);
            this.tbl_Evaluationgrd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_Evaluationgrd.Location = new System.Drawing.Point(425, 3);
            this.tbl_Evaluationgrd.Name = "tbl_Evaluationgrd";
            this.tbl_Evaluationgrd.RowCount = 2;
            this.tbl_Evaluationgrd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.93548F));
            this.tbl_Evaluationgrd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.06451F));
            this.tbl_Evaluationgrd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_Evaluationgrd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_Evaluationgrd.Size = new System.Drawing.Size(347, 436);
            this.tbl_Evaluationgrd.TabIndex = 3;
            // 
            // tbl_EvaluationBack
            // 
            this.tbl_EvaluationBack.ColumnCount = 1;
            this.tbl_EvaluationBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.11399F));
            this.tbl_EvaluationBack.Controls.Add(this.grd_EvaluationViewDetails, 0, 0);
            this.tbl_EvaluationBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_EvaluationBack.Location = new System.Drawing.Point(3, 76);
            this.tbl_EvaluationBack.Name = "tbl_EvaluationBack";
            this.tbl_EvaluationBack.RowCount = 1;
            this.tbl_EvaluationBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.46205F));
            this.tbl_EvaluationBack.Size = new System.Drawing.Size(341, 357);
            this.tbl_EvaluationBack.TabIndex = 0;
            // 
            // grd_EvaluationViewDetails
            // 
            this.grd_EvaluationViewDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grd_EvaluationViewDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_EvaluationViewDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.grd_EvaluationViewDetails.Location = new System.Drawing.Point(3, 30);
            this.grd_EvaluationViewDetails.Name = "grd_EvaluationViewDetails";
            this.grd_EvaluationViewDetails.Size = new System.Drawing.Size(335, 297);
            this.grd_EvaluationViewDetails.TabIndex = 0;
            this.grd_EvaluationViewDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_EvaluationViewDetails_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Delete";
            this.Column1.Name = "Column1";
            // 
            // lbl_Evaluationdetails
            // 
            this.lbl_Evaluationdetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Evaluationdetails.AutoSize = true;
            this.lbl_Evaluationdetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Evaluationdetails.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Evaluationdetails.Location = new System.Drawing.Point(61, 23);
            this.lbl_Evaluationdetails.Name = "lbl_Evaluationdetails";
            this.lbl_Evaluationdetails.Size = new System.Drawing.Size(224, 26);
            this.lbl_Evaluationdetails.TabIndex = 15;
            this.lbl_Evaluationdetails.Text = "View Evaluation Details";
            // 
            // tbl_Crudd
            // 
            this.tbl_Crudd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbl_Crudd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_Crudd.ColumnCount = 2;
            this.tbl_Crudd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Crudd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Crudd.Controls.Add(this.btn_EvaluationRetrieve, 1, 0);
            this.tbl_Crudd.Controls.Add(this.btn_EvaluationCreate, 0, 0);
            this.tbl_Crudd.Location = new System.Drawing.Point(15, 451);
            this.tbl_Crudd.Name = "tbl_Crudd";
            this.tbl_Crudd.RowCount = 1;
            this.tbl_Crudd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Crudd.Size = new System.Drawing.Size(392, 58);
            this.tbl_Crudd.TabIndex = 0;
            // 
            // btn_EvaluationRetrieve
            // 
            this.btn_EvaluationRetrieve.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_EvaluationRetrieve.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_EvaluationRetrieve.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_EvaluationRetrieve.Location = new System.Drawing.Point(256, 17);
            this.btn_EvaluationRetrieve.Name = "btn_EvaluationRetrieve";
            this.btn_EvaluationRetrieve.Size = new System.Drawing.Size(75, 23);
            this.btn_EvaluationRetrieve.TabIndex = 1;
            this.btn_EvaluationRetrieve.Text = "Retrieve";
            this.btn_EvaluationRetrieve.UseVisualStyleBackColor = false;
            this.btn_EvaluationRetrieve.Click += new System.EventHandler(this.btn_EvaluationRetrieve_Click);
            // 
            // btn_EvaluationCreate
            // 
            this.btn_EvaluationCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_EvaluationCreate.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_EvaluationCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_EvaluationCreate.Location = new System.Drawing.Point(60, 17);
            this.btn_EvaluationCreate.Name = "btn_EvaluationCreate";
            this.btn_EvaluationCreate.Size = new System.Drawing.Size(75, 23);
            this.btn_EvaluationCreate.TabIndex = 0;
            this.btn_EvaluationCreate.Text = "Create";
            this.btn_EvaluationCreate.UseVisualStyleBackColor = false;
            this.btn_EvaluationCreate.Click += new System.EventHandler(this.btn_EvaluationCreate_Click);
            // 
            // UC_evaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.tbl_Evaluationmain);
            this.Name = "UC_evaluation";
            this.Size = new System.Drawing.Size(775, 516);
            this.tbl_Evaluationrecord.ResumeLayout(false);
            this.tbl_Evaluationrecord.PerformLayout();
            this.tbl_EvaluationstudentRecord.ResumeLayout(false);
            this.tbl_EvaluationstudentRecord.PerformLayout();
            this.tbl_EvaluationCRUD.ResumeLayout(false);
            this.tbl_Evaluationmain.ResumeLayout(false);
            this.tbl_Evaluationgrd.ResumeLayout(false);
            this.tbl_Evaluationgrd.PerformLayout();
            this.tbl_EvaluationBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_EvaluationViewDetails)).EndInit();
            this.tbl_Crudd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_EvaluationControl;
        private System.Windows.Forms.TableLayoutPanel tbl_Evaluationrecord;
        private System.Windows.Forms.Label lbl_EvaluationName;
        private System.Windows.Forms.Label lbl_EvaluationWeightage;
        private System.Windows.Forms.Label lbl_EvaluationMarks;
        private System.Windows.Forms.TableLayoutPanel tbl_EvaluationstudentRecord;
        private System.Windows.Forms.Button btn_EvaluationUpdate;
        private System.Windows.Forms.TableLayoutPanel tbl_EvaluationCRUD;
        private System.Windows.Forms.TableLayoutPanel tbl_Evaluationmain;
        private System.Windows.Forms.TableLayoutPanel tbl_Evaluationgrd;
        private System.Windows.Forms.TableLayoutPanel tbl_EvaluationBack;
        private System.Windows.Forms.DataGridView grd_EvaluationViewDetails;
        private System.Windows.Forms.Label lbl_Evaluationdetails;
        private System.Windows.Forms.TableLayoutPanel tbl_Crudd;
        private System.Windows.Forms.Button btn_EvaluationRetrieve;
        private System.Windows.Forms.Button btn_EvaluationCreate;
        private System.Windows.Forms.TextBox txt_EvaluationName;
        private System.Windows.Forms.TextBox txt_EvaluationMarks;
        private System.Windows.Forms.TextBox txt_EvaluationWeightage;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}
