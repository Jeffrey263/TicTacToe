using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeEngine
{
    public class Engine
    {
        public enum GameStatus { PlayerOPlays, PlayerXPlays, Equal, PlayerOWins, PlayerXWins }

        public GameStatus status { get; set; }

        public Dictionary<int, Dictionary<int, char>> board = new Dictionary<int, Dictionary<int, char>>();


        public Engine()
        {
            Start();
        }

        public void Start()
        {
            Dictionary<int, char> row_1 = new Dictionary<int, char>();
            row_1.Add(1, '1'); //colomn
            row_1.Add(2, '2');
            row_1.Add(3, '3');
            board.Add(1, row_1);

            Dictionary<int, char> row_2 = new Dictionary<int, char>();
            row_2.Add(1, '4');
            row_2.Add(2, '5');
            row_2.Add(3, '6');
            board.Add(2, row_2);

            Dictionary<int, char> row_3 = new Dictionary<int, char>();
            row_3.Add(1, '7');
            row_3.Add(2, '8');
            row_3.Add(3, '9');
            board.Add(3, row_3);

            status = GameStatus.PlayerOPlays;
        }

        public String Board()
        {
            String boardOut = "";

            boardOut += "|" + board[1][1] + "|" + board[1][2] + "|" + board[1][3] + "|\n";
            boardOut += "-------\n";
            boardOut += "|" + board[2][1] + "|" + board[2][2] + "|" + board[2][3] + "|\n";
            boardOut += "-------\n";
            boardOut += "|" + board[3][1] + "|" + board[3][2] + "|" + board[3][3] + "|\n";

            return boardOut;
        }

        public Boolean checkIfEmpty(int row, int column)
        {
            if (board[row][column] != 'X' && board[row][column] != 'O')
            {
                return true;
            }
            else return false;
        }

        public Boolean ChooseCell(string cellString)
        {
            List<int> cell = NumberToCell(cellString);
            int row = cell.ElementAt(0);
            int column = cell.ElementAt(1);

            if (row != 99 && column != 99)
            {
                if(checkIfEmpty(row, column))
                {
                    switch (status)
                    {
                        case GameStatus.PlayerOPlays:
                            board[row][column] = 'O';
                            status = GameStatus.PlayerXPlays;
                            break;
                        case GameStatus.PlayerXPlays:
                            board[row][column] = 'X';
                            status = GameStatus.PlayerOPlays;
                            break;
                    }
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }


        public string CheckForWin()
        {
            List<String> possibilities = new List<string>();
            //HORIZONTAL
            possibilities.Add("" + board[1][1] + board[1][2] + board[1][3]);
            possibilities.Add("" + board[2][1] + board[2][2] + board[2][3]);
            possibilities.Add("" + board[3][1] + board[3][2] + board[3][3]);

            //VERTICAL
            possibilities.Add("" + board[1][1] + board[2][1] + board[3][1]);
            possibilities.Add("" + board[1][2] + board[2][2] + board[3][2]);
            possibilities.Add("" + board[1][3] + board[2][3] + board[3][3]);

            //DIAGONAL
            possibilities.Add("" + board[1][1] + board[2][2] + board[3][3]);
            possibilities.Add("" + board[3][1] + board[2][2] + board[1][3]);

            foreach(String possibility in possibilities)
            {
                if (possibility.Equals("OOO"))
                {
                    status = GameStatus.PlayerOWins;
                    return ("PLAYER O WINS");
                }
                else if (possibility.Equals("XXX"))
                {
                    status = GameStatus.PlayerXWins;
                    return ("PLAYER X WINS");
                }
            }
            return "";
        }

        public void Restart()
        {
            board.Clear();
            Start();
        }

        private List<int> NumberToCell(String input)
        {
            List<int> cell = new List<int>();

            switch (input)
            {
                //ROW 1
                case "1":
                    cell.Add(1);
                    cell.Add(1);
                    break;
                case "2":
                    cell.Add(1);
                    cell.Add(2);
                    break;
                case "3":
                    cell.Add(1);
                    cell.Add(3);
                    break;

                //ROW 2
                case "4":
                    cell.Add(2);
                    cell.Add(1);
                    break;
                case "5":
                    cell.Add(2);
                    cell.Add(2);
                    break;
                case "6":
                    cell.Add(2);
                    cell.Add(3);
                    break;

                //ROW 3
                case "7":
                    cell.Add(3);
                    cell.Add(1);
                    break;
                case "8":
                    cell.Add(3);
                    cell.Add(2);
                    break;
                case "9":
                    cell.Add(3);
                    cell.Add(3);
                    break;
                default:
                    cell.Add(99);
                    cell.Add(99);
                    break;
            }

            return cell;
        }
    }
}
