using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Manager.IManager
{
   public interface IStudentManager
    {
        Task<int> AddStudent(Student student);
        Student GetStudent(int rollNumber);
        IEnumerable<Student> GetAllStudents();
        IEnumerable<Student> GetStudentDetailsByClass(string className);
        IEnumerable<Student> GetStudentDetailsOfSameStream(string stream, string className);
        Student RemoveStudentData(int rollNumber);
        int StudentCount();
        void RetrieveMultipleResults(SqlConnection connection);
    }
}
