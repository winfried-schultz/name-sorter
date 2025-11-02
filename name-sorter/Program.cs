using name_sorter.Services;

namespace NameSorter;

public class Program
{

    /// <summary>
    /// Entry point
    /// </summary>
    /// <param name="args">Expecting 1 argument: filepath</param>
    public static void Main(string[] args)
    {
        try
        {
            // Validate args
            var filePath = "";
            if (args.Length == 1)
            {
                filePath = args[0];
            }
            else
            {
                Console.WriteLine("Exiting program, expecting 1 argument");
                Environment.Exit(0);
            }

            // Check file exists
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Exiting program, file does not exist.");
                Environment.Exit(0);
            }

            // All good, initialize enumerable's.
            var unsortedArray = File.ReadAllLines(filePath);
            var sortedArray = NameService.GetSortedArrayOfNames(unsortedArray);

            // Print results to file (creates a new file or overwrites existing)
            var sortedFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sorted-names-list.txt");
            File.WriteAllLines(sortedFilePath, sortedArray);

            // Print results to screen
            Console.WriteLine();
            foreach (var fullName in sortedArray)
            {
                Console.WriteLine(fullName);
            }

            // Print report to screen
            var rejectedNamesCount = unsortedArray.Length - sortedArray.Length;
            Console.WriteLine();
            Console.WriteLine("--------------------- Name Sorter ----------------------");
            Console.WriteLine(unsortedArray.Length.ToString() + " read");
            Console.WriteLine(rejectedNamesCount.ToString() + " rejected (no given name / more than 3 given names)");
            Console.WriteLine(sortedArray.Length.ToString() + " sorted");
            Console.WriteLine(sortedArray.Length.ToString() + " written to file");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine();

        }
        catch (Exception ex)
        {
            Console.WriteLine("Exiting program, unexpected error.");
            Console.WriteLine(ex.Message);
            Environment.Exit(1);
        }
    }

}
