using name_sorter.Services;
using NameSorterTest.TestData;

namespace NameSorterTest.Tests;

[TestClass]
public class NameServiceTest
{
    [TestMethod]
    public void GetListOfNames_TestData_IsEqual()
    {
        var testArray = NamesTestData.UnsortedNamesArray;
        var expectedListOfFullName = NamesTestData.UnsortedFullNameList;

        var actualListOfFullName = NameService.GetListOfNames(testArray);

        CollectionAssert.AreEqual(expectedListOfFullName, actualListOfFullName);
    }

    [TestMethod]
    public void GetSortedListOfNames_TestData_IsEqual()
    {
        var unsortedListOfFullName = NamesTestData.UnsortedFullNameList;
        var expectedListOfFullName = NamesTestData.SortedFullNameList;

        var sortedListOfFullName = NameService.GetSortedListOfNames(unsortedListOfFullName);

        CollectionAssert.AreEqual(expectedListOfFullName, sortedListOfFullName);
    }

    [TestMethod]
    public void GetArrayOfNames_TestData_IsEqual()
    {
        var testList = NamesTestData.SortedFullNameList;
        var expectedArray = NamesTestData.SortedNamesArray;

        var actualArray = NameService.GetArrayOfNames(testList);

        CollectionAssert.AreEqual(expectedArray, actualArray);
    }

    [TestMethod]
    public void GetSortedArrayOfNames_TestData_IsEqual()
    {
        var unsortedArray = NamesTestData.UnsortedNamesArray;
        var expectedArray = NamesTestData.SortedNamesArray;

        var actualArray = NameService.GetSortedArrayOfNames(unsortedArray);

        CollectionAssert.AreEqual(expectedArray, actualArray);
    }

}
