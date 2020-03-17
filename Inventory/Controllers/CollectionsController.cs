using Microsoft.AspNetCore.Mvc;
using Inventory.Models;
using System.Collections.Generic;
using System.Linq;

namespace Inventory.Controllers
{
  public class CollectionsController : Controller
  {
    private readonly InventoryContext _db;

    public CollectionsController(InventoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Collection> model = _db.Collections.ToList();
      model.Sort((x, y) => string.Compare(x.Type, y.Type));
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Collection collections)
    {
      _db.Collections.Add(collections);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Collection thisCollection = _db.Collections.FirstOrDefault(collections => collections.CollectionId == id);
      return View(thisCollection);
    }
  }
}