using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValuesObjects;

[TestClass]
public class UrlTests
{
    [TestMethod]
    [ExpectedException(typeof(InvalidUrlException))]
    public void Url_Invalida()
    {
        new Url("banana");
        Assert.Fail();
    }

    [TestMethod]
    public void Url_Correta()
    {
        new Url("https://www.google.com.br");
        Assert.IsTrue(true);
    }

    [TestMethod]
    [DataRow("", true)]
    [DataRow("http", true)]
    [DataRow("banana", true)]
    [DataRow("https://www.google.com", false)]
    public void TestRows(string link, bool exp)
    {
        if (exp)
        {
            try
            {
                new Url(link);
                Assert.Fail();
            }
            catch
            {
                Assert.IsTrue(true);
               
            }
        }
        else
        {
            new Url(link);
            Assert.IsTrue(true);
        }
    }
}