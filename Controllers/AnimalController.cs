﻿using System.Data.Entity;
using System.Threading.Tasks;
using System.Web.Mvc;
using BW5.Models;

public class AnimalController : Controller
{
    private readonly VetContext _db;

    public AnimalController()
    {
        _db = new VetContext();
    }

    public ActionResult SearchAnimal()
    {
        return View();
    }

    [HttpPost]
    public async Task<ActionResult> SearchAnimal(string microchipNumber)
    {
        var animal = await _db.Animals.FirstOrDefaultAsync(a => a.IdMicrochip == microchipNumber);

        if (animal == null)
        {
            TempData["ErrorMessage"] = "Nessun animale trovato con questo microchip.";
            return RedirectToAction("Index");
        }

        return PartialView("_AnimalDetailsPartial", animal);
    }
}