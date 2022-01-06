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
    public class ProductController : Controller
    {
        MyDbContext _context = new MyDbContext();
        public IActionResult Index()
        {
            var obj = _context.Products.Include(x=>x.Manufacturer).ToList();
            return View(obj);
        }

        [HttpGet]
        public IActionResult CreateOrEdit(int id)
        {
            Product obj = new Product();
            if (id > 0)
            {
                obj = _context.Products.Find(id);
            }



            //Manufacturer DropDown List 

            var manufacturerList = new SelectList(_context.Manufacturers.ToList(), "ManufacturerId", "Name");

            obj.ManufacuturerList = manufacturerList;

            return View(obj);
        }


        [HttpPost]
        public IActionResult CreateOrEdit(Product model)
        {

            if (ModelState.IsValid)
            {
                if (model.ProductId > 0)
                {
                    _context.Products.Update(model);

                }
                else
                {
                    _context.Products.Add(model);
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
