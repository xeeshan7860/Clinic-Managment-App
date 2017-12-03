namespace CMS_project
{
    partial class StartForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnFee = new System.Windows.Forms.Button();
            this.btnpatient = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnDept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::CMS_project.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_dialog_close;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(248, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 63);
            this.button1.TabIndex = 4;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFee
            // 
            this.btnFee.BackgroundImage = global::CMS_project.Properties.Resources.webdev_money_icon;
            this.btnFee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFee.Location = new System.Drawing.Point(172, 12);
            this.btnFee.Name = "btnFee";
            this.btnFee.Size = new System.Drawing.Size(154, 137);
            this.btnFee.TabIndex = 3;
            this.btnFee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFee.UseVisualStyleBackColor = true;
            this.btnFee.Click += new System.EventHandler(this.btnFee_Click);
            // 
            // btnpatient
            // 
            this.btnpatient.BackgroundImage = global::CMS_project.Properties.Resources.patient;
            this.btnpatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnpatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpatient.Location = new System.Drawing.Point(12, 155);
            this.btnpatient.Name = "btnpatient";
            this.btnpatient.Size = new System.Drawing.Size(154, 137);
            this.btnpatient.TabIndex = 2;
            this.btnpatient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnpatient.UseVisualStyleBackColor = true;
            this.btnpatient.Click += new System.EventHandler(this.btnpatient_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackgroundImage = global::CMS_project.Properties.Resources.images__1_;
            this.btnEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.Location = new System.Drawing.Point(172, 155);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(154, 137);
            this.btnEmployee.TabIndex = 1;
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnDept
            // 
            this.btnDept.BackgroundImage = global::CMS_project.Properties.Resources.solutions_departments;
            this.btnDept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDept.Location = new System.Drawing.Point(12, 12);
            this.btnDept.Name = "btnDept";
            this.btnDept.Size = new System.Drawing.Size(154, 137);
            this.btnDept.TabIndex = 0;
            this.btnDept.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDept.UseVisualStyleBackColor = true;
            this.btnDept.Click += new System.EventHandler(this.btnDept_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(331, 406);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFee);
            this.Controls.Add(this.btnpatient);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnDept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartForm";
            this.Opacity = 0.7D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinic Management System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDept;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnpatient;
        private System.Windows.Forms.Button btnFee;
        private System.Windows.Forms.Button button1;
    }
}