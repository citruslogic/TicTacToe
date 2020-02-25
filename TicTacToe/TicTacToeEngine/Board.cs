using System;

namespace TicTacToe.TicTacToeEngine
{
    public class Board : IBoard
    {
        public char playerName = ' '; 
        public char[] players = { 'X', 'O' };
        public int turns = 0;
        public char[] board =
        {
            '1', '2', '3','4', '5', '6','7', '8', '9'
        };
        public string status = string.Empty;

        public void Reset()
        {
            char[] boardInitializeArr =
            {
                '1', '2', '3','4', '5', '6','7', '8', '9'
            };

            board = boardInitializeArr;
            turns = 0;
        }

        public void XorO(int player, int input)
        {

            if (player == 1)
            {
                playerName = 'X';
            }
            else if (player == 2)
            {
                playerName = 'O';
            }

            switch (input)
            {
                case 1: board[0] = playerName; 
                    break;
                case 2: board[1] = playerName; 
                    break;
                case 3: board[2] = playerName; 
                    break;
                case 4: board[3] = playerName; 
                    break;
                case 5: board[4] = playerName;
                    break;
                case 6: board[5] = playerName; 
                    break;
                case 7: board[6] = playerName; 
                    break;
                case 8: board[7] = playerName; 
                    break;
                case 9: board[8] = playerName; 
                    break;
            }
        } 

        public string HorizontalWin()
        {

            foreach (char playerName in players)
            {
                if (((board[0] == playerName) && (board[1] == playerName) && (board[2] == playerName))
                    || ((board[3] == playerName) && (board[4] == playerName) && (board[5] == playerName))
                    || ((board[6] == playerName) && (board[7] == playerName) && (board[8] == playerName)))
                {
                    if (playerName == 'X')
                    {
                        status = $"Player 1 wins in {turns} turns.";
                    }
                    else if (playerName == 'O')
                    {
                        status = $"Player 2 wins in {turns} turns.";
                    }
                }

                if (!string.IsNullOrEmpty(status))
                {
                    Reset();
                    return status;
                }
            }

            return string.Empty;
        }  

        public string VerticalWin()
        {
            char[] players = { 'X', 'O' };

            foreach (char player in players)
            {
                if (((board[0] == player) && (board[3] == player) && (board[6] == player))
                    || ((board[1] == player) && (board[4] == player) && (board[7] == player))
                    || ((board[2] == player) && (board[5] == player) && (board[8] == player)))
                {
                    Reset();
                    if (player == 'X')
                    {
                        status = $"Player 1 won in {turns} turns." + Environment.NewLine;
                    }
                    else
                    {
                        status = $"Player 2 won in {turns} turns." + Environment.NewLine;
                    }
                }

                if (!string.IsNullOrEmpty(status))
                {
                    Reset();
                    return status;
                }
            }

            return string.Empty;
        } 

        public string DiagonalWin()
        {
            char[] players = { 'X', 'O' };

            foreach (char player in players)
            {
                if (((board[0] == player) && (board[4] == player) && (board[8] == player))
                    || ((board[6] == player) && (board[4] == player) && (board[2] == player)))
                {
                    if (player == 'X')
                    {
                        status = $"Player 1 won in {turns} turns." + Environment.NewLine;
                    }
                    else
                    {
                        status = $"Player 2 won in {turns} turns." + Environment.NewLine;
                    }
                }
                
                if (!string.IsNullOrEmpty(status))
                {
                    Reset();
                    return status;
                }
            }

            return string.Empty;
        }

        public bool Draw()
        {
            if (turns == 10)
            {
                Reset();
                return true;
            }

            return false;
        } 
    }
}
