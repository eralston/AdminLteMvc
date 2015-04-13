using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminLteMvc.Controllers
{
    public class AdminLteController : Controller
    {
        // GET: AdminLte
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Colors()
        {
            return View();
        }
    }
}