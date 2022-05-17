using Microsoft.AspNetCore.Mvc;
using Inventory.Models;
using System.Collections.Generic;
using System.Linq;

namespace Inventory.Controllers
{
  public class InventoriesController : Controller
  {
    // private readonly InventoryContext _db;

    // public AnimalsController(AnimalShelterContext db)
    // {
    //   _db = db;
    // }
    // public ActionResult Details(int id)
    // {
    //   Animal thisAnimal =_db.Animals.FirstOrDefault(animal=>animal.AnimalId==id);
    //   return View(thisAnimal);
    // }

    // public ActionResult Index()
    // {
    //   List<Animal> model = _db.Animals.ToList().OrderBy(x => x.Type).ThenBy(x => x.Date).ToList();
      
    //   return View(model);
    // }

    // public ActionResult Create()
    // {
    //     return View();
    // }

    // [HttpPost]
    // public ActionResult Create(Inventory inventory)
    // {
    //   _db.Inventories.Add(inventory);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }
  }
}