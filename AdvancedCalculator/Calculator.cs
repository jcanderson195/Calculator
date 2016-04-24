using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    class Calculator
    {
        int num1;
        int num2;


        public void RunCalculator()
        {
            EnterNumbers();
            OperationOptions();
            OperationDecision();

            RunCalculator();
        }

        public void EnterNumbers()
        {
            Console.WriteLine("Please enter a number");
            Console.WriteLine("--------------------");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------");
            Console.WriteLine("Please enter another number");
            Console.WriteLine("--------------------");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------");
        }

        public void OperationOptions()
        {
            
            Console.WriteLine("Please choose what operation you would like to do with these numbers");
            Console.WriteLine("--------------------");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Divison");
            Console.WriteLine("--------------------");

        }

        public void OperationDecision()
        {
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------");

            if (choice == 1)
            {
                Addition runAdd = new Addition();
                runAdd.AdditionIntOperation(num1, num2);
                Console.WriteLine("--------------------------");
            }
            else if (choice == 2)
            {
                Subtraction runSubtract = new Subtraction();
                runSubtract.SubtractionIntOperation(num1, num2);
                Console.WriteLine("--------------------------");
            }
            else if (choice == 3)
            {
                Multiplication runMultiply = new Multiplication();
                runMultiply.MultiplicationIntOperation(num1, num2);
                Console.WriteLine("--------------------------");
            }
            else if (choice == 4)
            {
                Division runDivision = new Division();
                runDivision.DivisionIntOperation(num1, num2);
                Console.WriteLine("--------------------------");
            }
            else
            {
                Console.WriteLine("Please enter the numerical value associated with your decison.");
                Console.WriteLine("----------------------------");
                EnterNumbers();
            }


        }
    }
}
