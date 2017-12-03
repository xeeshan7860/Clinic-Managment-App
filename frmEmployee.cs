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
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }
        // Objects of Adapters
        tblDeptTableAdapter tblDept = new tblDeptTableAdapter();
        tblEmployeeTableAdapter tblEmployee = new tblEmployeeTableAdapter();
        spGetEmpDateTableAdapter spEmpGetData = new spGetEmpDateTableAdapter();


        private void frmEmployee_Load(object sender, EventArgs e)
        {
            //Filling Combobox with Department Names so can be selected during adding new records
            cmbDID.DataSource = tblDept.spGetDeptData();
            cmbDID.DisplayMember = "DeptName";
            cmbDID.ValueMember = "DeptID";
            
            
            GriddFill();
          
            }

        private void GriddFill()  // yeh method hai grid ka jo grid ko refresh karta hai 
        {

            //Filling GridBox using our AdapterMethod 

            GridEmployeeRecord.DataSource = spEmpGetData.spGetEmpData();
           
            
        }


        private void cmbEid_SelectedIndexChanged(object sender, EventArgs e)
        {
      
         }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Inserting New Record using a tableadpter method referenced of procedure
            try
            {
                string DeptID = cmbDID.SelectedValue.ToString();
                tblEmployee.spAddNewEmployee(txtEname.Text, txtEfName.Text, cmbEGender.Text, txtEAge.Text, txtEContactNo.Text, DateTime.Parse(dtpEjoiningdate.Text), cmbEMartialStatus.Text, int.Parse(txtESalary.Text), txtAdress.Text, int.Parse(DeptID));
                GriddFill(); 
                MessageBox.Show("Record Inserted");
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Record Couldn't Insert" + "    " + ex.Message);
            }
            
        }

        private void btnEupdate_Click(object sender, EventArgs e)
        {
            string DeptID = cmbDID.SelectedValue.ToString();
            tblEmployee.spUpdateEmployee(txtEname.Text, txtEfName.Text, cmbEGender.Text, txtEAge.Text, txtEContactNo.Text, DateTime.Parse(dtpEjoiningdate.Text),cmbEMartialStatus.Text, int.Parse(txtESalary.Text), txtAdress.Text, int.Parse(DeptID),int.Parse(txtEID.Text));
            MessageBox.Show("Record Updae");
            GriddFill();  //yahan per yeh method is liye call kiya k update honey k bad record refresh ho kr show ho
            ClearingFields();
        }

        private void btnEdelete_Click(object sender, EventArgs e)
        {
            //jab bhi ap koi method call karti hain 
            //wo method btata hai k usy kya chahiye.. 
            //jaisy he ik bracket on karain gi .. wahan per aa jayega k kyaa chiz pass karni hai 


            tblEmployee.spDeleteEmployee(int.Parse(txtEID.Text));
            GriddFill(); // After deleting a record yeh  new data lay ayega delete honey k bad
            ClearingFields();
            MessageBox.Show("Record Deleted");
        }

        private void cmbDID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEClear_Click(object sender, EventArgs e)
        {
            ClearingFields();
            
            
        }

        private void ClearingFields()
        {
            txtEname.Clear();
            txtEfName.Clear();
            txtESalary.Clear();
            txtEID.Clear();
            txtEContactNo.Clear();
            txtEAge.Clear();
            txtAdress.Clear();
        }

        private void btnEexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEedit_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void GridEmployeeRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEID.Text = GridEmployeeRecord.SelectedRows[0].Cells[0].Value.ToString();
            txtEname.Text = GridEmployeeRecord.SelectedRows[0].Cells[1].Value.ToString();
            txtEfName.Text = GridEmployeeRecord.SelectedRows[0].Cells[2].Value.ToString();
            txtEAge.Text = GridEmployeeRecord.SelectedRows[0].Cells[4].Value.ToString();
            txtEContactNo.Text = GridEmployeeRecord.SelectedRows[0].Cells[5].Value.ToString();
            dtpEjoiningdate.Text = GridEmployeeRecord.SelectedRows[0].Cells[6].Value.ToString();
            txtESalary.Text = GridEmployeeRecord.SelectedRows[0].Cells[8].Value.ToString();
            txtAdress.Text = GridEmployeeRecord.SelectedRows[0].Cells[9].Value.ToString();
            cmbEGender.Text = GridEmployeeRecord.SelectedRows[0].Cells[3].Value.ToString();
            cmbEMartialStatus.Text = GridEmployeeRecord.SelectedRows[0].Cells[7].Value.ToString();
            cmbDID.Text = GridEmployeeRecord.SelectedRows[0].Cells[10].Value.ToString();
            

        }
        }
    }

