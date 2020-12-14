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
        List<Patient> patientList = new List<Patient>();
        public Form1()
        {
            InitializeComponent();
        }
        private int getLastId(bool _inc = false)
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
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var patient = new Patient()
            {
                patientId = getLastId(true),
                patientIdentification = Convert.ToInt32(tbPatientIdentification.Text),
                patientName = tbPatientName.Text,
                patientSurname = tbPatientSurname.Text,
                patientAge = Convert.ToInt32(tbPatientAge.Text),
                patientGender = cbPatientGender.Text,
                patientDrName = cbPatientDrName.Text,
                patientDepartment = cbPatientDepartment.Text,
                patientDateTime = dateTimePicker1.Value
            };
            patientList.Add(patient);

            dgvPatient.DataSource = null;
            dgvPatient.DataSource = patientList;
            changeColumnsName();
            patientTextboxClear();
        }
        public void changeColumnsName()
        {
            dgvPatient.Columns[0].HeaderText = "ID";
            dgvPatient.Columns[1].HeaderText = "Patient Identication ID";
            dgvPatient.Columns[2].HeaderText = "Patient Name";
            dgvPatient.Columns[3].HeaderText = "Patient Surname";
            dgvPatient.Columns[4].HeaderText = "Patient Age";
            dgvPatient.Columns[5].HeaderText = "Patient Gender";
            dgvPatient.Columns[6].HeaderText = "Patient Dr Name";
            dgvPatient.Columns[7].HeaderText = "Patient Department";
            dgvPatient.Columns[8].HeaderText = "Patient Register Time";
        } //This function change datagridview columns name
        public void patientTextboxClear() //This function clear all textbox
        {
            tbPatientId.Clear();
            tbPatientIdentification.Clear();
            tbPatientName.Clear();
            tbPatientSurname.Clear();
            tbPatientAge.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
