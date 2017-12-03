using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMS_project.CMSdbTableAdapters;

namespace CMS_project
{
    public partial class frmDepartment : Form
    {
        public frmDepartment()
        {
            InitializeComponent();
        }

        private void tblDeptBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblDeptBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cMSdb);

        }

        tblDeptTableAdapter tblDept;

        private void frmDepartment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cMSdb.tblDept' table. You can move, or remove it, as needed.
            this.tblDeptTableAdapter.Fill(this.cMSdb.tblDept);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                tblDept = new tblDeptTableAdapter();
                tblDept.spAddNewDept(txtDeptName.Text);
                MessageBox.Show("Record Inserted");
                txtDeptName.Clear();
                txtDeptName.Focus();
                this.tblDeptTableAdapter.Fill(this.cMSdb.tblDept);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Record Couldn't Insert" + "     " + ex.Message);
            
            }
            

        }
    }
}
