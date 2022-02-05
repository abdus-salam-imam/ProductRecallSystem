using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            var list = _context.Manufacturers.Include(x=>x.Products)
                .Select(y=> new Manufacturer
                {
                ManufacturerId = y.ManufacturerId,
                Name=y.Name,
                City=y.City,
                Address=y.Address,
                State=y.State,
                ZipCode=y.ZipCode,
                
                    Products=y.Products.Select(m=> new Product {
                    
                    ProductId=m.ProductId,
                    Name=m.Name,
                    Price=m.Price


                })

                })
                
                .ToList();


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
            try
            {
                if (ModelState.IsValid)
                {
                    if (model.ManufacturerId > 0) //Update
                    {
                        _context.Manufacturers.Update(model);
                    }
                    else //insert
                    {
                        _context.Manufacturers.Add(model);
                    }
                    _context.SaveChanges();

                    TempData["Success Message"] = "Record Saved Successfully";
                    return RedirectToAction(nameof(Index));

                }
                else
                {

                    return View();
                }

            }
            catch (Exception ex)
            {
                //log
                TempData["Error Message"] = "Error Message:" + ex.Message;
                return RedirectToAction(nameof(CreateOrEdit));
            }

         
        
        }




    }
}
