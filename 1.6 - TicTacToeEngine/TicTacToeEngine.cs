using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6___TicTacToeEngine
{
    public class TicTacToeEngine
    {
        public enum GameStatus { PlayerOPlays, PlayerXPlays, Equal, PlayerOWins, PlayerXWins }
        public string[] board = {"1","2","3","4","5","6","7","8","9"};
        private int turn = 0;
        public GameStatus Status { get; private set; }
        public string Board()
        {
            string s = "-------------\r\n"
                + "| " + board[0] + " | " + board[1] + " | " + board[2] + " | \r\n"
                + "-------------\r\n"
                + "| " + board[3] + " | " + board[4] + " | " + board[5] + " | \r\n"
                + "-------------\r\n"
                + "| " + board[6] + " | " + board[7] + " | " + board[8] + " | \r\n";

            return s;
        }
        public bool ChooseCell(int i)
        {
            i--;
            if(i >= 0 && i <= 8){
                if (board[i] != "O" && board[i] != "X")
                {
                    turn++;
                    if (Status == GameStatus.PlayerOPlays)
                    {
                        board[i] = "O";
                    }else if(Status == GameStatus.PlayerXPlays){
                        board[i] = "X";
                    }

                    if((board[0] == board[1] && board[0] == board[2]) ||
                        (board[3] == board[4] && board[3] == board[5]) ||
                        (board[6] == board[7] && board[6] == board[8]) ||
                        (board[0] == board[4] && board[0] == board[8]) ||
                        (board[2] == board[5] && board[2] == board[8]) ||
                        (board[0] == board[3] && board[0] == board[6]) ||
                        (board[1] == board[4] && board[1] == board[7]) ||
                        (board[2] == board[5] && board[2] == board[9])){
                            Status = (Status == GameStatus.PlayerOPlays ? GameStatus.PlayerOWins : GameStatus.PlayerXWins);
                        }
                    else if (turn == 9)
                    {
                        Status = GameStatus.Equal;
                        return true;
                    }
                    else
                    {
                        Status = (Status == GameStatus.PlayerOPlays ? GameStatus.PlayerXPlays : GameStatus.PlayerOPlays);
                    }
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else if (i == -1)
            {
                Reset();
                return false;
            }
            else
            {
                return false;
            }
        }

        private void Reset()
        {
            this.board[0] = "1";
            this.board[1] = "2";
            this.board[2] = "3";
            this.board[3]= "4";
            this.board[4]= "5";
            this.board[5]= "6";
            this.board[6]= "7";
            this.board[7]= "8";
            this.board[8] = "9";
            this.turn = 0;
            Status = GameStatus.PlayerOPlays;
        }
    }
}
