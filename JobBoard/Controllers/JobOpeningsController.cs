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
      JobOpening newPosting = new JobOpening(title, description, name, email, phoneNumber);
      return RedirectToAction("Index");
    }


  }
}  