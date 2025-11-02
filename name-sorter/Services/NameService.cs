using name_sorter.Models;

namespace name_sorter.Services;

/// <summary>
/// Implements methods to manipulate arrays and lists of FullName's.
/// </summary>
public static class NameService
{
    /// <summary>
    /// Gets a List of FullName. Excludes invalid input.
    /// </summary>
    /// <param name="namesArray">An array of names as string.</param>
    /// <returns>List of FullName.(excluding rejected names)</returns>
    public static List<FullName> GetListOfNames(string[] namesArray)
    {
        // Initialize list
        var unsortedNames = new List<FullName>();

        // Populate list
        foreach (var line in namesArray)
        {
            // Sanitize string and get all names
            var lineArray = line.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            var lineArrayLength = lineArray.Length;

            // Validate line (min 1 given name, max 3 given names)
            if (lineArrayLength < 2 || lineArrayLength > 4) // Invalid
            {
                continue;
            }
            else // Valid
            {
                if (lineArrayLength == 2) // 1 given name
                {
                    unsortedNames.Add(new FullName()
                    {
                        GivenName1 = lineArray[0],
                        LastName = lineArray[1]
                    });
                    continue;
                }
                if (lineArrayLength == 3) // 2 given names
                {
                    unsortedNames.Add(new FullName()
                    {
                        GivenName1 = lineArray[0],
                        GivenName2 = lineArray[1],
                        LastName = lineArray[2]
                    });
                    continue;
                }
                if (lineArrayLength == 4) // 3 given names
                {
                    unsortedNames.Add(new FullName()
                    {
                        GivenName1 = lineArray[0],
                        GivenName2 = lineArray[1],
                        GivenName3 = lineArray[2],
                        LastName = lineArray[3]
                    });
                }
            }
        }

        return unsortedNames;
    }

    /// <summary>
    /// Gets a List of FullName sorted by LastName, GivenName1, GivenName2, GivenName3.
    /// </summary>
    /// <param name="unsortedList">Unsorted List of FullName.</param>
    /// <returns>A new sorted List of FullName.</returns>
    public static List<FullName> GetSortedListOfNames(List<FullName> unsortedList)
    {
        // Lets leverage LINQ to sort the list
        var result = unsortedList
            .OrderBy(x => x.LastName)
            .ThenBy(x => x.GivenName1)
            .ThenBy(x => x.GivenName2)
            .ThenBy(x => x.GivenName3)
            .ToList();

        return result;
    }

    /// <summary>
    /// Gets an array of names.(string)
    /// </summary>
    /// <param name="list">List of FullName.</param>
    /// <returns>A new array of names.(string)</returns>
    public static string[] GetArrayOfNames(List<FullName> list)
    {
        // Initialize
        var resultList = new List<string>();
        foreach (var fullName in list)
        {
            resultList.Add(fullName.ToString());
        }

        return resultList.ToArray();
    }

    /// <summary>
    /// Gets an array of names.(string, sorted by LastName, GivenName1, GivenName2, GivenName3).
    /// </summary>
    /// <param name="unsortedArray"></param>
    /// <returns>An array of names.(string, excluding rejected names)</returns>
    public static string[] GetSortedArrayOfNames(string[] unsortedArray)
    {
        var list = GetListOfNames(unsortedArray);
        var sortedList = GetSortedListOfNames(list);
        var sortedArray = GetArrayOfNames(sortedList);

        return sortedArray;
    }

}
