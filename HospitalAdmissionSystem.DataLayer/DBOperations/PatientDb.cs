using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalAdmissionSystem.DataLayer.Model;
using System.Data;


namespace HospitalAdmissionSystem.DataLayer.DBOperations
{
    public class PatientDb
    {

       // TO DO: Doktor ile ilgili işlemler yapılması gerekiyor.
        public int numberOfEffectedRow;
       
        public DataTable GetAllPatient()
        {
            try
            {
                var con = DBHelper.GetConnectionString();
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand("SELECT * FROM Patient", con);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                return tbl;
            }
            catch (Exception e)
            {
                Console.WriteLine("======== Hata Çıktısı ========\n " + e);
                throw;
            }
        }
        public Patient AddNewPatient(Patient _patient, Doctor _doctor)
        {
            try
            {
                var con = DBHelper.GetConnectionString();
                string insertQuery = @"INSERT INTO [Patient]
                                  (
                                      [patientCivilizationNumber]
                                     ,[patientName]
                                     ,[patientSurname]
                                     ,[patientAge]
                                     ,[patientGender]
                                     ,[patientComplaint]
                                     ,[patientRegisterTime]
                                     ,[doctorId]
                                  )
                                VALUES
                                    (
                                      @CivilizationNumber,
                                      @Name,
                                      @Surname,
                                      @Age,
                                      @Gender,
                                      @Complaint,
                                      @RegisterTime,
                                      @DoctorID
                                    )";

                SqlCommand cmdInsert = new SqlCommand();
                cmdInsert.CommandText = insertQuery;
                cmdInsert.Connection = con;

                cmdInsert.Parameters.AddWithValue("@CivilizationNumber", _patient.CivilizationNumber);
                cmdInsert.Parameters.AddWithValue("@Name", _patient.Name);
                cmdInsert.Parameters.AddWithValue("@Surname", _patient.Surname);
                cmdInsert.Parameters.AddWithValue("@Age", _patient.Age);
                cmdInsert.Parameters.AddWithValue("@Gender", _patient.Gender);
                cmdInsert.Parameters.AddWithValue("@Complaint", _patient.Complaint);
                cmdInsert.Parameters.AddWithValue("@RegisterTime", _patient.RegisterTime);
                cmdInsert.Parameters.AddWithValue("@DoctorID", _doctor.ID);
                numberOfEffectedRow = cmdInsert.ExecuteNonQuery();

                if (numberOfEffectedRow > 0)
                {

                    SqlCommand cmd = new SqlCommand("SELECT TOP 1 patientId FROM Patient ORDER BY patientId DESC", con);
                    var idObj = cmd.ExecuteScalar();
                    long id = 0;
                    if (Int64.TryParse(idObj.ToString(), out id))

                    {
                        _patient.ID = id;
                        return _patient;
                    }
                }

                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine("======== Hata Çıktısı ========\n "+e);
                throw;
            }
        }

        public Patient UpdatePatient(Patient _patient, Doctor _doctor)
        {
            numberOfEffectedRow = 0;
            try
            {
                var con = DBHelper.GetConnectionString();
                string updateCommand = @"
                                            UPDATE Patient
                                            SET patientCivilizationNumber = @CivilizationNumber,
                                                patientName = @Name,
                                                patientSurname = @Surname,
                                                patientAge = @Age,
                                                patientGender = @Gender,
                                                patientComplaint = @Complaint,
                                                patientRegisterTime = @RegisterTime,
                                                doctorId = @DoctorID
                                    WHERE patientId = @ID ";

                SqlCommand cmd = new SqlCommand(updateCommand, con);

                cmd.Parameters.AddWithValue("@CivilizationNumber", _patient.CivilizationNumber);
                cmd.Parameters.AddWithValue("@Name", _patient.Name);
                cmd.Parameters.AddWithValue("@Surname", _patient.Surname);
                cmd.Parameters.AddWithValue("@Age", _patient.Age);
                cmd.Parameters.AddWithValue("@Gender", _patient.Gender);
                cmd.Parameters.AddWithValue("@Complaint", _patient.Complaint);
                cmd.Parameters.AddWithValue("@RegisterTime", _patient.RegisterTime);
                cmd.Parameters.AddWithValue("@DoctorID", _doctor.ID);
                cmd.Parameters.AddWithValue("@ID", _patient.ID);

                var numberOfUpdatedRow = cmd.ExecuteNonQuery();

                if (numberOfUpdatedRow > 0)
                {
                    return _patient;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("======== Hata Çıktısı ========\n" + e);
                throw;
            }
        }
    }
}
