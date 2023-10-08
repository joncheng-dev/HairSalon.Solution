using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HairSalon.Controllers
{
  public class StylistsController : Controller
  {
    private readonly HairSalonContext _db;

    public StylistsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      ViewBag.PageTitle = "Stylists";
      ViewBag.UnderTitleText = "Below is a list of all stylists in the database.";      
      List<Stylist> listOfStylists = _db.Stylists.ToList();
      return View(listOfStylists);
    }

    public ActionResult Create()
    {
      ViewBag.PageTitle = "Add New Stylist";
      ViewBag.UnderTitleText = "Fill in the form to add a new stylist.";                  
      return View();
    }

    [HttpPost]
    public ActionResult Create(Stylist entry)
    {
      _db.Stylists.Add(entry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      ViewBag.PageTitle = "Stylist Details";
      ViewBag.UnderTitleText = "Below are details for the selected stylist.";                  
      Stylist targetStylist = _db.Stylists
                                 .Include(stylist => stylist.Clients)
                                 .FirstOrDefault(stylist => stylist.StylistId == id);
      return View(targetStylist);
    }

    public ActionResult Edit(int id)
    {
      ViewBag.PageTitle = "Edit Stylist";
      ViewBag.UnderTitleText = "Make edits for the selected stylist.";                  
      Stylist targetStylist = _db.Stylists
                                  .FirstOrDefault(stylist => stylist.StylistId == id);
      return View(targetStylist);
    }

    [HttpPost]
    public ActionResult Edit(Stylist editedEntry)
    {
      _db.Stylists.Update(editedEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      ViewBag.PageTitle = "Delete Stylist";   
      ViewBag.UnderTitleText = "Confirm delete action for selected stylist.";               
      Stylist targetStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      return View(targetStylist);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Stylist targetStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      _db.Stylists.Remove(targetStylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}