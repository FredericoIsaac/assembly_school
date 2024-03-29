﻿using System;
using System.Linq;
using System.Collections;

namespace Code_I
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CodeIArrays();
            Factorial(5);
        }
        static double Factorial(int num1)
        {
            if (num1 <= 1)
            {
                return num1 * 1;
            }
            return num1 * Factorial(num1 - 1);
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

        #region Methods
        static void CodeIMethods()
        {
            // TODO: How to write docstring automaticaly?
            Console.WriteLine(SquareRoot(81));
            Console.WriteLine(NumberModule(-5));
            // TODO: Check output result, should be: QuadraticEquationPos = -6 and  QuadraticEquationNeg = 2
            Console.WriteLine(QuadraticEquationPos(2, 8, -24));
            Console.WriteLine(QuadraticEquationNeg(2, 8, -24));
            Console.WriteLine(Factorial(5));

            ///<summary>
            ///Receives one numeric input (double) and 
            ///returns the mathematical square root value of the same.
            /// </summary>
            static double SquareRoot(double num)
            {
                return Math.Sqrt(num);
            }

            /// <summary>
            /// Receives one numeric input (double) 
            /// and returns the module value of the same.
            /// </summary>
            static double NumberModule(double num)
            {
                return Math.Abs(num);
            }


            /// <summary>
            /// Receives three inputs and returns the positive
            /// value option of the quadratic equation.
            /// </summary>
            /// <example>
            /// x = [ -b +/- sqrt(b^2 - 4ac) ] / 2a
            /// </example>
            static double QuadraticEquationPos(double num1, double num2, double num3)
            {
                double sqrteq = (num2 
                    + SquareRoot(
                        NumberModule(
                            Math.Pow(num2, 2)
                            - 4 * num1 * num3
                            )
                        )
                    )
                    /
                    (2 * num1);

                return sqrteq;
            }

            /// <summary>
            /// Receives three inputs and
            /// returns the negative value option of the quadratic equation.
            /// </summary>
            /// <returns></returns>
            static double QuadraticEquationNeg(double num1, double num2, double num3)
            {
                double sqrteq = (num2
                    - SquareRoot(
                        NumberModule(
                            Math.Pow(num2, 2)
                            - 4 * num1 * num3
                            )
                        )
                    )
                    /
                    (2 * num1);
                
                return sqrteq;
            }

            /// <summary>
            /// Receives one numeric input (integer) and 
            /// returns the factorial value of the input
            /// </summary>
            /// <param name="num1"></param>
            /// <returns></returns>
            static double Factorial(int num1)
            {
                if (num1 <= 1)
                {
                    return num1 * 1;
                }
                return num1 * Factorial(num1 - 1);
            }
        }
        #endregion

        #region Arrays
        static void CodeIArrays()
        {

            ticTacToe();

            // TODO: Convert Array.system to array (How?):
            //int[] lowestToLargest = lowestLargest(5, 1, 8, 9, 10);
            //foreach(int number in lowestToLargest)
            //{
            //    Console.WriteLine(number);
            //}
            //int[] largestToLowest = largestLowest(5, 1, 8, 9, 10);
            //foreach (int number in largestToLowest)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine(avgarray(new int[] { 5, 1, 8, 9, 10}));


            //ArrayList numberAdded = giveMeMore();
            //foreach (int number in numberAdded)
            //{
            //    Console.WriteLine(number);
            //}

            /// <summary>
            /// Receives five numbers and returns them ordered from lowest to largest.
            /// </summary>
            static int[] lowestLargest(int num1, int num2, int num3, int num4, int num5)
            {
                int[] inputArray = new[] { num1, num2, num3, num4, num5 };
                Array.Sort(inputArray);
                return inputArray;
            }

            /// <summary>
            /// Receives five numbers and returns them ordered from lowest to largest
            /// </summary>
            static int[] largestLowest(int num1, int num2, int num3, int num4, int num5)
            {
                int[] lowestToLargest = lowestLargest(num1, num2, num3, num4, num5);
                Array.Reverse(lowestToLargest);
                return lowestToLargest;
            }

            /// <summary>
            /// Receives five numbers and returns the average.
            /// </summary>
            static double avgarray(int[] array)
            {
                //Using linq:
                //return array.Average();

                double sumArray = 0;
                foreach(int number in array)
                {
                    sumArray += number;
                }
                return sumArray / array.Length;

            }

            /// <summary>
            /// Receives an X number of inputs. It must return the correspondent value on 
            /// request, on after each request it must ask the user if it desires another retrieval.
            /// </summary>
            static ArrayList giveMeMore()
            {
                ArrayList list = new ArrayList();
                while (true)
                {
                    int numberAdd = 0;
                    string InputNumber = "";
                    Console.WriteLine("Give me one more number please (Enter to end)");

                    try
                    {
                        InputNumber = Console.ReadLine();
                        numberAdd = Convert.ToInt32(InputNumber);
                    }
                    catch (System.FormatException)
                    {
                        if (string.IsNullOrEmpty(InputNumber)) {
                            break;
                        }
                        Console.WriteLine("Wrong input..");
                        continue;
                    }

                    Console.WriteLine($"You inserted {numberAdd}");
                    list.Add(numberAdd);
                }
                return list;
            }

            static void ticTacToe()
            {
                
                static void resetBoard(string[,] oldBoard)
                {
                    oldBoard = new string[3,3];
                }

                static void drawBoard(string[,] board)
                {
                    string spaces = "  ";
                    Console.WriteLine($"{spaces}{spaces}|{spaces}A{spaces}|{spaces}B{spaces}|{spaces}C{spaces}|");
                    Console.WriteLine($"+---+-----+-----+-----+");
                    for (int i = 0; i < board.GetLength(0); i++)
                    {
                        Console.Write($"{spaces}{i+1} |");
                        for (int j = 0; j < board.GetLength(1); j++)
                        {
                            string boardSquare = board[i, j];
                            if (string.IsNullOrEmpty(boardSquare))
                            {
                                boardSquare = " ";
                            }
                            boardSquare = boardSquare.PadRight(3);
                            boardSquare = boardSquare.PadLeft(5);
                            Console.Write(boardSquare);
                            Console.Write("|");
                        }
                        Console.WriteLine();
                        Console.WriteLine($"+---+-----+-----+-----+");
                    }
                }

                static char whoFirst(char [] players)
                {
                    Random r = new Random();
                    return players[r.Next(players.Length)];
                }

                static int[] validatePlay(string play, string[,] board)
                {
                    string[] coordinates = play.Split(" ");

                    if (coordinates.Length != 2)
                    {
                        // TODO: return empty array, better way?
                        return new int[] {};
                    }
                    else 
                    {
                        int y;
                        bool canConvertY = int.TryParse(coordinates[1], out y);
                        bool rightPlayX = "ABC".Contains(coordinates[0]);

                        if (!canConvertY | !rightPlayX)
                        {
                            return new int[] { };
                        }
                        int indexPlay;
                        if (coordinates[0] == "A")
                        {
                            indexPlay = 0;
                        }
                        else if (coordinates[0] == "B")
                        {
                            indexPlay = 1;
                        }
                        else
                        {
                            indexPlay = 2;
                        }

                        Console.WriteLine($"{y - 1} + {indexPlay}");
                        Console.WriteLine(board[0,0]);
                        Console.WriteLine(board[1,0]);
                        if (string.IsNullOrEmpty(board[y-1, indexPlay]))
                        {
                            return new[] { y - 1, indexPlay }; 
                        }

                        return new int[] { };

                    }

                }

                static bool[] checkWinTie(string[,] board, char currentPlayer)
                {
                    bool emptySlots = false;
                    string player = Convert.ToString(currentPlayer);


                    for (int i = 0; i < board.GetLength(0); i++)
                    {
                        for (int j = 0; j < board.GetLength(1); j++)
                        {
                            if (string.IsNullOrEmpty(board[i, j]))
                            {
                                emptySlots = true;
                            }
                        }
                    }

                    if (board[0, 0] == player && board[0, 1] == player && board[0, 2] == player) { return new[] { true, emptySlots }; }
                    if (board[1, 0] == player && board[1, 1] == player && board[1, 2] == player) { return new[] { true, emptySlots }; }
                    if (board[2, 0] == player && board[2, 1] == player && board[2, 2] == player) { return new[] { true, emptySlots }; }

                    // check columns
                    if (board[0, 0] == player && board[1, 0] == player && board[2, 0] == player) { return new[] { true, emptySlots }; }
                    if (board[0, 1] == player && board[1, 1] == player && board[2, 1] == player) { return new[] { true, emptySlots }; }
                    if (board[0, 2] == player && board[1, 2] == player && board[2, 2] == player) { return new[] { true, emptySlots }; }

                    // check diags
                    if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player) { return new[] { true, emptySlots }; }
                    if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player) { return new[] { true, emptySlots }; }
                    
                    return new[] { false, emptySlots };
                }

                static void mainPlay()
                {
                    string[,] board = new string[3, 3];
                    char player = 'X';
                    char computer = 'O';
                    char currPlayer = whoFirst(new char[] { player, computer });

                    while (true)
                    {
                        Console.WriteLine("Lets Play Tic Tac Toe!\n0 - Exit.\n1 - Play.");
                        string chooseMenu = Console.ReadLine().ToUpper();

                        if (chooseMenu == "0")
                        {
                            Console.WriteLine("Exiting program.");
                            break;
                        }
                        else if (chooseMenu != "1")
                        {
                            Console.WriteLine("Wrong Input! Try again.");
                            Console.Clear();
                        }
                       

                        while (true)
                        {
                            drawBoard(board);
                            //board[0, 1] = "PP";
                            if (currPlayer == 'X')
                            {
                                Console.WriteLine("It's your time to play, insert coordinates (Ex.: A 1):");
                                string player_turn = Console.ReadLine().ToUpper();
                                int[] coordinates = validatePlay(player_turn, board);
                                
                                if (coordinates.Length == 0)
                                {
                                    Console.WriteLine("Wrong coordinates, please try again.");
                                    continue;
                                }
                                
                                board[coordinates[0], coordinates[1]] = "X";
                                bool[] checkGame = checkWinTie(board, currPlayer);

                                if (checkGame[0])
                                {
                                    Console.WriteLine("Congratz!! You won!\nPress any key to return to menu.");
                                    drawBoard(board);
                                    resetBoard(board);
                                    Console.ReadLine();
                                    break;
                                }
                                else if (!checkGame[1])
                                {
                                    Console.WriteLine("It's a Tie!\nPress any key to return to menu.");
                                    drawBoard(board);
                                    resetBoard(board);
                                    Console.ReadLine();
                                    break;
                                }
                                else
                                {
                                    currPlayer = 'O';
                                }

                            }
                            else
                            {
                                Console.WriteLine("It's Computer time to play");
                                int x_pc;
                                int y_pc;
                                while (true)
                                {
                                    Random randomPlay = new Random();
                                    x_pc = randomPlay.Next(3);
                                    y_pc = randomPlay.Next(3);
                                    if (string.IsNullOrEmpty(board[x_pc, y_pc]))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }

                                board[x_pc, y_pc] = "O";

                                bool[] checkGame = checkWinTie(board, currPlayer);

                                if (checkGame[0])
                                {
                                    Console.WriteLine("Computer won!\nPress any key to return to menu.");
                                    drawBoard(board);
                                    resetBoard(board);
                                    Console.ReadLine();
                                    break;
                                }
                                else if (!checkGame[1])
                                {
                                    Console.WriteLine("It's a Tie!\nPress any key to return to menu.");
                                    drawBoard(board);
                                    resetBoard(board);
                                    Console.ReadLine();
                                    break;
                                }
                                else
                                {
                                    currPlayer = 'X';
                                }

                            }
                            //Console.Clear();
                        }
                    }

                }

                mainPlay();
            }
        }
        #endregion

    }
}
