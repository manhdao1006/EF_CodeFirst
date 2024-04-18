using EF_CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EF_CodeFirst.Controllers
{
    public class KhoasController : Controller
    {
        // GET: Khoas
        public ActionResult Index()
        {
            DBContext db = new DBContext();
            List<Khoa> khoas = db.khoas.ToList();
            return View(khoas);
        }
    }
}