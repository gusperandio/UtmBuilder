using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core.Tests.ValuesObjects;

[TestClass]
public class UtmTestes
{
    [TestMethod]
    public void ShouldReturnUrlFromUtm()
    {
        var url = new Url("https://www.google.com");
        var cmp = new Campaign("src", "med", "nme", "id", "ter", "ctn");
        var utm = new Utm(url, cmp);
        var result = "https://www.google.com?utm_source=src" +
                     "&utm_medium=med" +
                     "&utm_campaign=nme" +
                     "&utm_id=id" +
                     "&utm_term=ter" +
                     "&utm_content=ctn";
        Console.WriteLine(result);
        Console.WriteLine(utm);
        Assert.AreEqual(result, utm.ToString());
        Assert.AreEqual(result, (string)utm);
    } 
}