using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductRecallSystem.Data;
using ProductRecallSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductRecallSystem.Controllers
{
    public class HomeController : Controller
    {

        MyDbContext _context = new MyDbContext();

        public IActionResult Index()
        {
            //HomeViewModel viewModel = new HomeViewModel
            //{

            //    AnnouncementList = _context.Announcements.ToList(),
            //    RecallList = _context.Recalls.Include(x => x.Product).ToList()


            //}; 
            // return View(viewModel);

            return View();
        }


        public PartialViewResult RecallList()
        {
            var list = _context.Recalls.Include(x=>x.Product).Include(x=>x.Manufacturer).ToList();
            
            return PartialView(list);
        }

        public PartialViewResult AnnouncementList()
        {
            var list = _context.Announcements.Include(x=>x.Recall).ToList();

            return PartialView("_pvAnnouncementList",list);

        }

    }
}
