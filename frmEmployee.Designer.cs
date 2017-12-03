namespace CMS_project
{
    partial class frmEmployee
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
            this.cmbDID = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEClear = new System.Windows.Forms.Button();
            this.btnEexit = new System.Windows.Forms.Button();
            this.btnEedit = new System.Windows.Forms.Button();
            this.btnEdelete = new System.Windows.Forms.Button();
            this.btnEupdate = new System.Windows.Forms.Button();
            this.cmbEGender = new System.Windows.Forms.ComboBox();
            this.txtEAge = new System.Windows.Forms.TextBox();
            this.txtESalary = new System.Windows.Forms.TextBox();
            this.txtEfName = new System.Windows.Forms.TextBox();
            this.txtEname = new System.Windows.Forms.TextBox();
            this.cmbEMartialStatus = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpEjoiningdate = new System.Windows.Forms.DateTimePicker();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtEContactNo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEID = new System.Windows.Forms.TextBox();
            this.GridEmployeeRecord = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmployeeRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDID
            // 
            this.cmbDID.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbDID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbDID.FormattingEnabled = true;
            this.cmbDID.Location = new System.Drawing.Point(390, 75);
            this.cmbDID.Name = "cmbDID";
            this.cmbDID.Size = new System.Drawing.Size(121, 21);
            this.cmbDID.TabIndex = 7;
            this.cmbDID.SelectedIndexChanged += new System.EventHandler(this.cmbDID_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnEClear);
            this.groupBox1.Controls.Add(this.btnEexit);
            this.groupBox1.Controls.Add(this.btnEedit);
            this.groupBox1.Controls.Add(this.btnEdelete);
            this.groupBox1.Controls.Add(this.btnEupdate);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(117, 433);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 87);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSave.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(220, 52);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEClear
            // 
            this.btnEClear.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEClear.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEClear.Location = new System.Drawing.Point(222, 17);
            this.btnEClear.Name = "btnEClear";
            this.btnEClear.Size = new System.Drawing.Size(75, 23);
            this.btnEClear.TabIndex = 15;
            this.btnEClear.Text = "CLEAR";
            this.btnEClear.UseVisualStyleBackColor = false;
            this.btnEClear.Click += new System.EventHandler(this.btnEClear_Click);
            // 
            // btnEexit
            // 
            this.btnEexit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEexit.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEexit.Location = new System.Drawing.Point(116, 52);
            this.btnEexit.Name = "btnEexit";
            this.btnEexit.Size = new System.Drawing.Size(75, 23);
            this.btnEexit.TabIndex = 14;
            this.btnEexit.Text = "EXIT";
            this.btnEexit.UseVisualStyleBackColor = false;
            this.btnEexit.Click += new System.EventHandler(this.btnEexit_Click);
            // 
            // btnEedit
            // 
            this.btnEedit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEedit.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEedit.Location = new System.Drawing.Point(8, 52);
            this.btnEedit.Name = "btnEedit";
            this.btnEedit.Size = new System.Drawing.Size(75, 23);
            this.btnEedit.TabIndex = 13;
            this.btnEedit.Text = "EDIT";
            this.btnEedit.UseVisualStyleBackColor = false;
            this.btnEedit.Click += new System.EventHandler(this.btnEedit_Click);
            // 
            // btnEdelete
            // 
            this.btnEdelete.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEdelete.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdelete.Location = new System.Drawing.Point(118, 17);
            this.btnEdelete.Name = "btnEdelete";
            this.btnEdelete.Size = new System.Drawing.Size(75, 23);
            this.btnEdelete.TabIndex = 12;
            this.btnEdelete.Text = "DELETE";
            this.btnEdelete.UseVisualStyleBackColor = false;
            this.btnEdelete.Click += new System.EventHandler(this.btnEdelete_Click);
            // 
            // btnEupdate
            // 
            this.btnEupdate.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEupdate.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEupdate.Location = new System.Drawing.Point(11, 17);
            this.btnEupdate.Name = "btnEupdate";
            this.btnEupdate.Size = new System.Drawing.Size(75, 23);
            this.btnEupdate.TabIndex = 11;
            this.btnEupdate.Text = "UPDATE";
            this.btnEupdate.UseVisualStyleBackColor = false;
            this.btnEupdate.Click += new System.EventHandler(this.btnEupdate_Click);
            // 
            // cmbEGender
            // 
            this.cmbEGender.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbEGender.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbEGender.FormattingEnabled = true;
            this.cmbEGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "SheMale"});
            this.cmbEGender.Location = new System.Drawing.Point(390, 17);
            this.cmbEGender.Name = "cmbEGender";
            this.cmbEGender.Size = new System.Drawing.Size(121, 21);
            this.cmbEGender.TabIndex = 5;
            // 
            // txtEAge
            // 
            this.txtEAge.BackColor = System.Drawing.SystemColors.Menu;
            this.txtEAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEAge.Location = new System.Drawing.Point(390, 102);
            this.txtEAge.Name = "txtEAge";
            this.txtEAge.Size = new System.Drawing.Size(66, 20);
            this.txtEAge.TabIndex = 10;
            // 
            // txtESalary
            // 
            this.txtESalary.BackColor = System.Drawing.SystemColors.Menu;
            this.txtESalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtESalary.Location = new System.Drawing.Point(151, 229);
            this.txtESalary.Name = "txtESalary";
            this.txtESalary.Size = new System.Drawing.Size(121, 20);
            this.txtESalary.TabIndex = 9;
            // 
            // txtEfName
            // 
            this.txtEfName.BackColor = System.Drawing.SystemColors.Menu;
            this.txtEfName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEfName.Location = new System.Drawing.Point(137, 77);
            this.txtEfName.Name = "txtEfName";
            this.txtEfName.Size = new System.Drawing.Size(111, 20);
            this.txtEfName.TabIndex = 1;
            // 
            // txtEname
            // 
            this.txtEname.BackColor = System.Drawing.SystemColors.Menu;
            this.txtEname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEname.Location = new System.Drawing.Point(137, 42);
            this.txtEname.Name = "txtEname";
            this.txtEname.Size = new System.Drawing.Size(111, 20);
            this.txtEname.TabIndex = 0;
            // 
            // cmbEMartialStatus
            // 
            this.cmbEMartialStatus.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbEMartialStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbEMartialStatus.FormattingEnabled = true;
            this.cmbEMartialStatus.Items.AddRange(new object[] {
            "Married",
            "UnMarried",
            "Widow",
            "Divorced"});
            this.cmbEMartialStatus.Location = new System.Drawing.Point(151, 194);
            this.cmbEMartialStatus.Name = "cmbEMartialStatus";
            this.cmbEMartialStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbEMartialStatus.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(458, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 18);
            this.label13.TabIndex = 59;
            this.label13.Text = "YEARs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(265, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 18);
            this.label7.TabIndex = 58;
            this.label7.Text = "E_GENDER";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(256, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 18);
            this.label8.TabIndex = 57;
            this.label8.Text = "E_JOINING DATE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(291, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 18);
            this.label9.TabIndex = 56;
            this.label9.Text = "D_ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(291, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 18);
            this.label12.TabIndex = 55;
            this.label12.Text = "E_AGE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 18);
            this.label6.TabIndex = 54;
            this.label6.Text = "E_MARTIAL STATUS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 18);
            this.label5.TabIndex = 53;
            this.label5.Text = "E_ADDRESS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 52;
            this.label4.Text = "E_CONTACT NO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-62, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "P_ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 50;
            this.label2.Text = "E_FNAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 49;
            this.label1.Text = "E_NAME";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 18);
            this.label11.TabIndex = 73;
            this.label11.Text = "E_SALARY";
            // 
            // dtpEjoiningdate
            // 
            this.dtpEjoiningdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEjoiningdate.Location = new System.Drawing.Point(392, 47);
            this.dtpEjoiningdate.Name = "dtpEjoiningdate";
            this.dtpEjoiningdate.Size = new System.Drawing.Size(119, 20);
            this.dtpEjoiningdate.TabIndex = 6;
            // 
            // txtAdress
            // 
            this.txtAdress.BackColor = System.Drawing.SystemColors.Menu;
            this.txtAdress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdress.Location = new System.Drawing.Point(137, 131);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(374, 47);
            this.txtAdress.TabIndex = 3;
            // 
            // txtEContactNo
            // 
            this.txtEContactNo.BackColor = System.Drawing.SystemColors.Menu;
            this.txtEContactNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEContactNo.Location = new System.Drawing.Point(137, 105);
            this.txtEContactNo.Name = "txtEContactNo";
            this.txtEContactNo.Size = new System.Drawing.Size(111, 20);
            this.txtEContactNo.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(39, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 18);
            this.label14.TabIndex = 76;
            this.label14.Text = "E_ID";
            // 
            // txtEID
            // 
            this.txtEID.BackColor = System.Drawing.SystemColors.Menu;
            this.txtEID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEID.Enabled = false;
            this.txtEID.Location = new System.Drawing.Point(137, 16);
            this.txtEID.Name = "txtEID";
            this.txtEID.Size = new System.Drawing.Size(111, 20);
            this.txtEID.TabIndex = 77;
            this.txtEID.TabStop = false;
            // 
            // GridEmployeeRecord
            // 
            this.GridEmployeeRecord.AllowUserToAddRows = false;
            this.GridEmployeeRecord.AllowUserToDeleteRows = false;
            this.GridEmployeeRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEmployeeRecord.Location = new System.Drawing.Point(12, 255);
            this.GridEmployeeRecord.Name = "GridEmployeeRecord";
            this.GridEmployeeRecord.ReadOnly = true;
            this.GridEmployeeRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridEmployeeRecord.Size = new System.Drawing.Size(499, 172);
            this.GridEmployeeRecord.TabIndex = 78;
            this.GridEmployeeRecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridEmployeeRecord_CellClick);
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(523, 522);
            this.Controls.Add(this.GridEmployeeRecord);
            this.Controls.Add(this.txtEID);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtEContactNo);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.dtpEjoiningdate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbDID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbEGender);
            this.Controls.Add(this.txtEAge);
            this.Controls.Add(this.txtESalary);
            this.Controls.Add(this.txtEfName);
            this.Controls.Add(this.txtEname);
            this.Controls.Add(this.cmbEMartialStatus);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                  EMPLOYEE";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridEmployeeRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEClear;
        private System.Windows.Forms.Button btnEexit;
        private System.Windows.Forms.Button btnEedit;
        private System.Windows.Forms.Button btnEdelete;
        private System.Windows.Forms.Button btnEupdate;
        private System.Windows.Forms.ComboBox cmbEGender;
        private System.Windows.Forms.TextBox txtEAge;
        private System.Windows.Forms.TextBox txtESalary;
        private System.Windows.Forms.TextBox txtEfName;
        private System.Windows.Forms.TextBox txtEname;
        private System.Windows.Forms.ComboBox cmbEMartialStatus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpEjoiningdate;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtEContactNo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtEID;
        private System.Windows.Forms.DataGridView GridEmployeeRecord;
    }
}