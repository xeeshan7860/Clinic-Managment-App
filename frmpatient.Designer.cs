namespace CMS_project
{
    partial class frmpatient
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnOldPatient = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.cmbPGender = new System.Windows.Forms.ComboBox();
            this.txtPAddrs = new System.Windows.Forms.TextBox();
            this.txtDFname = new System.Windows.Forms.TextBox();
            this.txtDname = new System.Windows.Forms.TextBox();
            this.cmbPMstatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtPid = new System.Windows.Forms.TextBox();
            this.txtcntct = new System.Windows.Forms.TextBox();
            this.cmbConsultant = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtVisitsDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSearchPID = new System.Windows.Forms.TextBox();
            this.txtpname = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbFee = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lblVisitID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnOldPatient);
            this.groupBox1.Controls.Add(this.btnADD);
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(63, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 44);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSave.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.Location = new System.Drawing.Point(210, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnNew.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNew.Location = new System.Drawing.Point(48, 15);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "NEW";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnOldPatient
            // 
            this.btnOldPatient.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnOldPatient.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOldPatient.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnOldPatient.Location = new System.Drawing.Point(129, 15);
            this.btnOldPatient.Name = "btnOldPatient";
            this.btnOldPatient.Size = new System.Drawing.Size(75, 23);
            this.btnOldPatient.TabIndex = 12;
            this.btnOldPatient.Text = "OLD P";
            this.btnOldPatient.UseVisualStyleBackColor = false;
            this.btnOldPatient.Click += new System.EventHandler(this.btnOldPatient_Click);
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnADD.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnADD.Location = new System.Drawing.Point(210, 15);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(75, 23);
            this.btnADD.TabIndex = 9;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnclear.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnclear.Location = new System.Drawing.Point(453, 15);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 11;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnExit.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnExit.Location = new System.Drawing.Point(534, 15);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btndelete.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btndelete.Location = new System.Drawing.Point(372, 15);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 7;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnupdate.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnupdate.Location = new System.Drawing.Point(291, 15);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 6;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // cmbPGender
            // 
            this.cmbPGender.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbPGender.Enabled = false;
            this.cmbPGender.FormattingEnabled = true;
            this.cmbPGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbPGender.Location = new System.Drawing.Point(386, 31);
            this.cmbPGender.Name = "cmbPGender";
            this.cmbPGender.Size = new System.Drawing.Size(121, 21);
            this.cmbPGender.TabIndex = 67;
            // 
            // txtPAddrs
            // 
            this.txtPAddrs.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPAddrs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPAddrs.Enabled = false;
            this.txtPAddrs.Location = new System.Drawing.Point(542, 177);
            this.txtPAddrs.Multiline = true;
            this.txtPAddrs.Name = "txtPAddrs";
            this.txtPAddrs.Size = new System.Drawing.Size(257, 52);
            this.txtPAddrs.TabIndex = 6;
            // 
            // txtDFname
            // 
            this.txtDFname.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDFname.Enabled = false;
            this.txtDFname.Location = new System.Drawing.Point(148, 87);
            this.txtDFname.Name = "txtDFname";
            this.txtDFname.Size = new System.Drawing.Size(117, 20);
            this.txtDFname.TabIndex = 3;
            // 
            // txtDname
            // 
            this.txtDname.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDname.Enabled = false;
            this.txtDname.Location = new System.Drawing.Point(148, 54);
            this.txtDname.Name = "txtDname";
            this.txtDname.Size = new System.Drawing.Size(117, 20);
            this.txtDname.TabIndex = 2;
            // 
            // cmbPMstatus
            // 
            this.cmbPMstatus.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbPMstatus.Enabled = false;
            this.cmbPMstatus.FormattingEnabled = true;
            this.cmbPMstatus.Items.AddRange(new object[] {
            "Married",
            "Single",
            "Divorced",
            "Widow"});
            this.cmbPMstatus.Location = new System.Drawing.Point(148, 158);
            this.cmbPMstatus.Name = "cmbPMstatus";
            this.cmbPMstatus.Size = new System.Drawing.Size(120, 21);
            this.cmbPMstatus.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(285, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 18);
            this.label7.TabIndex = 58;
            this.label7.Text = "P_GENDER";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(4, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 18);
            this.label6.TabIndex = 54;
            this.label6.Text = "P_MARTIAL STATUS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(605, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 53;
            this.label5.Text = "P_ADDRESS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(13, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 18);
            this.label4.TabIndex = 52;
            this.label4.Text = "P_CONTACT NO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(41, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 51;
            this.label3.Text = "P_ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(20, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 50;
            this.label2.Text = "P_FNAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(32, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 49;
            this.label1.Text = "P_NAME";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(9, 336);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(790, 159);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtPid
            // 
            this.txtPid.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPid.Enabled = false;
            this.txtPid.Location = new System.Drawing.Point(148, 21);
            this.txtPid.Name = "txtPid";
            this.txtPid.Size = new System.Drawing.Size(117, 20);
            this.txtPid.TabIndex = 1;
            // 
            // txtcntct
            // 
            this.txtcntct.BackColor = System.Drawing.SystemColors.Menu;
            this.txtcntct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcntct.Enabled = false;
            this.txtcntct.Location = new System.Drawing.Point(148, 123);
            this.txtcntct.Name = "txtcntct";
            this.txtcntct.Size = new System.Drawing.Size(117, 20);
            this.txtcntct.TabIndex = 4;
            // 
            // cmbConsultant
            // 
            this.cmbConsultant.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbConsultant.Enabled = false;
            this.cmbConsultant.FormattingEnabled = true;
            this.cmbConsultant.Location = new System.Drawing.Point(148, 195);
            this.cmbConsultant.Name = "cmbConsultant";
            this.cmbConsultant.Size = new System.Drawing.Size(120, 21);
            this.cmbConsultant.TabIndex = 72;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(13, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 18);
            this.label10.TabIndex = 71;
            this.label10.Text = "CONSULTANT DR";
            // 
            // dtVisitsDate
            // 
            this.dtVisitsDate.Enabled = false;
            this.dtVisitsDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtVisitsDate.Location = new System.Drawing.Point(386, 123);
            this.dtVisitsDate.Name = "dtVisitsDate";
            this.dtVisitsDate.Size = new System.Drawing.Size(121, 20);
            this.dtVisitsDate.TabIndex = 73;
            this.dtVisitsDate.ValueChanged += new System.EventHandler(this.dtVisitsDate_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(291, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 18);
            this.label11.TabIndex = 74;
            this.label11.Text = "V_DATE";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BackColor = System.Drawing.SystemColors.Menu;
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Enabled = false;
            this.txtRemarks.Location = new System.Drawing.Point(542, 32);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(257, 52);
            this.txtRemarks.TabIndex = 75;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label14.Location = new System.Drawing.Point(605, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 18);
            this.label14.TabIndex = 76;
            this.label14.Text = "P_REMARKS";
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.SystemColors.Menu;
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(542, 106);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(257, 52);
            this.txtStatus.TabIndex = 77;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label15.Location = new System.Drawing.Point(605, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 18);
            this.label15.TabIndex = 78;
            this.label15.Text = "P_STATUS";
            // 
            // txtSearchPID
            // 
            this.txtSearchPID.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSearchPID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchPID.Location = new System.Drawing.Point(219, 313);
            this.txtSearchPID.Name = "txtSearchPID";
            this.txtSearchPID.Size = new System.Drawing.Size(117, 20);
            this.txtSearchPID.TabIndex = 79;
            this.txtSearchPID.TextChanged += new System.EventHandler(this.txtSearchPID_TextChanged);
            // 
            // txtpname
            // 
            this.txtpname.BackColor = System.Drawing.SystemColors.Menu;
            this.txtpname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpname.Location = new System.Drawing.Point(405, 312);
            this.txtpname.Name = "txtpname";
            this.txtpname.Size = new System.Drawing.Size(117, 20);
            this.txtpname.TabIndex = 80;
            this.txtpname.TextChanged += new System.EventHandler(this.txtpname_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label16.Location = new System.Drawing.Point(13, 310);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 22);
            this.label16.TabIndex = 81;
            this.label16.Text = "SEARCH BY";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label17.Location = new System.Drawing.Point(357, 314);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 18);
            this.label17.TabIndex = 82;
            this.label17.Text = "Name";
            // 
            // cmbFee
            // 
            this.cmbFee.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbFee.Enabled = false;
            this.cmbFee.FormattingEnabled = true;
            this.cmbFee.Location = new System.Drawing.Point(386, 83);
            this.cmbFee.Name = "cmbFee";
            this.cmbFee.Size = new System.Drawing.Size(121, 21);
            this.cmbFee.TabIndex = 84;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label18.Location = new System.Drawing.Point(291, 85);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 18);
            this.label18.TabIndex = 83;
            this.label18.Text = "Select Fees";
            // 
            // lblVisitID
            // 
            this.lblVisitID.AutoSize = true;
            this.lblVisitID.Location = new System.Drawing.Point(522, 12);
            this.lblVisitID.Name = "lblVisitID";
            this.lblVisitID.Size = new System.Drawing.Size(0, 13);
            this.lblVisitID.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(189, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 18);
            this.label8.TabIndex = 85;
            this.label8.Text = "ID";
            // 
            // frmpatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(811, 509);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblVisitID);
            this.Controls.Add(this.cmbFee);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtpname);
            this.Controls.Add(this.txtSearchPID);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtVisitsDate);
            this.Controls.Add(this.cmbConsultant);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtcntct);
            this.Controls.Add(this.txtPid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbPGender);
            this.Controls.Add(this.txtPAddrs);
            this.Controls.Add(this.txtDFname);
            this.Controls.Add(this.txtDname);
            this.Controls.Add(this.cmbPMstatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmpatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                        PATIENT";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.ComboBox cmbPGender;
        private System.Windows.Forms.TextBox txtPAddrs;
        private System.Windows.Forms.TextBox txtDFname;
        private System.Windows.Forms.TextBox txtDname;
        private System.Windows.Forms.ComboBox cmbPMstatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.TextBox txtPid;
        private System.Windows.Forms.TextBox txtcntct;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnOldPatient;
        private System.Windows.Forms.ComboBox cmbConsultant;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtVisitsDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSearchPID;
        private System.Windows.Forms.TextBox txtpname;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbFee;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblVisitID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label8;

    }
}