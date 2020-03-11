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
  }
}