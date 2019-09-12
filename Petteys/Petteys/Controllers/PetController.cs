using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Petteys.Controllers
{
    public class PetController : Controller
    {
        // GET: Pet
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UpdatePic1()
        {
            return View();
        }
    }
}