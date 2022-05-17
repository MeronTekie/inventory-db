using Microsoft.AspNetCore.Mvc;
using Inventory.Models;
using System.Collections.Generic;
using System.Linq;

namespace Inventories.Controllers
{
  public class InventoriesController : Controller
  {
    private readonly InventoryContext _db;

    public InventoriesController(InventoryContext db)
    {
      _db = db;
    }
    public ActionResult Details(int id)
    {
      Card thisCard =_db.Inventories.FirstOrDefault(card=>card.CardId==id);
      return View(thisCard);
    }

    public ActionResult Index()
    {
      List<Card> model = _db.Inventories.ToList();
      
      return View(model);
    }

    public ActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Create(Card card)
    {
      _db.Inventories.Add(card);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}