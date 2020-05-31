using Manager.IManager;
using Model;
using Repository.IRepo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ImpManager
{
    public class ImpStudentManager : IStudentManager
    {
        private readonly IStudent repo;
        public ImpStudentManager(IStudent repo)
        {
            this.repo = repo;
        }

        public Task<int> AddStudent(Student student)
        {
            return this.repo.AddStudentDetails(student);
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return this.repo.GetAllStudentDetails();
        }

        public Student GetStudent(int rollNumber)
        {
            return this.repo.GetStudentDetails(rollNumber);
        }

        public IEnumerable<Student> GetStudentDetailsByClass(string className)
        {
            return this.repo.GetStudentDetailsByClass(className);
        }

        public IEnumerable<Student> GetStudentDetailsOfSameStream(string stream, string className)
        {
            return this.repo.GetStudentDetailsByStream(stream, className);
        }

        public Student RemoveStudentData(int rollNumber)
        {
            return this.repo.RemoveStudentData(rollNumber);
        }

        public void RetrieveMultipleResults(SqlConnection connection)
        {
             this.repo.RetrieveMultipleResults(connection);
        }

        public int StudentCount()
        {
            return this.repo.TotalStudentRecord();
        }
    }
}
