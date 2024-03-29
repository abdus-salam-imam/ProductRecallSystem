﻿using Microsoft.AspNetCore.Mvc;
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
    public class RecallController : Controller
    {
        MyDbContext _context = new MyDbContext();
        public IActionResult Index()
        {
            var obj = _context.Recalls.Include(x=>x.Product).Include(x=>x.Manufacturer).ToList();
            return View(obj);
        }

        [HttpGet]
        public IActionResult CreateOrEdit(int id)
        
       {
            

            Recall obj = new Recall();
            if (id > 0)
            {
                obj = _context.Recalls.Find(id);

                
            }

            var manufacturerList = new SelectList(_context.Manufacturers.ToList(), "ManufacturerId", "Name");
            obj.ManufactureList = manufacturerList;

            


            return View(obj);
        }


        [HttpPost]
        public IActionResult CreateOrEdit(Recall model)
        {
                     
          
            if (ModelState.IsValid)
            {
                if (model.RecallId > 0)
                {
                    _context.Recalls.Update(model);

                }
                else
                {
                    _context.Recalls.Add(model);
                }
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));

            }


            else
            {
                return View();
            }

        }


        public IActionResult Delete(int id)
        {

            var recall = _context.Recalls.Find(id);
            _context.Recalls.Remove(recall);
            _context.SaveChanges();


            return RedirectToAction(nameof(Index));
        }


        public JsonResult GetManufacturers()
        {
            var Manufacturerlist = _context.Manufacturers.ToList();

            return Json(Manufacturerlist);
        }

        public JsonResult GetProducts()
        {
            
            var Productlist = _context.Products.ToList();

            return Json(Productlist);
        }


        public JsonResult GetproductList(int ManufacturerId)
        {

           List<Product> ProductList = _context.Products.Where(x => x.ManufacturerId == ManufacturerId).ToList();
            
            return Json(ProductList);
        }

    }
}
