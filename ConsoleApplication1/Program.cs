using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Today.ToString("dd ") + DateTime.Today.ToString("y", CultureInfo.CreateSpecificCulture("ro-RO")));
            Console.Read();
        }
    }
}
