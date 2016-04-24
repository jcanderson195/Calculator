using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculator runCalculator = new Calculator();
            runCalculator.RunCalculator();

            Console.ReadKey();

        }
    }
}
