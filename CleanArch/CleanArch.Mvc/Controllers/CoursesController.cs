using Microsoft.AspNetCore.Mvc;

using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace CleanArch.Mvc.Controllers
{
    [Authorize]
    public class CoursesController : Controller
    {
        private ICourseService _service;
        public CoursesController(ICourseService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            CourseViewModel model = _service.GetCourses();
            return View(model);
        }
    }
}
