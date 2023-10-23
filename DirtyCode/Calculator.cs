using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirtyCode
{
    public class Calculator
    {
        private double FirstNumber { get; set; }
        private double SecondNumber { get; set; }
        private double Result { get; set; }

        public List<IOperation> MyList = new()
        {
        new AddOperation(),
        new SubtractOperation(),
        new MultiplyOperation(),
        new DivideOperation()
        };
        public void Start()
        {
            while (true)
            {
                Console.WriteLine("Dirty Calculator - Choose an operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");


                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter two numbers:");

                if (choice <= MyList.Count)
                {
                    FirstNumber = Convert.ToInt32(Console.ReadLine());
                    SecondNumber = Convert.ToInt32(Console.ReadLine());
                    Result = MyList[choice - 1].Calculate(FirstNumber, SecondNumber);
                    Console.WriteLine(Result);
                }
                else
                {
                    Environment.Exit(0);
                }
                //if (choice == 1)
                //{
                //    _operation = new AddOperation();
                //    _operation.Calculate(FirstNumber, SecondNumber);
                //}
                //else if (choice == 2)
                //{
                //    _operation = new SubtractOperation();
                //    _operation.Calculate(FirstNumber, SecondNumber);

                //}
                //else if (choice == 3)
                //{
                //    _operation = new MultiplyOperation();
                //    _operation.Calculate(FirstNumber, SecondNumber);

                //}
                //else if (choice == 4)
                //{
                //    _operation = new DivideOperation();
                //    _operation.Calculate(FirstNumber, SecondNumber);

                //}
                //else if (choice == 5)
                //{
                //    Environment.Exit(0);
                //}
                //else
                //{
                //    Console.WriteLine("Invalid choice.");
                //}
            }
        }

    }
}
