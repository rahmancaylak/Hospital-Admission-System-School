using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAdmissionSystem
{
    class Patient
    {
        //Patient Information Variables
        public int patientId { get; set; }
        public int patientIdentification { get; set; }
        public string patientName { get; set; }
        public string patientSurname { get; set; }
        public int patientAge { get; set; }
        public string patientGender { get; set; }
        public string patientDrName { get; set; }
        public string patientDepartment { get; set; }
        public DateTime patientDateTime { get; set; }

        //Constructor
        public Patient()
        {
        }

        //Overloading
        public Patient(int _id, int _identification, string _name, string _surname, int _age, string _gender, string _drName,string _department, DateTime _dateTime)
        {
            this.patientId = _id;
            this.patientIdentification = _identification;
            this.patientName = _name;
            this.patientSurname = _surname;
            this.patientAge = _age;
            this.patientGender = _gender;
            this.patientDrName = _drName;
            this.patientDepartment = _department;
            this.patientDateTime = _dateTime;
        }
    }
}
