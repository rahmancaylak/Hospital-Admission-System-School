using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalAdmissionSystem.DataLayer;
using HospitalAdmissionSystem.DataLayer.DBOperations;
using HospitalAdmissionSystem.DataLayer.Model;

namespace HospitalAdmissionSystem
{
    public partial class Form1 : Form
    
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=HospitalAdmissionSystem;Integrated Security=True";
        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllPatient();
            GetAllDoctorList();
            GetAllDepartmentName();
            ChangeColumnsName();
            cbDoctorName.SelectedIndex = 0;
            cbDoctorDepartment.SelectedIndex = 0;
            cbPatientGender.SelectedIndex = 0;

        }
        private void GetAllDepartmentName()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand("SELECT * FROM Department", con);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            foreach (DataRow dr in tbl.Rows)
            {
                cbDoctorDepartment.Items.Add(dr["departmentName"]);
            }
            con.Close();
        }

        private void GetAllDoctorList()
        {
            var doctorDb = new DoctorDb();
            cbDoctorName.DataSource = null;
            cbDoctorName.DataSource = new BindingSource(doctorDb.GetAllDoctorList(), null);

            cbDoctorName.DisplayMember = "Value"; // Doctor Name and Surname
            cbDoctorName.ValueMember = "Key"; // Doctor ID

        }
        private void GetAllPatient()
        {
            var patientDb = new PatientDb();
            patientDb.GetAllPatient();
            dgvPatient.DataSource = null;
            dgvPatient.DataSource = patientDb.GetAllPatient();
        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;

            var numberOfEffectedRow = 0;

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            if (string.IsNullOrEmpty(tbPatientCivilizationNumber.Text) || string.IsNullOrEmpty(tbPatientAge.Text) || string.IsNullOrEmpty(tbPatientName.Text) || string.IsNullOrEmpty(tbPatientSurname.Text))
            {
                MessageBox.Show("Please don't left empty places");
            }
            else if(cbPatientGender.SelectedIndex == 0 || cbDoctorName.SelectedIndex == 0 || cbDoctorDepartment.SelectedIndex == 0){
                MessageBox.Show("Please don't left selected default value");
            }
            else {
                // Patient Add
                if (string.IsNullOrEmpty(tbPatientId.Text))
                {
                    var patientDb = new PatientDb();
                    var patient = new Patient();
                    var doctor = new Doctor();
                    patient.CivilizationNumber = Convert.ToInt64(tbPatientCivilizationNumber.Text);
                    patient.Name = tbPatientName.Text;
                    patient.Surname = tbPatientSurname.Text;
                    patient.Age = Convert.ToInt32(tbPatientAge.Text);
                    patient.Gender = cbPatientGender.Text;
                    patient.Complaint = tbPatientComplaintDescription.Text;
                    patient.RegisterTime = dtpRegisterDate.Value;
                    doctor.ID = (int)cbDoctorName.SelectedValue;
                    patient = patientDb.AddNewPatient(patient, doctor);
                    numberOfEffectedRow++;
                }
                // Patient update
                else 
                {
                    var patientDb = new PatientDb();
                    var patient = new Patient();
                    var doctor = new Doctor();
                    patient.ID = Convert.ToInt32(tbPatientId.Text);
                    patient.CivilizationNumber = Convert.ToInt64(tbPatientCivilizationNumber.Text);
                    patient.Name = tbPatientName.Text;
                    patient.Surname = tbPatientSurname.Text;
                    patient.Age = Convert.ToInt32(tbPatientAge.Text);
                    patient.Gender = cbPatientGender.Text;
                    patient.Complaint = tbPatientComplaintDescription.Text;
                    patient.RegisterTime = dtpRegisterDate.Value;
                    doctor.ID = (int)cbDoctorName.SelectedValue;
                    patient = patientDb.UpdatePatient(patient,doctor);
                    numberOfEffectedRow++;
                }
                GetAllPatient();
                MessageBox.Show(numberOfEffectedRow > 0 ? "Success" : "Failed!");
                ChangeColumnsName();
                FormClear();
            }
        }
        private void dgvPatient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var id = dgvPatient.Rows[e.RowIndex].Cells["patientId"].Value.ToString();
                var patientCivilizationNumber = dgvPatient.Rows[e.RowIndex].Cells["patientCivilizationNumber"].Value.ToString();
                var patientName = dgvPatient.Rows[e.RowIndex].Cells["patientName"].Value.ToString();
                var patientSurname = dgvPatient.Rows[e.RowIndex].Cells["patientSurname"].Value.ToString();
                var patientAge = dgvPatient.Rows[e.RowIndex].Cells["patientAge"].Value.ToString();
                var patientGender = dgvPatient.Rows[e.RowIndex].Cells["patientGender"].Value.ToString();
                //var doctorName = dgvPatient.Rows[e.RowIndex].Cells["doctorName"].Value.ToString();
                //var doctorDepartment = dgvPatient.Rows[e.RowIndex].Cells["doctorDepartment"].Value.ToString();
                var patientComplaint = dgvPatient.Rows[e.RowIndex].Cells["patientComplaint"].Value.ToString();
                var patientRegisterTime = dgvPatient.Rows[e.RowIndex].Cells["patientRegisterTime"].Value;

                tbPatientId.Text = id;
                tbPatientCivilizationNumber.Text = patientCivilizationNumber;
                tbPatientName.Text = patientName;
                tbPatientSurname.Text = patientSurname;
                tbPatientAge.Text = patientAge;
                cbPatientGender.Text = patientGender;
                //cbDoctorName.Text = doctorName;
                //cbDoctorDepartment.Text = doctorDepartment;
                tbPatientComplaintDescription.Text = patientComplaint;
                dtpRegisterDate.Value = (DateTime)patientRegisterTime;
            }
        }
        //private void tbPatientCivilizationNumber_TextChanged(object sender, EventArgs e)
        //{
        //    dgvPatient.DataSource = patientList.Where(x => x.patientCivilizationNumber.ToString().Contains(tbPatientCivilizationNumber.Text)).ToList();
        //    changeColumnsName();
        //}
        private void tbPatientCivilizationNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbNumberController(e);
        }
        private void tbPatientAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbNumberController(e);
        }

        // Different for Textbox, Combobox etc fuction.

        public void ChangeColumnsName()//This function change datagridview columns name
        {
            dgvPatient.Columns[0].HeaderText = "ID";
            dgvPatient.Columns[1].HeaderText = "Patient Civilization Number";
            dgvPatient.Columns[2].HeaderText = "Patient Name";
            dgvPatient.Columns[3].HeaderText = "Patient Surname";
            dgvPatient.Columns[4].HeaderText = "Patient Age";
            dgvPatient.Columns[5].HeaderText = "Patient Gender";
            dgvPatient.Columns[6].HeaderText = "Patient Complaint";
            dgvPatient.Columns[7].HeaderText = "Patient Register Time";
            // Column 6 ve 7 çalışmıyor.
            //dgvPatient.Columns[6].HeaderText = "Patient Dr Name";
            //dgvPatient.Columns[7].HeaderText = "Patient Department";
            dgvPatient.Columns[8].HeaderText = "Patient Doctor ID";
        }
        public void FormClear() //This function clear all textbox and combobox
        {
            tbPatientId.Clear();
            tbPatientCivilizationNumber.Clear();
            tbPatientName.Clear();
            tbPatientSurname.Clear();
            tbPatientAge.Clear();
            dtpRegisterDate.Value = DateTime.Now;
            tbPatientComplaintDescription.Clear();
            cbPatientGender.SelectedIndex = 0;
            cbDoctorName.SelectedIndex = 0;
            cbDoctorDepartment.SelectedIndex = 0;
        }
        private void tbNumberController(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = !(char.IsDigit(e.KeyChar));
            }
        } //this function control it textbox number or not
    }
}
