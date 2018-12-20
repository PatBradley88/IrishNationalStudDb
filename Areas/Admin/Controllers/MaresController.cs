﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IrishNationalStud.Data;
using IrishNationalStud.Models;
using IrishNationalStud.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IrishNationalStud.Controllers
{
    [Area("Admin")]
    public class MaresController : Controller
    {

            private readonly ApplicationDbContext _db;

            public MaresController(ApplicationDbContext db)
            {
                _db = db;
            }



            public IActionResult Index()
            {
                return View(_db.Mares.ToList());
            }

            //GET Create action method
            public IActionResult Create()
            {
                return View();
            }

            //POST Create action method
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Create(Mares mares)
            {
                if (ModelState.IsValid)
                {
                    _db.Add(mares);
                    await _db.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(mares);
            }


            //GET Edit Action Method
            public async Task<IActionResult> Edit(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var mares = await _db.Mares.FindAsync(id);
                if (mares == null)
                {
                    return NotFound();
                }

                return View(mares);
            }

            //POST Edit action method
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Edit(int id, Mares mares)
            {
                if (id != mares.Id)
                {
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    _db.Update(mares);
                    await _db.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(mares);
            }


            //GET Details Action Method
            public async Task<IActionResult> Details(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var mares = await _db.Mares.FindAsync(id);
                if (mares == null)
                {
                    return NotFound();
                }

                return View(mares);
            }

            //POST Details action method
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Details(int id, Mares mares)
            {
                if (id != mares.Id)
                {
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    _db.Update(mares);
                    await _db.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(mares);
            }

        //GET Delete Action Method
        [Authorize(Roles = SD.SuperAdminEndUser)]
        public async Task<IActionResult> Delete(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var mares = await _db.Mares.FindAsync(id);
                if (mares == null)
                {
                    return NotFound();
                }

                return View(mares);
            }

        //POST Delete action method
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Delete(int id)
            {
                var mares = await _db.Mares.FindAsync(id);
                _db.Mares.Remove(mares);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

        }
    }