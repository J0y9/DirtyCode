using DirtyCode;

var myCalculator = new Calculator();
myCalculator.Start();

//class DirtyCodeExample
//{
//    static void Main(string[] args)
//    {
//        string choice;
//        int a, b;
//        double result;

//        Console.WriteLine("Dirty Calculator - Choose an operation:");
//        Console.WriteLine("1. Addition");
//        Console.WriteLine("2. Subtraction");
//        Console.WriteLine("3. Multiplication");
//        Console.WriteLine("4. Division");

//        choice = Console.ReadLine();
//        Console.WriteLine("Enter two numbers:");

//        a = Convert.ToInt32(Console.ReadLine());
//        b = Convert.ToInt32(Console.ReadLine());

//        if (choice == "1")
//        {
//            result = a + b;
//            Console.WriteLine("The result is: " + result);
//        }
//        else if (choice == "2")
//        {
//            result = a - b;
//            Console.WriteLine("The result is: " + result);
//        }
//        else if (choice == "3")
//        {
//            result = a * b;
//            Console.WriteLine("The result is: " + result);
//        }
//        else if (choice == "4")
//        {
//            if (b != 0)
//            {
//                result = a / b;
//                Console.WriteLine("The result is: " + result);
//            }
//            else
//            {
//                Console.WriteLine("Division by zero is not allowed.");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Invalid choice.");
//        }
//    }
//}