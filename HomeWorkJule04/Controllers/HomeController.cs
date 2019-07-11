using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HomeWorkJule04.Models;
using HomeWorkJule04.DAL;
using HomeWorkJule04.VModel;

namespace HomeWorkJule04.Controllers
{
    public class HomeController : Controller

    {
        private readonly MyDb _context;
        public HomeController(MyDb db)
        {
            _context = db;
        }
        public IActionResult Index()
        {
            IndexVm i = new IndexVm
            {
                VmSlides = _context.Slides,
                VmpopularDes = _context.PopularDess,
                VmHappyCostumers=_context.HappyCostumers,
                VmAbout=_context.Abouts,
                VmFeatures=_context.Features,
                VmRecentBlog=_context.RecentBlog,
                VmRecentBlogContents=_context.RecentBlogContents


            };
            return View(i);
        }

       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
