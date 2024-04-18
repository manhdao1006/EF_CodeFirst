using EF_CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EF_CodeFirst.Controllers
{
    public class LopsController : Controller
    {
        // GET: Lops
        public ActionResult Index()
        {
            DBContext db = new DBContext();
            List<Lop> lops = db.lops.ToList();
            return View(lops);
        }
    }
}