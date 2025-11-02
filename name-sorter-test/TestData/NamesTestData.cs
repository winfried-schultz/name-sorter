using name_sorter.Models;

namespace NameSorterTest.TestData;

// The test data below is not meant to be exhaustive,
// but rather demonstrate a proof of concept.

/// <summary>
/// Provides data to test against.
/// </summary>
public static class NamesTestData
{
    public static string[] UnsortedNamesArray = [
        "Janet Parsons",
        "Vaughn Lewis",
        "Adonis Julius Archer",
        "Shelby Nathan Yoder",
        "Marin Alvarez",
        "London Lindsey",
        "Beau Tristan Bentley",
        "Leo Gardner",
        "Hunter Uriah Mathew Clarke",
        "Mikayla Lopez",
        "Frankie Conner Ritter",
        "Name With Too Many Given Names",
        "Nogivenname"];

    public static string[] SortedNamesArray = [
        "Marin Alvarez",
        "Adonis Julius Archer",
        "Beau Tristan Bentley",
        "Hunter Uriah Mathew Clarke",
        "Leo Gardner",
        "Vaughn Lewis",
        "London Lindsey",
        "Mikayla Lopez",
        "Janet Parsons",
        "Frankie Conner Ritter",
        "Shelby Nathan Yoder"];

    public static List<FullName> UnsortedFullNameList = [
        new(){GivenName1 = "Janet", GivenName2 = "", GivenName3 = "", LastName = "Parsons" },
        new(){GivenName1 = "Vaughn", GivenName2 = "", GivenName3 = "",  LastName = "Lewis" },
        new(){GivenName1 = "Adonis", GivenName2 = "Julius", GivenName3 = "", LastName = "Archer" },
        new(){GivenName1 = "Shelby", GivenName2 = "Nathan", GivenName3 = "", LastName = "Yoder" },
        new(){GivenName1 = "Marin", GivenName2 = "", GivenName3 = "", LastName = "Alvarez"},
        new(){GivenName1 = "London", GivenName2 = "", GivenName3 = "", LastName = "Lindsey" },
        new(){GivenName1 = "Beau", GivenName2 = "Tristan", GivenName3 = "",  LastName = "Bentley" },
        new(){GivenName1 = "Leo", GivenName2 = "", GivenName3 = "",  LastName = "Gardner" },
        new(){GivenName1 = "Hunter", GivenName2 = "Uriah", GivenName3 = "Mathew",  LastName = "Clarke" },
        new(){GivenName1 = "Mikayla", GivenName2 = "", GivenName3 = "",  LastName = "Lopez" },
        new(){GivenName1 = "Frankie", GivenName2 = "Conner", GivenName3 = "",  LastName = "Ritter" }];

    public static List<FullName> SortedFullNameList = [
        new(){GivenName1 = "Marin", GivenName2 = "", GivenName3 = "",  LastName = "Alvarez" },
        new(){GivenName1 = "Adonis", GivenName2 = "Julius", GivenName3 = "", LastName = "Archer" },
        new(){GivenName1 = "Beau", GivenName2 = "Tristan", GivenName3 = "",  LastName = "Bentley" },
        new(){GivenName1 = "Hunter", GivenName2 = "Uriah", GivenName3 = "Mathew",  LastName = "Clarke" },
        new(){GivenName1 = "Leo", GivenName2 = "", GivenName3 = "",  LastName = "Gardner" },
        new(){GivenName1 = "Vaughn", GivenName2 = "", GivenName3 = "",  LastName = "Lewis" },
        new(){GivenName1 = "London", GivenName2 = "", GivenName3 = "", LastName = "Lindsey" },
        new(){GivenName1 = "Mikayla", GivenName2 = "", GivenName3 = "",  LastName = "Lopez" },
        new(){GivenName1 = "Janet", GivenName2 = "", GivenName3 = "", LastName = "Parsons" },
        new(){GivenName1 = "Frankie", GivenName2 = "Conner", GivenName3 = "",  LastName = "Ritter" },
        new(){GivenName1 = "Shelby", GivenName2 = "Nathan", GivenName3 = "", LastName = "Yoder" }];
}
