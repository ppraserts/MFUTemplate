using MFU.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MFU.WebAPI.Controllers
{
    public class HomeController : Controller
    {
        private DocumentCategoryService documentCategoryService { get; set; }
        public HomeController()
        {
            documentCategoryService = new DocumentCategoryService();
        }
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            var documentCategorys = documentCategoryService.GetAll();

            return View(documentCategorys);
        }

        public ActionResult Details(int id)
        {
            return View(documentCategoryService.GetById(id));
        }
    }
}
