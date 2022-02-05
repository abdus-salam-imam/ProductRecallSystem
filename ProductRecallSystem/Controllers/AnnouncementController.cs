using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProductRecallSystem.Data;
using ProductRecallSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductRecallSystem.Controllers
{
    public class AnnouncementController : Controller
    {
        MyDbContext _context = new MyDbContext();
        public IActionResult Index()
        {
            var obj = _context.Announcements.Include(x=>x.Recall).ToList();
            return View(obj);
        }

        [HttpGet]
        public IActionResult CreateOrEdit(int id)

        {


            Announcement obj = new Announcement();
            if (id > 0)
            {
                obj = _context.Announcements.Find(id);
            }

            ViewBag.RecallList = new SelectList(_context.Recalls.ToList(),"RecallId","Description");

            return View(obj);
        }

        [HttpPost]
        public IActionResult CreateOrEdit(Announcement model)
        {


            if (ModelState.IsValid)
            {
                if (model.AnnouncementId > 0)
                {
                    _context.Announcements.Update(model);

                }
                else
                {
                    _context.Announcements.Add(model);
                }
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));

            }


            else
            {
                return View();
            }

        }





    }
}
