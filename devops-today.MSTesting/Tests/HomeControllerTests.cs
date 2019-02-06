using Microsoft.VisualStudio.TestTools.UnitTesting;
using devops_today.Controllers;

namespace devops_today.MSTesting.Tests
{
  [TestClass]
  public class HomeControllerTests
  {
    [TestMethod]
    public void Test_IndexAction()
    {
      var sut = new HomeController();

      Assert.IsNotNull(sut.Index());
    }

    [TestMethod]
    public void Test_PrivacyAction()
    {
      var sut = new HomeController();

      Assert.IsNotNull(sut.Privacy());
    }

    //not sure if these are the correct tests.

    
  }
}
