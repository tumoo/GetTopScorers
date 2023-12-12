using GetTopScorers.Contracts;
using GetTopScorers.TopScorersService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTopScorers.TopScorersService
{
    public class ConsoleOutput: IOutput
    {
        public void Display(IEnumerable<Person> topScorers)
        {
            foreach (var person in topScorers)
            {
                Console.WriteLine($"{person.FirstName}, {person.SecondName}, {person.Score}");
            }
        }
    }
}
