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

    // [TestMethod]
    // public void Find_ReturnsTheCorrectJobOpening_JobOpening()
    // {
    // //Arrange
    // string description = "Walk the dog.";
    // JobOpening newItem = new JobOpening(description);

    // //Act
    // int result = newJobOpening.Id;

    // //Assert
    // Assert.AreEqual(1, result);
    // }
  }
}