using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using ClaireSalon.Models;
namespace ClaireSalon.Controllers{

    public class SylistController : Controller
    {
        private readonly ClaireSalonContext _db;
        public SylistController(ClaireSalonContext db)
        {
            _db = db;
        }


        public ActionResult Index()
        {
            List<Stylist> model = _db.Stylists.ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Stylist stylist)
        {
            _db.Stylists.Add(stylist);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Stylist stylist = _db.Stylists.FirstOrDefault(sty => sty.StylistId == id);
            return View(stylist);
        }
    }
}