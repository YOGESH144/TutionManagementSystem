using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TutionManagementSystem.Data;
using TutionManagementSystem.Models;

namespace TutionManagementSystem.Controllers
{
    public class RolesController : Controller
    {
        //private readonly ApplicationDbContext _context;
        private readonly RoleManager<IdentityRole> roleManager;

        public RolesController(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var roleList = roleManager.Roles;
            return View(roleList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            //var role = new IdentityRole();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateRoleViewModel model)
        {

            if (ModelState.IsValid)
            {
                IdentityRole identity = new IdentityRole
                {
                    Name = model.RoleName
                };
                IdentityResult result = await roleManager.CreateAsync(identity);
                if(result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                foreach(IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }
    }
}