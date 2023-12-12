using GetTopScorers.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTopScorers.TopScorersService
{
    public class CSVReader: IReader
    {
        private readonly string filePath;

        public CSVReader(string filePath)
        {
            this.filePath = filePath;
        }

        public string Read()
        {
            return File.ReadAllText(filePath);
        }
    }
}
