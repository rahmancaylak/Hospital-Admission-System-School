using System;

namespace HospitalAdmissionSystem
{
    class Patients
    {
        //Patient Information Variables
        public int patientId { get; set; }
        public long patientCivilizationNumber { get; set; }
        public string patientName { get; set; }
        public string patientSurname { get; set; }
        public int patientAge { get; set; }
        public string patientGender { get; set; }
        public string doctorName { get; set; }
        public string doctorDepartment { get; set; }
        public string patientComplaintDescription { get; set; }
        public DateTime patientDateTime { get; set; }
        //Constructor
        public Patients(){}

        //Overloading
        public Patients(int _id, int _civilizationNumber, string _name, string _surname, int _age, string _gender, string _drName, string _department, string _complaintDescription, DateTime _dateTime)
        {
            this.patientId = _id;
            this.patientCivilizationNumber = _civilizationNumber;
            this.patientName = _name;
            this.patientSurname = _surname;
            this.patientAge = _age;
            this.patientGender = _gender;
            this.doctorName = _drName;
            this.doctorDepartment = _department;
            this.patientComplaintDescription = _complaintDescription;
            this.patientDateTime = _dateTime;
        }
    }
}
