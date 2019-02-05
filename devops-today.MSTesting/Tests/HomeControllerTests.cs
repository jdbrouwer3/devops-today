using Microsoft.VisualStudio.TestTools.UnitTesting;
using devops_today.Controller;

namespace devops_today.MSTesting.Tests
{
  [TestsClass]
  public class HomeControllerTests
  {
    [TestMethod]
    public void Test_IndexAction()
    {
      var sut = new HomeController();

      Assert.IsNotNull(sut.Index());
    }

    public void Test_PrivacyAction()
    {
      var sut = new HomeController();

      Assert.IsNotNull(sut.Privacy());
    }
  }
}
