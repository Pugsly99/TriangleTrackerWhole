using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.Tests 
{
  [TestClass]
  public class CheckTriangleTests
  {
    [TestMethod]

    public void IsTriangle_IsEquilateral_True()
    {
      CheckTriangle testCheckTriangle = new CheckTriangle();
      Assert.AreEqual(true, testCheckTriangle.IsTriangle(4, 4, 4));
    }
      [TestMethod]

    public void IsTriangle_IsIsosceles_True() 
    {
      CheckTriangle testCheckTriangle = new CheckTriangle();
      Assert.AreEqual(true, testCheckTriangle.IsTriangle(4, 4, 3));
    }
      [TestMethod]
    public void IsTriangle_IsScalene_True()
    {
      CheckTriangle testCheckTriangle = new CheckTriangle();
      Assert.AreEqual(true, testCheckTriangle.IsTriangle(3, 6, 5));
    }
  }
}