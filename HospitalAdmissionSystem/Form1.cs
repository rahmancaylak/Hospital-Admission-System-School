using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAdmissionSystem
{
    public partial class Form1 : Form
    {
        List<Patients> patientList = new List<Patients>(); // This list hold patient information.
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbDoctorName.SelectedIndex = 0;
            cbDoctorDepartment.SelectedIndex = 0;
            cbPatientGender.SelectedIndex = 0;
        }
        private int getLastId(bool _inc = false) //This function return increase id automatically.
        {
            if (patientList.Count > 0)
            {
                var patient = patientList.Last();
                if (_inc)
                {
                    return patient.patientId + 1;
                }
                return patient.patientId;
            }
            if (_inc)
            {
                return 1;
            }
            return 0;
        }
        private Patients GetPatients(int _id)
        {
            var patient = patientList.FirstOrDefault(s => s.patientId == _id);
            return patient;
        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbPatientCivilizationNumber.Text) || string.IsNullOrEmpty(tbPatientAge.Text) || string.IsNullOrEmpty(tbPatientName.Text) || string.IsNullOrEmpty(tbPatientSurname.Text))
            {
                MessageBox.Show("Please don't left empty places");
            }
            else if(cbPatientGender.SelectedIndex == 0 || cbDoctorName.SelectedIndex == 0 || cbDoctorDepartment.SelectedIndex == 0){
                MessageBox.Show("Please don't left selected default value");
            }
            else {
            var patient = new Patients();

            if (string.IsNullOrEmpty(tbPatientId.Text))
            {
                    patient = new Patients()
                    {
                        patientId = getLastId(true),
                        patientCivilizationNumber = Convert.ToInt64(tbPatientCivilizationNumber.Text),
                        patientName = tbPatientName.Text,
                        patientSurname = tbPatientSurname.Text,
                        patientAge = Convert.ToInt32(tbPatientAge.Text),
                        patientGender = cbPatientGender.Text,
                        doctorName = cbDoctorName.Text,
                        doctorDepartment = cbDoctorDepartment.Text,
                        patientComplaintDescription = tbPatientComplaintDescription.Text,
                        patientDateTime = dateTimePicker1.Value
                    };
                    //Overloading Patient constructor and set get data in Patient class
                    patientList.Add(patient);
            }
            else
            {
                patient = GetPatients(Convert.ToInt32(tbPatientId.Text));
                if (patient != null)
                {
                    patient.patientId = getLastId(true);
                    patient.patientCivilizationNumber = Convert.ToInt64(tbPatientCivilizationNumber.Text);
                    patient.patientName = tbPatientName.Text;
                    patient.patientSurname = tbPatientSurname.Text;
                    patient.patientAge = Convert.ToInt32(tbPatientAge.Text);
                    patient.patientGender = cbPatientGender.Text;
                    patient.doctorName = cbDoctorName.Text;
                    patient.doctorDepartment = cbDoctorDepartment.Text;
                    patient.patientComplaintDescription = tbPatientComplaintDescription.Text;
                    patient.patientDateTime = dateTimePicker1.Value;
                }
            }
            dgvPatient.DataSource = null;
            dgvPatient.DataSource = patientList;
            changeColumnsName();
            formClear();
            }
        }
        private void dgvPatient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//When datagridview column select, you can change data with form
        {

            if (e.RowIndex > -1)
            {
                var id = dgvPatient.Rows[e.RowIndex].Cells["patientId"].Value.ToString();
                var patientCivilizationNumber = dgvPatient.Rows[e.RowIndex].Cells["patientCivilizationNumber"].Value.ToString();
                var patientName = dgvPatient.Rows[e.RowIndex].Cells["patientName"].Value.ToString();
                var patientSurname = dgvPatient.Rows[e.RowIndex].Cells["patientSurname"].Value.ToString();
                var patientAge = dgvPatient.Rows[e.RowIndex].Cells["patientAge"].Value.ToString();
                var patientGender = dgvPatient.Rows[e.RowIndex].Cells["patientGender"].Value.ToString();
                var doctorName = dgvPatient.Rows[e.RowIndex].Cells["doctorName"].Value.ToString();
                var doctorDepartment = dgvPatient.Rows[e.RowIndex].Cells["doctorDepartment"].Value.ToString();
                var patientComplaintDescription = dgvPatient.Rows[e.RowIndex].Cells["patientComplaintDescription"].Value.ToString();
                var patientDateTime = dgvPatient.Rows[e.RowIndex].Cells["patientDateTime"].Value;

                tbPatientId.Text = id;
                tbPatientCivilizationNumber.Text = patientCivilizationNumber;
                tbPatientName.Text = patientName;
                tbPatientSurname.Text = patientSurname;
                tbPatientAge.Text = patientAge;
                cbPatientGender.Text = patientGender;
                cbDoctorName.Text = doctorName;
                cbDoctorDepartment.Text = doctorDepartment;
                tbPatientComplaintDescription.Text = patientComplaintDescription;
                dateTimePicker1.Value = (DateTime)patientDateTime;
            }
        }
        private void tbPatientCivilizationNumber_TextChanged(object sender, EventArgs e)
        {
            dgvPatient.DataSource = patientList.Where(x => x.patientCivilizationNumber.ToString().Contains(tbPatientCivilizationNumber.Text)).ToList();
            changeColumnsName();
        }
        private void tbPatientCivilizationNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbNumberController(e);
        }
        private void tbPatientAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbNumberController(e);
        }

        // Different for Textbox, Combobox etc fuction.

        public void changeColumnsName()//This function change datagridview columns name
        {
            dgvPatient.Columns[0].HeaderText = "ID";
            dgvPatient.Columns[1].HeaderText = "Patient Civilization Number";
            dgvPatient.Columns[2].HeaderText = "Patient Name";
            dgvPatient.Columns[3].HeaderText = "Patient Surname";
            dgvPatient.Columns[4].HeaderText = "Patient Age";
            dgvPatient.Columns[5].HeaderText = "Patient Gender";
            dgvPatient.Columns[6].HeaderText = "Patient Dr Name";
            dgvPatient.Columns[7].HeaderText = "Patient Department";
            dgvPatient.Columns[8].HeaderText = "Patient Complaint";
            dgvPatient.Columns[9].HeaderText = "Patient Register Time";
        }
        public void formClear() //This function clear all textbox
        {
            tbPatientId.Clear();
            tbPatientCivilizationNumber.Clear();
            tbPatientName.Clear();
            tbPatientSurname.Clear();
            tbPatientAge.Clear();
            dateTimePicker1.Value = DateTime.Now;
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
