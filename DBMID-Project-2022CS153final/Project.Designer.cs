
namespace DBMID_Project_2022CS153final
{
    partial class Project
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
            this.tbl_Projectrecord = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Projecttitle = new System.Windows.Forms.Label();
            this.txt_Projecttitle = new System.Windows.Forms.TextBox();
            this.lbl_projectdescription = new System.Windows.Forms.Label();
            this.txt_Projectdescription = new System.Windows.Forms.TextBox();
            this.lbl_ProjectControl = new System.Windows.Forms.Label();
            this.tbl_ProjectstudentRecord = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_CRUD = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_Projectmain = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_grd = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_frm1 = new System.Windows.Forms.TableLayoutPanel();
            this.grd_ProjectViewDetails = new System.Windows.Forms.DataGridView();
            this.lbl_ViewProjectdetails = new System.Windows.Forms.Label();
            this.tbl_Crudd = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ProjectRetrieve = new System.Windows.Forms.Button();
            this.btn_ProjectCreate = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tbl_Projectrecord.SuspendLayout();
            this.tbl_ProjectstudentRecord.SuspendLayout();
            this.tbl_Projectmain.SuspendLayout();
            this.tbl_grd.SuspendLayout();
            this.tbl_frm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ProjectViewDetails)).BeginInit();
            this.tbl_Crudd.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbl_Projectrecord
            // 
            this.tbl_Projectrecord.ColumnCount = 2;
            this.tbl_Projectrecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tbl_Projectrecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tbl_Projectrecord.Controls.Add(this.lbl_Projecttitle, 0, 0);
            this.tbl_Projectrecord.Controls.Add(this.txt_Projecttitle, 1, 0);
            this.tbl_Projectrecord.Controls.Add(this.lbl_projectdescription, 0, 1);
            this.tbl_Projectrecord.Controls.Add(this.txt_Projectdescription, 1, 1);
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
            // lbl_Projecttitle
            // 
            this.lbl_Projecttitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Projecttitle.AutoSize = true;
            this.lbl_Projecttitle.Location = new System.Drawing.Point(91, 30);
            this.lbl_Projecttitle.Name = "lbl_Projecttitle";
            this.lbl_Projecttitle.Size = new System.Drawing.Size(27, 13);
            this.lbl_Projecttitle.TabIndex = 21;
            this.lbl_Projecttitle.Text = "Title";
            // 
            // txt_Projecttitle
            // 
            this.txt_Projecttitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Projecttitle.Location = new System.Drawing.Point(265, 26);
            this.txt_Projecttitle.Name = "txt_Projecttitle";
            this.txt_Projecttitle.Size = new System.Drawing.Size(100, 20);
            this.txt_Projecttitle.TabIndex = 16;
            // 
            // lbl_projectdescription
            // 
            this.lbl_projectdescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_projectdescription.AutoSize = true;
            this.lbl_projectdescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_projectdescription.Location = new System.Drawing.Point(56, 103);
            this.lbl_projectdescription.Name = "lbl_projectdescription";
            this.lbl_projectdescription.Size = new System.Drawing.Size(96, 13);
            this.lbl_projectdescription.TabIndex = 22;
            this.lbl_projectdescription.Text = "Project Description";
            this.lbl_projectdescription.UseMnemonic = false;
            // 
            // txt_Projectdescription
            // 
            this.txt_Projectdescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Projectdescription.Location = new System.Drawing.Point(264, 99);
            this.txt_Projectdescription.Name = "txt_Projectdescription";
            this.txt_Projectdescription.Size = new System.Drawing.Size(103, 20);
            this.txt_Projectdescription.TabIndex = 17;
            // 
            // lbl_ProjectControl
            // 
            this.lbl_ProjectControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ProjectControl.AutoSize = true;
            this.lbl_ProjectControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_ProjectControl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProjectControl.Location = new System.Drawing.Point(132, 24);
            this.lbl_ProjectControl.Name = "lbl_ProjectControl";
            this.lbl_ProjectControl.Size = new System.Drawing.Size(151, 26);
            this.lbl_ProjectControl.TabIndex = 16;
            this.lbl_ProjectControl.Text = "Project Control";
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
            // tbl_CRUD
            // 
            this.tbl_CRUD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_CRUD.ColumnCount = 2;
            this.tbl_CRUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_CRUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_CRUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_CRUD.Location = new System.Drawing.Point(425, 457);
            this.tbl_CRUD.Name = "tbl_CRUD";
            this.tbl_CRUD.RowCount = 1;
            this.tbl_CRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_CRUD.Size = new System.Drawing.Size(347, 71);
            this.tbl_CRUD.TabIndex = 1;
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
            this.tbl_Projectmain.Location = new System.Drawing.Point(0, 0);
            this.tbl_Projectmain.Name = "tbl_Projectmain";
            this.tbl_Projectmain.RowCount = 2;
            this.tbl_Projectmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.52036F));
            this.tbl_Projectmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.47964F));
            this.tbl_Projectmain.Size = new System.Drawing.Size(775, 531);
            this.tbl_Projectmain.TabIndex = 3;
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
            // tbl_frm1
            // 
            this.tbl_frm1.ColumnCount = 1;
            this.tbl_frm1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.11399F));
            this.tbl_frm1.Controls.Add(this.grd_ProjectViewDetails, 0, 0);
            this.tbl_frm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_frm1.Location = new System.Drawing.Point(3, 78);
            this.tbl_frm1.Name = "tbl_frm1";
            this.tbl_frm1.RowCount = 1;
            this.tbl_frm1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.46205F));
            this.tbl_frm1.Size = new System.Drawing.Size(341, 367);
            this.tbl_frm1.TabIndex = 0;
            // 
            // grd_ProjectViewDetails
            // 
            this.grd_ProjectViewDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grd_ProjectViewDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_ProjectViewDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.grd_ProjectViewDetails.Location = new System.Drawing.Point(3, 35);
            this.grd_ProjectViewDetails.Name = "grd_ProjectViewDetails";
            this.grd_ProjectViewDetails.Size = new System.Drawing.Size(335, 297);
            this.grd_ProjectViewDetails.TabIndex = 0;
            this.grd_ProjectViewDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_ProjectViewDetails_CellContentClick);
            // 
            // lbl_ViewProjectdetails
            // 
            this.lbl_ViewProjectdetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ViewProjectdetails.AutoSize = true;
            this.lbl_ViewProjectdetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_ViewProjectdetails.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ViewProjectdetails.Location = new System.Drawing.Point(77, 24);
            this.lbl_ViewProjectdetails.Name = "lbl_ViewProjectdetails";
            this.lbl_ViewProjectdetails.Size = new System.Drawing.Size(193, 26);
            this.lbl_ViewProjectdetails.TabIndex = 15;
            this.lbl_ViewProjectdetails.Text = "View Project Details";
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
            // Column1
            // 
            this.Column1.HeaderText = "Edit";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Delete";
            this.Column2.Name = "Column2";
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.tbl_Projectmain);
            this.Name = "Project";
            this.Size = new System.Drawing.Size(775, 523);
            this.tbl_Projectrecord.ResumeLayout(false);
            this.tbl_Projectrecord.PerformLayout();
            this.tbl_ProjectstudentRecord.ResumeLayout(false);
            this.tbl_ProjectstudentRecord.PerformLayout();
            this.tbl_Projectmain.ResumeLayout(false);
            this.tbl_grd.ResumeLayout(false);
            this.tbl_grd.PerformLayout();
            this.tbl_frm1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_ProjectViewDetails)).EndInit();
            this.tbl_Crudd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tbl_Projectrecord;
        private System.Windows.Forms.Label lbl_Projecttitle;
        private System.Windows.Forms.TextBox txt_Projecttitle;
        private System.Windows.Forms.Label lbl_projectdescription;
        private System.Windows.Forms.TextBox txt_Projectdescription;
        private System.Windows.Forms.Label lbl_ProjectControl;
        private System.Windows.Forms.TableLayoutPanel tbl_ProjectstudentRecord;
        private System.Windows.Forms.TableLayoutPanel tbl_CRUD;
        private System.Windows.Forms.TableLayoutPanel tbl_Projectmain;
        private System.Windows.Forms.TableLayoutPanel tbl_grd;
        private System.Windows.Forms.TableLayoutPanel tbl_frm1;
        private System.Windows.Forms.DataGridView grd_ProjectViewDetails;
        private System.Windows.Forms.Label lbl_ViewProjectdetails;
        private System.Windows.Forms.TableLayoutPanel tbl_Crudd;
        private System.Windows.Forms.Button btn_ProjectRetrieve;
        private System.Windows.Forms.Button btn_ProjectCreate;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
    }
}
