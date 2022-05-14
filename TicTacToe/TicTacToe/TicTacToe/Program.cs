using System;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char player = 'X';
            char computer = 'O';
            char currPlayer = player;

            do
            {
                string input = Menu();
                if (input == "0")
                {
                    Console.WriteLine("Ending Game!");
                    break;
                }
                
                Game game = new Game();
                const string originalTurnMsg = "It's your time to play, insert coordinates (Ex.: 1 2):\n";
                string yourTurnMsg = "It's your time to play, insert coordinates (Ex.: 1 2):\n";
                string[] optionsInput = { "1 1", "1 2", "1 3", "2 1", "2 2", "2 3", "3 1", "3 2", "3 3" };
                string errorMessage = $"Wrong Input!\nPlease try again.\n";
                do
                {
                    Console.Clear(); 
                    Console.WriteLine();
                    Console.WriteLine(game.DrawBoard());
                    if (currPlayer == player)
                    {
                        Console.WriteLine(yourTurnMsg);
                        string coordinatesInput = Console.ReadLine();

                        
                        if (InputValidation(coordinatesInput, optionsInput))
                        {
                            yourTurnMsg = originalTurnMsg;
                            int[] coordinates = Array.ConvertAll(coordinatesInput.Split(' '), Convert.ToInt32);
                            coordinates[0]--;
                            coordinates[1]--;
                            if (!game.CheckPlay(coordinates) && !yourTurnMsg.Contains(errorMessage))
                            {
                                yourTurnMsg += "Space in board occupied!";
                                Console.Clear();
                                continue;
                            }
                            else
                            {
                                bool[] winTie = game.CheckWinTie(currPlayer, coordinates);
                                Console.Clear();
                                Console.WriteLine(game.DrawBoard());
                                if (winTie[0])
                                {
                                    Console.WriteLine("Congratz!! You won!\nPress any key to return to menu.");
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                }
                                else if (!winTie[1])
                                {
                                    Console.WriteLine("It's a Tie!\nPress any key to return to menu.");
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    currPlayer = computer;
                                }
                            }
                        }

                        if (!yourTurnMsg.Contains(errorMessage))
                        {
                            yourTurnMsg += $"Insert one of this inputs ({string.Join(" or ", optionsInput)})\nAttention to the space.";
                        }
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("It's Computer time to play");
                        bool validePlay = false;
                        int x_pc, y_pc;
                        do
                        {
                            Random randomPlay = new Random();
                            x_pc = randomPlay.Next(3);
                            y_pc = randomPlay.Next(3);
                            validePlay = game.CheckPlay(new[] { x_pc, y_pc });

                        } while (!validePlay);
                        bool[] winTie = game.CheckWinTie(currPlayer, new[] { x_pc, y_pc });
                        Console.Clear();
                        Console.WriteLine(game.DrawBoard());
                        if (winTie[0])
                        {
                            Console.WriteLine("Computer won!\nPress any key to return to menu.");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        else if (!winTie[1])
                        {
                            Console.WriteLine("It's a Tie!\nPress any key to return to menu.");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            currPlayer = player;
                        }
                    }
                }while (true);
            } while (true);

            // Jogar:
            // Jogador é o primeiro a jogar
            // seleciona a jogada por coordenadas
            // Valida jogada
            // Caso seja Valida
            // Verifica se ganhou ou foi empate
            // Caso seja invalida pede outra vez para escrever jogada

            // PC Joga aleatoriamente de acordo com os espaços que ha
            // Verifica se ganhou ou foi empate

            /* ------------------------------------------------------------- */
            // Class Jogo
            // Cria tabuleiro
            // Valida jogada
            // Verifica se ganhou ou empate
            // Atualiza tabuleiro

        }

        /// <summary>
        /// Validates the input received.
        /// </summary>
        /// <returns>true if the input is as intended</returns>
        public static bool InputValidation(string input, string[] desired)
        {
            if (Array.Exists(desired, element => element == input))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Prints the Menu and validates input.
        /// </summary>
        /// <returns>string input</returns>
        public static string Menu()
        {
            string gameMenu = "Tic Tac Toe\n1 - Jogar\n0 - Sair\n";
            string[] optionsInput = { "1", "0" };
            string errorMessage = $"Wrong Input!\nInsert one of this inputs ({string.Join(" or ", optionsInput)})\nPlease try again.";
            do
            {
                Console.WriteLine(gameMenu);
                string play = Console.ReadLine();
                bool validate = InputValidation(play, optionsInput);
                if (validate)
                    return play;

                if (!gameMenu.Contains(errorMessage))
                {
                    gameMenu += errorMessage;
                }
                Console.Clear();
            } while (true);
        }
    }
}
