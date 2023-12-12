using GetTopScorers.Contracts;
using GetTopScorers.TopScorersService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTopScorers.TopScorersService
{
    public class CSVParser: IParser
    {
        public List<Person> Parse(string data)
        {
            List<Person> people = new List<Person>();

            var lines = data.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines.Skip(1)) // Skip header
            {
                var values = line.Split(',');

                if (values.Length == 3)
                {
                    var person = new Person
                    {
                        FirstName = values[0].Trim(),
                        SecondName = values[1].Trim(),
                        Score = int.Parse(values[2].Trim())
                    };

                    people.Add(person);
                }
            }

            return people;
        }
    }
}
