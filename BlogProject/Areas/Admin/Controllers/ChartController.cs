using BlogProject.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data;

namespace BlogProject.Areas.Admin.Controllers
{
	[Authorize(Roles = "Admin")]

	public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoryChart()
        {
            List<CategoryClass>list = new List<CategoryClass>();
            return View();
        }
    }
}
