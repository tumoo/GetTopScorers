using GetTopScorers.TopScorersService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTopScorers.Contracts
{
    public interface IOutput
    {
        void Display(IEnumerable<Person> topScorers);
    }
}
