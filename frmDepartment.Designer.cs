namespace CMS_project
{
    partial class frmDepartment
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartment));
            this.con = new System.Data.SqlClient.SqlConnection();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cMSdb = new CMS_project.CMSdb();
            this.tblDeptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDeptTableAdapter = new CMS_project.CMSdbTableAdapters.tblDeptTableAdapter();
            this.tableAdapterManager = new CMS_project.CMSdbTableAdapters.TableAdapterManager();
            this.tblDeptBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tblDeptBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tblDeptDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cMSdb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDeptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDeptBindingNavigator)).BeginInit();
            this.tblDeptBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDeptDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // con
            // 
            this.con.ConnectionString = "Data Source=gngrt-pc\\sqlexpress;Initial Catalog=CMSdb;Integrated Security=True";
            this.con.FireInfoMessageEventOnUserErrors = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 18);
            this.label10.TabIndex = 52;
            this.label10.Text = "D_NAME";
            // 
            // txtDeptName
            // 
            this.txtDeptName.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDeptName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeptName.Location = new System.Drawing.Point(80, 62);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(120, 20);
            this.txtDeptName.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(208, 60);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 25);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 55;
            this.label1.Text = "DEPARTMENT";
            // 
            // cMSdb
            // 
            this.cMSdb.DataSetName = "CMSdb";
            this.cMSdb.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDeptBindingSource
            // 
            this.tblDeptBindingSource.DataMember = "tblDept";
            this.tblDeptBindingSource.DataSource = this.cMSdb;
            // 
            // tblDeptTableAdapter
            // 
            this.tblDeptTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblDeptTableAdapter = this.tblDeptTableAdapter;
            this.tableAdapterManager.tblEmployeeTableAdapter = null;
            this.tableAdapterManager.tblFeeTableAdapter = null;
            this.tableAdapterManager.tblPatientTableAdapter = null;
            this.tableAdapterManager.tblVisitsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CMS_project.CMSdbTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblDeptBindingNavigator
            // 
            this.tblDeptBindingNavigator.AddNewItem = null;
            this.tblDeptBindingNavigator.BindingSource = this.tblDeptBindingSource;
            this.tblDeptBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblDeptBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblDeptBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.tblDeptBindingNavigatorSaveItem});
            this.tblDeptBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblDeptBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblDeptBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblDeptBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblDeptBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblDeptBindingNavigator.Name = "tblDeptBindingNavigator";
            this.tblDeptBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblDeptBindingNavigator.Size = new System.Drawing.Size(266, 25);
            this.tblDeptBindingNavigator.TabIndex = 56;
            this.tblDeptBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tblDeptBindingNavigatorSaveItem
            // 
            this.tblDeptBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblDeptBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblDeptBindingNavigatorSaveItem.Image")));
            this.tblDeptBindingNavigatorSaveItem.Name = "tblDeptBindingNavigatorSaveItem";
            this.tblDeptBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblDeptBindingNavigatorSaveItem.Text = "Save Data";
            this.tblDeptBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblDeptBindingNavigatorSaveItem_Click);
            // 
            // tblDeptDataGridView
            // 
            this.tblDeptDataGridView.AllowUserToAddRows = false;
            this.tblDeptDataGridView.AutoGenerateColumns = false;
            this.tblDeptDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblDeptDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tblDeptDataGridView.DataSource = this.tblDeptBindingSource;
            this.tblDeptDataGridView.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tblDeptDataGridView.Location = new System.Drawing.Point(8, 103);
            this.tblDeptDataGridView.Name = "tblDeptDataGridView";
            this.tblDeptDataGridView.Size = new System.Drawing.Size(252, 137);
            this.tblDeptDataGridView.TabIndex = 56;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DeptID";
            this.dataGridViewTextBoxColumn1.HeaderText = "DeptID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DeptName";
            this.dataGridViewTextBoxColumn2.HeaderText = "DeptName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // frmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(266, 246);
            this.Controls.Add(this.tblDeptDataGridView);
            this.Controls.Add(this.tblDeptBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDeptName);
            this.Name = "frmDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Department";
            this.Load += new System.EventHandler(this.frmDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cMSdb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDeptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDeptBindingNavigator)).EndInit();
            this.tblDeptBindingNavigator.ResumeLayout(false);
            this.tblDeptBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDeptDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlConnection con;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private CMSdb cMSdb;
        private System.Windows.Forms.BindingSource tblDeptBindingSource;
        private CMSdbTableAdapters.tblDeptTableAdapter tblDeptTableAdapter;
        private CMSdbTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblDeptBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tblDeptBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tblDeptDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

