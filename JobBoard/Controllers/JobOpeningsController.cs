using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System.Collections.Generic;

namespace JobBoard.Controllers
{
  public class JobOpeningsController : Controller
  {
    [HttpGet("/jobs")]
    public ActionResult Index()
    {
      List<JobOpening> allPostings = JobOpening.GetAll();
      return View(allPostings);
    }

    [HttpGet("jobs/new")]
    public ActionResult CreateJobPosting()
    {
      return View();
    }

    [HttpPost("/jobs")]
    public ActionResult Create(string title, string description, string name, string email, string phoneNumber)
    {
      Contact newContact = new Contact(name, email, phoneNumber);
      JobOpening newPosting = new JobOpening(title, description, newContact);
      return RedirectToAction("Index");
    }

    [HttpPost("/jobs/delete")]
    public ActionResult DeleteAll()
    {
      JobOpening.ClearAll();
      return View();
    }
  }
}  