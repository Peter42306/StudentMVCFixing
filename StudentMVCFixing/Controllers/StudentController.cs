using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentMVCFixing.Models;

namespace StudentMVCFixing.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentContext _studentContext;

        public StudentController(StudentContext studentContext)
        {
            _studentContext = studentContext;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Student>students=await _studentContext.Students.ToListAsync();
            ViewBag.Students = students;
            return View();
        }        
    }
}
