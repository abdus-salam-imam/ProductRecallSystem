using Microsoft.AspNetCore.Mvc;
using ProductRecallSystem.Data;
using ProductRecallSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductRecallSystem.Controllers
{
    public class ManufacturerController : Controller
    {
        MyDbContext _context = new MyDbContext();
        public IActionResult Index()
        {
            var list = _context.Manufacturers.ToList();

            return View(list);
        }


        [HttpGet]
        public IActionResult CreateOrEdit(int id)
        {
            Manufacturer obj = new Manufacturer();
            if (id > 0)
            {
                obj = _context.Manufacturers.Find(id); 
            }

            return View(obj);
        }


        [HttpPost]
        public IActionResult CreateOrEdit(Manufacturer model)
        {

            if (ModelState.IsValid)
            {
                if (model.ManufacturerId > 0)
                {
                    _context.Manufacturers.Update(model);
                }
                else
                {
                    _context.Manufacturers.Add(model);
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
