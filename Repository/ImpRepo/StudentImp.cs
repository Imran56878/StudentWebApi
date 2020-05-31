using Model;
using Repository.DBContext;
using Repository.IRepo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ImpRepo
{
    public class StudentImp : IStudent
    {
        private readonly UserDbContext userDbContext;
        public StudentImp(UserDbContext userDbContext)
        {
            this.userDbContext = userDbContext;
        }

        public Task<int> AddStudentDetails(Student student)
        {
            userDbContext.StudentTable.Add(student);
            return userDbContext.SaveChangesAsync();
        }

        public IEnumerable<Student> GetAllStudentDetails()
        {
            return userDbContext.StudentTable;
        }

        public Student GetStudentDetails(int rollNumber)
        {
            Student student = userDbContext.StudentTable.Find(rollNumber);
            return student;
        }

        public IEnumerable<Student> GetStudentDetailsByClass(string className)
        {
            var result = userDbContext.StudentTable.Where(x => x.Class == className);
            return result;
        }

        public IEnumerable<Student> GetStudentDetailsByStream(string stream, string className)
        {
            var result = userDbContext.StudentTable.Where(x => (x.Class == className) && (x.Stream == stream));
            return result;
        }

        public Student RemoveStudentData(int rollNumber)
        {
            var result = userDbContext.StudentTable.Find(rollNumber);
            if (result != null)
            {
                userDbContext.StudentTable.Remove(result);
                userDbContext.SaveChanges();
            }
            return result;
        }

        public int TotalStudentRecord()
        {
            var count = userDbContext.StudentTable.Count<Student>();
            if (count != 0)
            {
                return count;
            }
            throw new Exception("No record Added");
        }

        public void RetrieveMultipleResults(SqlConnection connection)
        {
           
            using (connection)
            {
                SqlCommand command = new SqlCommand(
                  "SELECT CategoryID, CategoryName FROM dbo.Categories;" +
                  "SELECT EmployeeID, LastName FROM dbo.Employees",
                  connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.HasRows)
                {
                    Console.WriteLine("\t{0}\t{1}", reader.GetName(0),
                        reader.GetName(1));

                    while (reader.Read())
                    {
                        Console.WriteLine("\t{0}\t{1}", reader.GetInt32(0),
                            reader.GetString(1));
                    }
                    reader.NextResult();
                }
            }
        }
    }
}
