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
    public partial class frmpatient : Form
    {
        public frmpatient()
        {
            InitializeComponent();
        }

        //Creating variables of adapters so can ben instesiated when need

        tblEmployeeTableAdapter tblEmployee;
        spGetpatientDetailTableAdapter PatientDetail;
        tblFeeTableAdapter tblFee;
        spGetDocNameAndIDTableAdapter DocName;
        tblPatientTableAdapter tblpatient;
        tblVisitsTableAdapter tblvisits;


        private void Form2_Load(object sender, EventArgs e)
        {

            btnupdate.Enabled = false;
            
         
            tblFee = new tblFeeTableAdapter();
            tblEmployee = new tblEmployeeTableAdapter();
            DocName = new spGetDocNameAndIDTableAdapter(); 
            RefreshGrid();
            cmbFee.DataSource = tblFee.GetData();
            cmbFee.DisplayMember = "FeeRs";
            cmbFee.ValueMember = "FeeID";
            cmbConsultant.DataSource = DocName.spGetDocIDandName();
            cmbConsultant.ValueMember = "EmpID";
            cmbConsultant.DisplayMember = "EmpName";
        }

        private void RefreshGrid()
        {
            PatientDetail = new spGetpatientDetailTableAdapter();
            dataGridView1.DataSource = PatientDetail.SpGetPatientAndVisitsDetails();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnclear_click(object sender, EventArgs e)
        {
            ClearingFields();

        }

        private void ClearingFields()
        {

            txtcntct.Clear();
            txtDFname.Clear();
            txtDname.Clear();
            txtPid.Clear();
            txtPAddrs.Clear();
            txtPid.Clear();
            txtpname.Clear();
            txtRemarks.Clear();
            txtStatus.Clear();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string DocID = cmbConsultant.SelectedValue.ToString();
            string FeeID = cmbFee.SelectedValue.ToString();

            tblpatient = new tblPatientTableAdapter();
            tblvisits = new tblVisitsTableAdapter();

            tblpatient.spUpdatePatient(txtDname.Text, txtDFname.Text, txtcntct.Text, txtPAddrs.Text, cmbPMstatus.Text, cmbPGender.Text, int.Parse(txtPid.Text));
            tblvisits.spUpdateVisits(int.Parse(txtPid.Text), int.Parse(DocID), int.Parse(FeeID), txtStatus.Text, txtRemarks.Text, DateTime.Parse(dtVisitsDate.Text),int.Parse(lblVisitID.Text));
            Refresh();
            btnupdate.Enabled = false;

            RefreshGrid();
            ClearingFields();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            btnADD.Visible = true;
            FieldsEnabling();

         
        }

        private void FieldsEnabling()
        {
            txtcntct.Enabled = true;
            txtDFname.Enabled = true;
            txtDname.Enabled = true;
            txtPAddrs.Enabled = true;
            cmbPGender.Enabled = true;
            cmbPMstatus.Enabled = true;
            groupBox1.Enabled = true;
            btnADD.Enabled = true;
            btnclear.Enabled = true;
            btndelete.Enabled = true;
            btnExit.Enabled = true;
            btnupdate.Enabled = true;
            txtpname.Enabled = true;
            txtRemarks.Enabled = true;
            txtStatus.Enabled = true;
            cmbConsultant.Enabled = true;
            dtVisitsDate.Enabled = true;
            cmbFee.Enabled = true;
            btnADD.Enabled = true;
        }



        private void btnADD_Click(object sender, EventArgs e)
        {
            string DocID = cmbConsultant.SelectedValue.ToString();
            string FeeID = cmbFee.SelectedValue.ToString();
            
            tblpatient = new tblPatientTableAdapter();
            tblvisits = new tblVisitsTableAdapter();

            string LastID = tblpatient.spAddNewPatient(txtDname.Text, txtDFname.Text, txtcntct.Text, txtPAddrs.Text, cmbPMstatus.Text, cmbPGender.Text).ToString();

            tblvisits.spAddnewVisit(int.Parse(LastID), int.Parse(DocID), int.Parse(FeeID), txtStatus.Text, txtRemarks.Text, DateTime.Parse(dtVisitsDate.Text));

            RefreshGrid();
            ClearingFields();




        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnupdate.Enabled = true;
            btnADD.Enabled = false;
            FieldsEnabling();
            txtPid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtDname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtDFname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtcntct.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtPAddrs.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            cmbPMstatus.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            cmbPGender.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            cmbConsultant.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            dtVisitsDate.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            txtStatus.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            txtRemarks.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            cmbFee.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            lblVisitID.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();

        }

        private void btnOldPatient_Click(object sender, EventArgs e)
        {
            btnADD.Visible = false;
            btnSave.Visible = true;
            txtRemarks.Enabled = true;
            txtStatus.Enabled = true;
            cmbConsultant.Enabled = true;
            dtVisitsDate.Enabled = true;
            cmbFee.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string DocID = cmbConsultant.SelectedValue.ToString();
            string FeeID = cmbFee.SelectedValue.ToString();
            
            
            tblvisits = new tblVisitsTableAdapter();
            tblvisits.spAddnewVisit(int.Parse(txtPid.Text), int.Parse(DocID), int.Parse(FeeID), txtStatus.Text, txtRemarks.Text, DateTime.Parse(dtVisitsDate.Text));
            RefreshGrid();
            ClearingFields();
        }

        private void txtpname_TextChanged(object sender, EventArgs e)
        {
            PatientDetail = new spGetpatientDetailTableAdapter();
          dataGridView1.DataSource =   PatientDetail.GetRecordBYname(txtpname.Text);
          

        }

        private void txtSearchPID_TextChanged(object sender, EventArgs e)
        {

            PatientDetail = new spGetpatientDetailTableAdapter();
          dataGridView1.DataSource =  PatientDetail.GetRecordByID(txtSearchPID.Text);
        }

        private void dtVisitsDate_ValueChanged(object sender, EventArgs e)
        {

        }

     
        
    }
}