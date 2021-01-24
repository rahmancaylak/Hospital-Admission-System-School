using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalAdmissionSystem.DataLayer.Model;

namespace HospitalAdmissionSystem.DataLayer.DBOperations
{
    public class DoctorDb
    {
        public List<KeyValuePair<int, string>> GetAllDoctorList()
        {
            try
            {
                var con = DBHelper.GetConnectionString();
                var doctor = new Doctor();
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand("SELECT * FROM Doctor", con);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                doctor.doctorList.Add(new KeyValuePair<int, string>(0,"Select"));
                foreach (DataRow dr in tbl.Rows)
                {
                    doctor.doctorList.Add(new KeyValuePair<int, string>((int)dr["doctorId"], "Dr. " + (string)dr["doctorName"] + " " + (string)dr["doctorSurname"]));
                }
                return doctor.doctorList;
            }
            catch (Exception e)
            {
                Console.WriteLine("======== Hata Çıktısı ========\n " + e);
                throw;
            }
        }
    }
}
