using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Online_Shopping_Store.Data;
using Online_Shopping_Store.Models;

namespace Online_Shopping_Store.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SpecialTagController : Controller
    {
        private ApplicationDbContext _db = null;
        public SpecialTagController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var data = _db.specialTags.ToList();
            return View(data);
        }

        // Create Get Method
        public ActionResult Create()
        {
            return View();
        }
        // Create Post Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SpecialTag specialTag)
        {
            if (ModelState.IsValid)
            {
                _db.specialTags.Add(specialTag);
                await _db.SaveChangesAsync();
                TempData["save"] = "Data has been Saved Successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(specialTag);
        }

        // Edit Get Method
        public ActionResult Edit(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            var specialTag = _db.specialTags.Find(id);

            if (specialTag == null)
            {
                return NotFound();
            }

            return View(specialTag);
        }
        // Edit Post Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(SpecialTag specialTag)
        {
            if (ModelState.IsValid)
            {
                _db.Update(specialTag);
                await _db.SaveChangesAsync();
                TempData["edit"] = "Data has been Updated Successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(specialTag);
        }

        // Details Get Method
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var specialTag = _db.specialTags.Find(id);

            if (specialTag == null)
            {
                return NotFound();
            }

            return View(specialTag);
        }
        // Delete Get Action Method
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var specialTag = _db.specialTags.Find(id);
            if (specialTag == null)
            {
                return NotFound();
            }

            return View(specialTag);
        }

        // Delete Post Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id, SpecialTag specialTag)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (id != specialTag.Id)
            {
                return NotFound();
            }
            var speTag = _db.specialTags.Find(id);
            if (speTag == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _db.Remove(speTag);
                await _db.SaveChangesAsync();
                TempData["delete"] = "Data has been Deleted Successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(specialTag);
        }

    }
}
