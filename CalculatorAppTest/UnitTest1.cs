namespace CalculatorApp.Test;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
    }
    [TestMethod]
    public void AddTest()
    {

        int? retVal = Calculator.calculate(2, 3, Operation.Add);

        Assert.AreEqual(5, retVal);

    }
}
