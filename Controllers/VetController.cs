using BW5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BW5.Controllers
{
    public class VetController : Controller
    {
        // GET: Vet
        private VetContext db = new VetContext();

        public ActionResult Animals()
        {
            return View(db.Animals.ToList());
        }

    }
}