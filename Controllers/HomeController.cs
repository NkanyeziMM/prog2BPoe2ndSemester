using CMcs.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CMcs.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
 
        public IActionResult ViewsLecturerIndex()
        {
            return View();
        }

        public IActionResult ViewsLecturerEdit()
        {
            return View();
        }
        public IActionResult ViewsLecturerDelete()
        {
            return View();
        }
        public IActionResult ViewsLecturerDetails()
        {
            return View();
        }
       
             public IActionResult ViewsLecturerCreate()
        {
            return View();
        }
        public IActionResult ViewsClaimIndex()
        {
            return View();
        }
        public IActionResult ViewsClaimCreate()
        {
            return View();
        }
        public IActionResult ViewsClaimEdit()
        {
            return View();
        }
        public IActionResult ViewsClaimDetails()
        {
            return View();
        }
        public IActionResult ViewsClaimDelete()
        {
            return View();
        }

        public IActionResult Views_ProgramCoordinator_Index()
        {
            return View();
        }
        public IActionResult Views_ProgramCoordinator_Edit()
        {
            return View();
        }
        public IActionResult Views_ProgramCoordinator_Details()
        {
            return View();
        }
        public IActionResult Views_ProgramCoordinator_Delete()
        {
            return View();
        }
        public IActionResult Views_ProgramCoordinator_Create()
        {
            return View();
        }
        public IActionResult Views_AcademicManager_Create()
        {
            return View();
        }
        public IActionResult Views_AcademicManager_Delete()
        {
            return View();
        }
        public IActionResult Views_AcademicManager_Details()
        {
            return View();
        }
        public IActionResult Views_AcademicManager_Edit()
        {
            return View();
        }
        public IActionResult Views_AcademicManager_Index()
        {
            return View();
        }
        public IActionResult Views_SupportingDocument_Create()
        {
            return View();
        }
        public IActionResult Views_SupportingDocument_Delete()
        {
            return View();
        }
        public IActionResult Views_SupportingDocument_Details()
        {
            return View();
        }
        public IActionResult Views_SupportingDocument_Edit()
        {
            return View();
        }
        public IActionResult Views_SupportingDocument_Index()
        {
            return View();
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
