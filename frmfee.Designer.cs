namespace CMS_project
{
    partial class frmFee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFee));
            this.label2 = new System.Windows.Forms.Label();
            this.txtFRs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtFid = new System.Windows.Forms.TextBox();
            this.tblFeeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tblFeeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tblFeeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblFeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cMSdb = new CMS_project.CMSdb();
            this.tblFeeTableAdapter = new CMS_project.CMSdbTableAdapters.tblFeeTableAdapter();
            this.tableAdapterManager = new CMS_project.CMSdbTableAdapters.TableAdapterManager();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblFeeBindingNavigator)).BeginInit();
            this.tblFeeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblFeeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMSdb)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "FEE_RS";
            // 
            // txtFRs
            // 
            this.txtFRs.BackColor = System.Drawing.SystemColors.Menu;
            this.txtFRs.Location = new System.Drawing.Point(143, 76);
            this.txtFRs.Name = "txtFRs";
            this.txtFRs.Size = new System.Drawing.Size(116, 20);
            this.txtFRs.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "FEE_ID";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAdd.Location = new System.Drawing.Point(184, 119);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "SAVE";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtFid
            // 
            this.txtFid.BackColor = System.Drawing.SystemColors.Menu;
            this.txtFid.Enabled = false;
            this.txtFid.Location = new System.Drawing.Point(143, 42);
            this.txtFid.Name = "txtFid";
            this.txtFid.Size = new System.Drawing.Size(116, 20);
            this.txtFid.TabIndex = 10;
            // 
            // tblFeeBindingNavigator
            // 
            this.tblFeeBindingNavigator.AddNewItem = null;
            this.tblFeeBindingNavigator.BindingSource = this.tblFeeBindingSource;
            this.tblFeeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblFeeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblFeeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblFeeBindingNavigatorSaveItem});
            this.tblFeeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblFeeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblFeeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblFeeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblFeeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblFeeBindingNavigator.Name = "tblFeeBindingNavigator";
            this.tblFeeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblFeeBindingNavigator.Size = new System.Drawing.Size(277, 25);
            this.tblFeeBindingNavigator.TabIndex = 11;
            this.tblFeeBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // tblFeeBindingNavigatorSaveItem
            // 
            this.tblFeeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblFeeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblFeeBindingNavigatorSaveItem.Image")));
            this.tblFeeBindingNavigatorSaveItem.Name = "tblFeeBindingNavigatorSaveItem";
            this.tblFeeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblFeeBindingNavigatorSaveItem.Text = "Save Data";
            this.tblFeeBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblFeeBindingNavigatorSaveItem_Click);
            // 
            // tblFeeDataGridView
            // 
            this.tblFeeDataGridView.AllowUserToAddRows = false;
            this.tblFeeDataGridView.AutoGenerateColumns = false;
            this.tblFeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblFeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tblFeeDataGridView.DataSource = this.tblFeeBindingSource;
            this.tblFeeDataGridView.Location = new System.Drawing.Point(12, 148);
            this.tblFeeDataGridView.Name = "tblFeeDataGridView";
            this.tblFeeDataGridView.Size = new System.Drawing.Size(247, 168);
            this.tblFeeDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FeeID";
            this.dataGridViewTextBoxColumn1.HeaderText = "FeeID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FeeRs";
            this.dataGridViewTextBoxColumn2.HeaderText = "FeeRs";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // tblFeeBindingSource
            // 
            this.tblFeeBindingSource.DataMember = "tblFee";
            this.tblFeeBindingSource.DataSource = this.cMSdb;
            // 
            // cMSdb
            // 
            this.cMSdb.DataSetName = "CMSdb";
            this.cMSdb.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblFeeTableAdapter
            // 
            this.tblFeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblDeptTableAdapter = null;
            this.tableAdapterManager.tblEmployeeTableAdapter = null;
            this.tableAdapterManager.tblFeeTableAdapter = this.tblFeeTableAdapter;
            this.tableAdapterManager.tblPatientTableAdapter = null;
            this.tableAdapterManager.tblVisitsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CMS_project.CMSdbTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnexit.Location = new System.Drawing.Point(184, 340);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 12;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclr
            // 
            this.btnclr.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnclr.Location = new System.Drawing.Point(12, 340);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(75, 23);
            this.btnclr.TabIndex = 13;
            this.btnclr.Text = "CLEAR";
            this.btnclr.UseVisualStyleBackColor = false;
            this.btnclr.Click += new System.EventHandler(this.btnclr_Click);
            // 
            // frmFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(277, 375);
            this.Controls.Add(this.btnclr);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.tblFeeDataGridView);
            this.Controls.Add(this.tblFeeBindingNavigator);
            this.Controls.Add(this.txtFid);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFRs);
            this.Controls.Add(this.label1);
            this.Name = "frmFee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fees ";
            this.Load += new System.EventHandler(this.FormFEE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblFeeBindingNavigator)).EndInit();
            this.tblFeeBindingNavigator.ResumeLayout(false);
            this.tblFeeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblFeeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMSdb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFRs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtFid;
        private CMSdb cMSdb;
        private System.Windows.Forms.BindingSource tblFeeBindingSource;
        private CMSdbTableAdapters.tblFeeTableAdapter tblFeeTableAdapter;
        private CMSdbTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblFeeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblFeeBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tblFeeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclr;
    }
}