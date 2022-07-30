using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentAdminPortal.DataModels;
using StudentAdminPortal.Repositories;
using System.Collections.Generic;

namespace StudentAdminPortal.Controllers
{   [Route("api/Students")]
    [ApiController]
    public class StudentsController : Controller
    {
        private readonly IStudentRepository studentRepository;
        private readonly IMapper mapper;

        public StudentsController(IStudentRepository studentRepository,IMapper mapper)
        {
            this.studentRepository = studentRepository;
            this.mapper = mapper;
        }
        [HttpGet]
        //[Route("[controller]")]
        public IActionResult GetAllStudent()
        {
            var students = studentRepository.GetStudents();

            return Ok(mapper.Map<List<Student>>(students));
               
            }
           
        }
    
}
