using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepo
{
   public interface IStudent
    {
         Task<int> AddStudentDetails(Student student);
        Student GetStudentDetails(int rollNumber);
        IEnumerable<Student> GetAllStudentDetails();
        IEnumerable<Student> GetStudentDetailsByClass(string className);
        IEnumerable<Student> GetStudentDetailsByStream(string stream, string className);
        Student RemoveStudentData(int rollNumber);
        int TotalStudentRecord();
        void RetrieveMultipleResults(SqlConnection connection);
    }
}
