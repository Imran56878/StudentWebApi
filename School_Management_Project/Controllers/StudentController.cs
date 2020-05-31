using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Manager.IManager;
using Microsoft.AspNetCore.Mvc;
using Model;
using Repository.IRepo;

namespace School_Management_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentManager manager;

        public StudentController(IStudentManager manager)
        {
            this.manager = manager;
        }

        [Route("AddStudentDetails")]
        [HttpPost]
        public async Task<IActionResult> AddStudentDetails(Student student)
        {
            var result = await this.manager.AddStudent(student);
            if (result == 1)
            {
                return this.Ok(student);
            }
            return this.BadRequest();
        }

        [Route("GetStudentDetail")]
        [HttpGet]
        public Student GetStudentDetail(int rollNumber)
        {
            return this.manager.GetStudent(rollNumber);
        }

        [Route("GetAllStudentDetails")]
        [HttpGet]
        public IEnumerable<Student> GetAllStudentDetails()
        {
            return this.manager.GetAllStudents();
        }
        [Route("GetAllStudentDetailsByClassName")]
        [HttpGet]
        public IEnumerable<Student> GetAllStudentDetailsByClassName(string className)
        {
            return this.manager.GetStudentDetailsByClass(className);
        }
        [Route("GetStudentDetailsByStream")]
        [HttpGet]
        public IEnumerable<Student> GetStudentDetailsByStream(string stream, string className)
        {
            return this.manager.GetStudentDetailsOfSameStream(stream, className);
        }

        [Route("GetStudentCount")]
        [HttpGet]
        public int GetStudentCount()
        {
            return this.manager.StudentCount();
        }
       [Route("RemoveStudentData")]
       [HttpDelete]
       public IActionResult RemoveStudentData(int rollNumber)
        {
            Student student = this.manager.RemoveStudentData(rollNumber);
            if (student != null)
            {
                return this.Ok(student);
            }
            return this.BadRequest();
        }

        [Route("RetrieveDataByDataReader")]
        [HttpGet]
        public int RetrieveDataByDataReader()
        {
            throw new NotImplementedException();
        }
    }
}
