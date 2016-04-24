using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    class Addition
    {
        public void AdditionIntOperation(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine("Your answer is: " + sum);

        }

        public void AdditionDoubleOperation(double num1, double num2)
        {
            double sum = num1 + num2;
            Console.WriteLine("Your answer is: "+sum);
        }

        
    }
}
