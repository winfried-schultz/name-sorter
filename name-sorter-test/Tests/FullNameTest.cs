using name_sorter.Models;

namespace NameSorterTest.Tests;

[TestClass]
public class FullNameTest
{

    [TestMethod]
    public void Equals_IsEqual()
    {
        var leftFullName = new FullName()
        {
            GivenName1 = "GivenName1",
            GivenName2 = "GivenName2",
            GivenName3 = "GivenName3",
            LastName = "LastName"
        };
        var rightFullName = new FullName()
        {
            GivenName1 = "GivenName1",
            GivenName2 = "GivenName2",
            GivenName3 = "GivenName3",
            LastName = "LastName"
        };

        Assert.AreEqual(leftFullName, rightFullName);
    }

    [TestMethod]
    public void Equals_IsNotEqual()
    {
        var leftFullName = new FullName()
        {
            GivenName1 = "GivenName1",
            GivenName2 = "GivenName2",
            GivenName3 = "GivenName3",
            LastName = "LastName"
        };
        var rightFullName = new FullName()
        {
            GivenName1 = "GivenName1",
            GivenName3 = "GivenName3",
            LastName = "LastName"
        };

        Assert.AreNotEqual(leftFullName, rightFullName);
    }

}
