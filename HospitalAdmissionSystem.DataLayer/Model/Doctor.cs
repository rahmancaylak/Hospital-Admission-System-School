using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAdmissionSystem.DataLayer.Model
{
    public class Doctor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int MyProperty { get; set; }
        public List<KeyValuePair<int, string>> doctorList = new List<KeyValuePair<int, string>>();

    }
}
