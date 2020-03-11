using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using JobBoard.Models;
using System;

namespace JobBoard.Tests
{
  [TestClass]
  public class JobOpeningTest : IDisposable
  {

    public void Dispose()
    {
      JobOpening.ClearAll();
    }

    [TestMethod]
    public void JobOpeningonstructor_CreatesInstanceOfJobOpening_JobOpening()
    {
      Contact newContact = new Contact("name", "email", "phoneNumber");
      JobOpening newPosting = new JobOpening("title", "description", newContact);
      Assert.AreEqual(typeof(JobOpening), newPosting.GetType());
    }

    [TestMethod]
    public void GetId_JobOpeningInstantiateWithAnIdAndGetterReturns_Int()
    {
    //Arrange
    string title = "jr web developer";
    string description = "fun and exciting junior developer job";
    Contact newContact = new Contact("name", "email", "phoneNumber");
    JobOpening newPosting = new JobOpening(title, description, newContact);

    //Act
    // int result = 0;//Failing Code
    int result = newPosting.Id; //Passing Code

    //Assert
    Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectJobOpening_JobOpening()
    {
      //Arrange
    string title01 = "jr web developer";
    string description01 = "fun and exciting junior developer job";
    string title02 = "jr software engineer";
    string description02 = "fun and exciting software engineer job";
    Contact newContact01 = new Contact("name1", "email1", "phoneNumber1");
    Contact newContact02 = new Contact("name2", "email2", "phoneNumber2");

    JobOpening newPosting1 = new JobOpening(title01, description01, newContact01);
    JobOpening newPosting2 = new JobOpening(title02, description02, newContact02);

      //Act
      Contact newContact = new Contact("Incorrect test name", "Incorrect test email", "Incorrect test phoneNumber");
      JobOpening result = new JobOpening("Incorrect test title", "Incorrect test description", newContact02); //Failing code
      // JobOpening result = JobOpening.Find(2); //Passing code

      //Assert
      Assert.AreEqual(newPosting2, result);
    }
  }
}