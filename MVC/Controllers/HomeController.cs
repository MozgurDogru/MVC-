using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System.Diagnostics;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()//action Method deniliyor.
        {
            Student student1 = new Student()
            {
                Name = "Ali",
                Surname = "Veli",
                Number = 122
            };
            Teacher teacher1 = new Teacher() { ID= 23,Name="Emre Hoca",Phone="2233444",Address="KSK" };

            //Viewmodel Yöntemi

            //TeacherStudent teacherStudent = new TeacherStudent { student= student1,teacher=teacher1 };

            //Tuple
            var tuple = (teacher1, student1);
            return View(tuple);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}