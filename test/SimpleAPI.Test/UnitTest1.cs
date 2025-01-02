namespace SimpleAPI.Test;
using SimpleAPI.Controllers;

public class UnitTest1
{
  ValuesController controller = new ValuesController();

  [Fact]
  public void GetReturnsMyName()
  {
    var data = controller.Get(12);

    Assert.Equal("rahat", data.Value);
  }



    [Fact]
    public void Test1()
    {

    }
}