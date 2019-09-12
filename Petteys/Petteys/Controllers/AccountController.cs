using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Petteys.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult registers()
        {
            return View();
        }

        public ActionResult resetpassword1()
        {
            return View();
        }

        public ActionResult resetpassword2()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}