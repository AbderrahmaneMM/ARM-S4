using CMVV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMVV.Controllers
{
    public class ExepmleController : Controller
    {
        // GET: Exepmle
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Action01(Model01 M1) 
        { return View("Action01",M1); }
    }
}