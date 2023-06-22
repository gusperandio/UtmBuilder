using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValuesObjects;

[TestClass]
public class CampaignTests
{
    [TestMethod]
    [DataRow("", "", "", true)]
    [DataRow("teste", "teste", "", true)]
    [DataRow("teste", "", "teste", true)]
    [DataRow("", "teste", "teste", true)]
    [DataRow("teste", "teste", "teste", false)]
    public void TesteCampaign(string source, string medium, string name, bool exp)
    {
        if (exp)
        {
            try
            {
                new Campaign(source, medium, name);
                Assert.IsTrue(false);
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }
        else
        {
            new Campaign(source, medium, name);
            Assert.IsTrue(true);
        }
    }
}