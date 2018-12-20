using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IrishNationalStud.Data;
using IrishNationalStud.Models;
using IrishNationalStud.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IrishNationalStud.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminUsersController : Controller
    {

        private readonly ApplicationDbContext _db;

        public AdminUsersController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.ApplicationUser.ToList());
        }

        //Get Edit
        [Authorize(Roles = SD.SuperAdminEndUser)]
        public async Task<IActionResult> Edit(string id)
        {
            if(id==null || id.Trim().Length==0)
            {
                return NotFound();
            }

            var userFromDb = await _db.ApplicationUser.FindAsync(id);
            if(userFromDb==null)
            {
                return NotFound();
            }

            return View(userFromDb);
        }

        //POST Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(string id, ApplicationUser applicationUser)
        {
            if(id!=applicationUser.Id)
            {
                return NotFound();
            }

            if(ModelState.IsValid)
            {
                ApplicationUser userFromDb = _db.ApplicationUser.Where(u => u.Id == id).FirstOrDefault();
                userFromDb.Name = applicationUser.Name;
                userFromDb.PhoneNumber = applicationUser.PhoneNumber;

                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(applicationUser);
        }

        //Get Delete
        [Authorize(Roles = SD.SuperAdminEndUser)]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || id.Trim().Length == 0)
            {
                return NotFound();
            }

            var userFromDb = await _db.ApplicationUser.FindAsync(id);
            if (userFromDb == null)
            {
                return NotFound();
            }

            return View(userFromDb);
        }

        //POST Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(string id)
        {
            ApplicationUser userFromDb = _db.ApplicationUser.Where(u => u.Id == id).FirstOrDefault();
            userFromDb.LockoutEnd = DateTime.Now.AddYears(1000);

            _db.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
    }
}