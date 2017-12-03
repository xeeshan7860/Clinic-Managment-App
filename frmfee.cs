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
    public partial class frmFee : Form
    {
        public frmFee()
        {
            InitializeComponent();
        }
        tblFeeTableAdapter tblFee = new tblFeeTableAdapter();


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                tblFee.spAddNewFee(int.Parse(txtFRs.Text));
                this.tblFeeTableAdapter.Fill(this.cMSdb.tblFee);
                txtFRs.Clear();
               
                MessageBox.Show("data has inserted");
            }
            catch (Exception ex)
            {
                MessageBox.Show("data has not inserted",ex.Message);

            }

        }


        private void FormFEE_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cMSdb.tblFee' table. You can move, or remove it, as needed.
            this.tblFeeTableAdapter.Fill(this.cMSdb.tblFee);

        }

        private void tblFeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblFeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cMSdb);

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            txtFRs.Clear();
        }

      
    }

}