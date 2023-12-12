using GetTopScorers.TopScorersService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTopScorers.Contracts
{
    // Defining interfaces for SRP (Single Responsibility Principle)
    public interface IParser
    {
        List<Person> Parse(string data);
    }
}
