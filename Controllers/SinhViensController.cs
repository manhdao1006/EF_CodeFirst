using EF_CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EF_CodeFirst.Controllers
{
    public class SinhViensController : Controller
    {
        DBContext db = new DBContext();
        // GET: SinhViens
        public ActionResult Index()
        {
            List<SinhVien> sinhViens = db.sinhViens.Where(sv => sv.LopId == sv.Lop.Id && sv.Lop.KhoaId == sv.Lop.Khoa.Id
                                    && sv.Lop.Khoa.Name.Contains("Công nghệ số") && sv.Age >= 18 && sv.Age <= 20).ToList();
            return View(sinhViens);
        }
    }
}