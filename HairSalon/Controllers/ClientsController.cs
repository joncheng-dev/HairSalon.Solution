using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly HairSalonContext _db;

    public ClientsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      ViewBag.PageTitle = "All Clients";
      ViewBag.UnderTitleText = "Below is a list of all clients in the database.";      
      List<Client> listOfAllClients = _db.Clients
                                         .Include(client => client.Stylist)
                                         .ToList();
      return View(listOfAllClients);
    }

    public ActionResult Create()
    {
      ViewBag.PageTitle = "Add New Client";
      ViewBag.UnderTitleText = "Below is a list of all stylists in the database.";      
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client entry)
    {
      if (entry.StylistId == 0)
      {
        return RedirectToAction("Create");
      }
      _db.Clients.Add(entry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      ViewBag.PageTitle = "Client Details";      
      ViewBag.UnderTitleText = "Below are details for the selected client.";      
      Client clientToShowDetailsOn = _db.Clients
                                        .Include(client => client.Stylist)
                                        .FirstOrDefault(client => client.ClientId == id);
      return View(clientToShowDetailsOn);
    }

    public ActionResult Edit(int id)
    {
      ViewBag.PageTitle = "Edit Client";            
      ViewBag.UnderTitleText = "Make edits for the selected client.";
      Client targetClientToEdit = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
      return View(targetClientToEdit);
    }

    [HttpPost]
    public ActionResult Edit(Client targetClient)
    {
      _db.Clients.Update(targetClient);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      ViewBag.PageTitle = "Delete Client";      
      ViewBag.UnderTitleText = "Confirm delete action for selected client.";      
      Client targetClientToDelete = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      return View(targetClientToDelete);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Client targetClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      _db.Clients.Remove(targetClient);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}