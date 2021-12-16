using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebProject.Controllers
{
    public class HomeController:Controller
    {
        public ActionResult Index()
        {
            ViewResult view = new ViewResult();
            view.ViewName = "Index";
            return view;
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult FAQ()
        {
            return View();
        }
    }
}
