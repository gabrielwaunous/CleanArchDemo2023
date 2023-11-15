using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.Mvc.Controllers
{
    public class CourseController : Controller
    {
        private ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        // GET: CourseController
        public ActionResult Index()
        {
            CourseViewModel model = _courseService.GetCourses();
            return View(model);
        }

    }
}
