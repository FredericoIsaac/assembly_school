using System;

namespace Code_I
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        #region Operations
        static void CodeIOperations()
        {
            bool exit = false;

            do
            {
                Console.WriteLine("Please select the application you want to use (Md#ID#):\n");
                Console.WriteLine("1 - HighestNumber: Find the highest number;");
                Console.WriteLine("2 - HighestDivision: Find the highest result of the division;");
                Console.WriteLine("3 - LowestDivision: Find the lowest after being divided by the remaining;");
                Console.WriteLine("4 - Divide: Divide 2 numbers;");
                Console.WriteLine("5 - BizzBuzz: 2 numbers and finds if is even (Bizz) or odd (Buzz);");
                Console.WriteLine("6 - Calculator: Asks for 2 numbers and one operator and gives the result.\n");
                string app = Console.ReadLine();

                switch (app)
                {
                    case "Md1":
                        HighestNumber();
                        goto case "Exit";
                    case "Md2":
                        HighestDivision();
                        goto case "Exit";
                    case "Md3":
                        LowestDivision();
                        goto case "Exit"; 
                    case "Md4":
                        Divide();
                        goto case "Exit";
                    case "Md5":
                        BizzBuzz();
                        goto case "Exit";
                    case "Md6":
                        Calculator();
                        goto case "Exit";
                    case "Exit":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Wrong selection, please use like this 'Md#ID#'.\n");
                        break;
                }
            } while (!exit);
           
        }

        static void Calculator()
        //The application that receives two number and one operator
        //option and executes the calculation. SUM / SUB/ MLT/ DIV
        {
            int[] numbers = InputNumbers(2);
            Console.WriteLine("And give me one operator, it can be SUM (+), SUB (-), MLT(*) or DIV (/).");
            string calculate = Console.ReadLine();
            double? result = null;
            
            switch (calculate)
            {
                case "+":
                    result = numbers[0] + numbers[1];
                    goto case "Result";
                case "-":
                    result = numbers[0] - numbers[1];
                    goto case "Result";
                case "*":
                    result = numbers[0] * numbers[1];
                    goto case "Result";
                case "/":
                    result = numbers[0] / numbers[1];
                    goto case "Result";
                case "Result":
                    Console.WriteLine($"The result of {numbers[0]} {calculate} {numbers[1]} = {result}");
                    break;
                default:
                    Console.WriteLine("Wrong operator, program exiting...");
                    break;
            }
        }

        static void BizzBuzz()
        //The application receives two number, calculates the multiplication
        //and return the word “Bizz” when even and “Buzz” when odd;
        {
            int[] numbers = InputNumbers(2);
            int multiply = numbers[0] * numbers[1];
            string result = multiply % 2 == 0 ? "Bizz" : "Buzz";
            Console.WriteLine(result);
        }

        static void Divide()
        //The application receives two number and divides them.
        //The result must be returned, with two decimal places;
        {
            int[] numbers = InputNumbers(2);
            double result = (double)numbers[0] / (double)numbers[1];
            Console.WriteLine($"The result of {numbers[0]} / {numbers[1]} = {result}.");
        }

        static void LowestDivision()
        //The application receives four number and see which is the
        //lowest after being divided by the remaining.
        // Ex.: 10, 5, 2, 9 -> 0.2
        // 10/5 = 2; 10/2 = 5; 10/9 = 1.11
        // 5/10 = 0.5; 5/2 = 2.5; 5/9 = 0.56
        // 2/10 = 0.2; 2/5 = 0.4; 2/9 = 0.22
        // 9/10 = 0.9; 9/5 = 1.8; 9/2 = 4.5
        {
            int[] numbers = InputNumbers(4);
            // Nao tenho a certeza se é isto que querem...

        }

        static void HighestDivision()
        //The application receives two number and see which has the
        //highest result of the division of one from the other.
        // Ex.: 10, 5 ->  0.5
        // 10/5 = 2 || 5/10 = 0.5
        {
            int[] numbers = InputNumbers(2);
            double option1 = numbers[0] / numbers[1];
            double option2 = numbers[1] / numbers[0];
            double result = (option1 > option2) ? option1 : option2;
            Console.WriteLine($"The highest result of the division is {result}.");
        }
         
        static void HighestNumber()
        //The application receives four numbers and see which one
        //is the highest.
        {
            int[] numbers = InputNumbers(4);
            Array.Sort(numbers);
            Console.WriteLine($"The highest number is {numbers[^1]}.");
        }

        static int[] InputNumbers(int NumberOfNumbers)
        {
            int count = 0;
            int[] numbers = new int[NumberOfNumbers];
            while (count < NumberOfNumbers)
            {
                Console.WriteLine($"Please insert the number {count + 1}.");
                numbers[count] = Convert.ToInt32(Console.ReadLine());
                count++;
            }
            return numbers;
        }
        #endregion

        #region Cycles
        static void CodeICycles()
        {
            //1. The application receives a number and returns the table of 5.
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} x 5 = {i * 5}");
            }

            //2. Update the application 1 so that the calculated table is based
            //on a provided number by the user.
            Console.WriteLine("Please insert the number you want to calculate the table: ");
            int table = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {table} = {i * table}");
            }

            //3.The application draws half a tree with the character *.
            //The number of lines is provided by the user.
            Console.WriteLine("Please insert the number of lines you want the tree to have: ");
            int numberLines = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= numberLines; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //4. The application draws a full tree with the character *.
            //The number of lines is provided by the user.
            Console.WriteLine("Now a full tree: ");
            for (int i = 1; i <= numberLines; i++)
            {
                for (int j = 0; j < numberLines - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                
                Console.WriteLine();
            }

            //The application is identical to application 3, using the Do/While cycle;
            Console.WriteLine("Please insert the number of lines you want the tree to have: ");
            numberLines = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            do
            {
                count++;
                for (int i = 0; i < count; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            } while (numberLines > count);

            //6. The application is identical to application 3, using the While cycle;
            Console.WriteLine("Please insert the number of lines you want the tree to have: ");
            numberLines = Convert.ToInt32(Console.ReadLine());
            count = 0;

            while (numberLines > count)
            {
                count++;
                for (int i = 0; i < count; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //7. The application is identical to application 4, using the Do/While cycle;
            Console.WriteLine("Now a full tree: ");
            count = 0;

            do
            {
                count++;
                for (int j = 0; j < numberLines - count; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < count; k++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }

                Console.WriteLine();

            } while (numberLines > count);

            Console.ReadLine();
        }
        #endregion


    }
}
