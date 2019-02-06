namespace devops_today.MSTesting.Tests
{
  [TestClass]
  public class ErrorViewModelTests
  {
    [TestMethod]
    public void Test_ShowRequestIdMethod()
    {
      var sut = new ErrorViewModel(){ RequestId = "john"};

      Assert.IsTrue(sut.ShowRequestId);
    }
  }
}
