using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Game
    {
        public string[,] board { get;} = new string[3, 3];

        public string DrawBoard()
        {
            string board_draw = "";
            string spaces = "  ";
            board_draw += $"{spaces}{spaces}|{spaces}1{spaces}|{spaces}2{spaces}|{spaces}3{spaces}|\n";
            board_draw += $"+---+-----+-----+-----+\n";
            for (int i = 0; i < board.GetLength(0); i++)
            {
                board_draw += $"{spaces}{i + 1} |";
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    string boardSquare = board[i, j];
                    if (string.IsNullOrEmpty(boardSquare))
                    {
                        boardSquare = " ";
                    }
                    boardSquare = boardSquare.PadRight(3);
                    boardSquare = boardSquare.PadLeft(5);
                    board_draw += boardSquare;
                    board_draw += "|";
                }
                board_draw += "\n";
                board_draw += $"+---+-----+-----+-----+\n";
            }
            return board_draw;
        }


        public bool CheckPlay(int[] play)
        {
            if (string.IsNullOrEmpty(board[play[0], play[1]]))
            {
                return true;
            }
            return false;
        }

        public bool[] CheckWinTie(char currentPlayer, int[] play)
        {
            bool emptySlots = false;
            string player = currentPlayer.ToString();
            board[play[0], play[1]] = player;


            foreach (string slot in board)
            {
                if (string.IsNullOrEmpty(slot))
                {
                    emptySlots = true;
                    break;
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
    }
}
