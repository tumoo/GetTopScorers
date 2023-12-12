using GetTopScorers.Contracts;
using GetTopScorers.TopScorersService;
using GetTopScorers.TopScorersService.Models;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            //please remember to change this path to your local drive
            string filePath = @"C:\Users\tmarais1\source\repos\GetTopScorers\TestData.csv";
            // Read data from CSV file
            IReader reader = new CSVReader(filePath);
            string csvData = reader.Read();

            // Parse CSV data
            IParser parser = new CSVParser();
            List<Person> people = parser.Parse(csvData);

            // Find top scorers
            var topScorers = people
                .GroupBy(p => p.Score)
                .OrderByDescending(g => g.Key)
                .First()
                .OrderBy(p => p.FirstName)
                .ThenBy(p => p.SecondName);

            // Display top scorers
            IOutput output = new ConsoleOutput();
            output.Display(topScorers);
            Console.Read();
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occured:", ex.Message);
        }
    }
}