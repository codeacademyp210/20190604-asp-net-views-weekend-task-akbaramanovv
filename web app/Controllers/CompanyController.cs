using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_app.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        public ActionResult CompIndex()
        {
            return View();
        }
    }
}