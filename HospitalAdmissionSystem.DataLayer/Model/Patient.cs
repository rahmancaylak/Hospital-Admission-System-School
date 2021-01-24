using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAdmissionSystem.DataLayer.Model
{
    public class Patient
    {
        //Patient Information
        public long ID { get; set; }
        public long CivilizationNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Complaint { get; set; }
        public DateTime RegisterTime { get; set; }
    }
}
