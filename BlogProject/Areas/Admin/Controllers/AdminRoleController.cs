using BlogProject.Areas.Admin.Models;
using EntitylayerCore.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Areas.Admin.Controllers
{
    [Area("Admin")]

    //[Route("Admin/Role")]
    [Authorize(Roles = "Admin")]
    public class AdminRoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;

        public AdminRoleController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }
        [Route("Admin/[controller]/[action]")]

        public IActionResult Index()
        {
            var values = _roleManager.Roles.ToList();
            return View(values);
        }
        [HttpGet]

        public IActionResult CreateRole()
        {
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> CreateRole(CreateRoleViewModel createRoleViewModel)
        {
            AppRole role = new AppRole()
            {
                Name = createRoleViewModel.RoleName
            };
            var result = await _roleManager.CreateAsync(role);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        [Route("Admin/[controller]/[action]/{id}")]

        public async Task<IActionResult> DeleteRole(int id)
        {
            var value = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            await _roleManager.DeleteAsync(value);
            return RedirectToAction("Index");
        }
        

        [HttpGet]
        public IActionResult UpdateRole(int id)
        {
            var value = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            UpdateRoleViewModel updateRoleViewModel = new UpdateRoleViewModel
            {
                RoleID = value.Id,
                RoleName = value.Name
            };
            return View(updateRoleViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateRole(UpdateRoleViewModel updateRoleViewModel)
        {
            var value = _roleManager.Roles.FirstOrDefault(x => x.Id == updateRoleViewModel.RoleID);
            value.Name = updateRoleViewModel.RoleName;
            await _roleManager.UpdateAsync(value);
            return RedirectToAction("Index");
        }
        [Route("Admin/[controller]/[action]")]

        public IActionResult UserList()
        {
            var values = _userManager.Users.ToList();
            return View(values);
        }
        [HttpGet]
        [Route("Admin/[controller]/[action]/{id}")]
        [Route("Admin/Role")]
        public async Task<IActionResult> AssignRole(int id)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
            TempData["Userid"] = user.Id;
            var roles = _roleManager.Roles.ToList();
            var userRoles = await _userManager.GetRolesAsync(user);
            List<RoleAssignViewModel> roleAssignViewModels = new List<RoleAssignViewModel>();
            foreach (var item in roles)
            {
                RoleAssignViewModel model = new RoleAssignViewModel();
                model.RoleId = item.Id;
                model.RoleName = item.Name;
                model.RoleExist = userRoles.Contains(item.Name);
                roleAssignViewModels.Add(model);
            }
            return View(roleAssignViewModels);
        }
        [HttpPost]
        [Route("Admin/[controller]/[action]/{id}")]
        [Route("Admin/Role")]
        public async Task<IActionResult> AssignRole( List<RoleAssignViewModel> model)
        {

            var userid = (int)TempData["userid"];
            var user = _userManager.Users.FirstOrDefault(x => x.Id == userid);
            foreach (var item in model)
            {
                if (item.RoleExist)
                {
                    await _userManager.AddToRoleAsync(user, item.RoleName);
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user, item.RoleName);
                }
            }
            return RedirectToAction("UserList");
        }

    }
}

