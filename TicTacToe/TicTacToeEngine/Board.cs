using System;

namespace TicTacToe.TicTacToeEngine
{
    public class Board : IBoard
    {
        public string status = string.Empty;
        public char playerName = ' '; 
        public int turns = 0;

        public char[] players = { 'X', 'O' };
        public char[] board =
        {
            '1', '2', '3','4', '5', '6','7', '8', '9'
        };
        
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
            } else
            {
                throw new InvalidOperationException("Player can only be X or O");
            }

            if (input > 9)
            {
                throw new ArgumentOutOfRangeException("Input tile number cannot be greater than 9.");
            }

            switch (input)
            {
                case 1:
                    if(CheckTileOccupancy(0)) 
                        board[0] = playerName; 
                    break;
                case 2: 
                    if (CheckTileOccupancy(1))
                        board[1] = playerName; 
                    break;
                case 3:
                    if (CheckTileOccupancy(2))
                        board[2] = playerName; 
                    break;
                case 4:
                    if (CheckTileOccupancy(3))
                        board[3] = playerName; 
                    break;
                case 5:
                    if (CheckTileOccupancy(4))
                        board[4] = playerName;
                    break;
                case 6:
                    if (CheckTileOccupancy(5))
                        board[5] = playerName; 
                    break;
                case 7:
                    if (CheckTileOccupancy(6))
                        board[6] = playerName; 
                    break;
                case 8:
                    if (CheckTileOccupancy(7))
                        board[7] = playerName; 
                    break;
                case 9:
                    if (CheckTileOccupancy(8))
                        board[8] = playerName; 
                    break;
                default:
                    throw new ArgumentOutOfRangeException("An invalid move was given.");
            }
        } 

        public bool CheckTileOccupancy(int tileIndex)
        {
            var charTile = (tileIndex + 1).ToString();
            if (board[tileIndex] == charTile.ToCharArray()[0])
            {
                return true;
            }

            throw new InvalidOperationException("The chosen tile is not allowed.");
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
