using introAPI2.Models;
using introAPI2.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace introAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private StudentsService _studentService;

        public StudentsController(StudentsService service)
        {
            _studentService = service;
        }

        [HttpPost]
        public ActionResult<short> CreateStudent(Students student)
        {
            _studentService.AddStudent(student);

            return Ok(student);
        }

        [HttpGet]
        public ActionResult<List<Students>> GetStudent()
        {
            return Ok(_studentService.GetStudent());
        }/*
        [HttpPut]
        public ActionResult<Students> UpdateStudent(int id, Students students)
        {
            _studentService.UpdateStudent(id, students);
            return students;
        }
        [HttpDelete]
        public ActionResult<int> DeleteStudent(int id)
        {
            _studentService.DeleteStudent(id);
            return id;
        }*/
    }
}
