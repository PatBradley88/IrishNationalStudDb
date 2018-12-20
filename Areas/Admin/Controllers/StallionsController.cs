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
    public class StallionsController : Controller
    {

        private readonly ApplicationDbContext _db;

        public StallionsController( ApplicationDbContext db)
        {
            _db = db;
        }



        public IActionResult Index()
        {
            return View(_db.Stallions.ToList());
        }

        //GET Create action method
        public IActionResult Create()
        {
            return View();
        }

        //POST Create action method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Stallions stallions)
        {
            if (ModelState.IsValid)
            {
                _db.Add(stallions);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stallions);
        }


        //GET Edit Action Method
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stallions = await _db.Stallions.FindAsync(id);
            if (stallions == null)
            {
                return NotFound();
            }

            return View(stallions);
        }

        //POST Edit action method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Stallions stallions)
        {
            if (id != stallions.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _db.Update(stallions);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stallions);
        }


        //GET Details Action Method
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stallions = await _db.Stallions.FindAsync(id);
            if (stallions == null)
            {
                return NotFound();
            }

            return View(stallions);
        }

        //POST Details action method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Details(int id, Stallions stallions)
        {
            if (id != stallions.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _db.Update(stallions);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stallions);
        }

        //GET Delete Action Method
        [Authorize(Roles = SD.SuperAdminEndUser)]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stallions = await _db.Stallions.FindAsync(id);
            if (stallions == null)
            {
                return NotFound();
            }

            return View(stallions);
        }

        //POST Delete action method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var stallions = await _db.Stallions.FindAsync(id);
            _db.Stallions.Remove(stallions);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}