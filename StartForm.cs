using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS_project
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void btnDept_Click(object sender, EventArgs e)
        {
            frmDepartment frmDept = new frmDepartment();
            frmDept.Show();
        }

        private void btnFee_Click(object sender, EventArgs e)
        {
            frmFee frmfee = new frmFee();
            frmfee.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            frmEmployee employee = new frmEmployee();
            employee.Show();
        }

        private void btnpatient_Click(object sender, EventArgs e)
        {
            frmpatient patient = new frmpatient();
            patient.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
