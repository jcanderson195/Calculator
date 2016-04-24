using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    class Division
    {
        public void DivisionIntOperation(int num1, int num2)
        {
            int sum = num2 / num1;
            Console.WriteLine("Your answer is: " + sum);

        }

        public void DivisionDoubleOperation(double num1, double num2)
        {
            double sum = num2 / num1;
            Console.WriteLine("Your answer is: " + sum);
        }

    }
}
