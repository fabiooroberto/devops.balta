namespace MoneyExtension.Tests;

[TestClass]
public class MoneyExntensionTests
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {
        decimal valor = 279.98M;
        var cents = valor.ToCents();

        Assert.AreEqual(27998, cents);
    }
}