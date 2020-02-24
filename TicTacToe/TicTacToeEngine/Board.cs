using System;

namespace TicTacToe.TicTacToeEngine
{
    public class Board
    {
        public char playerName = ' '; 
        public char[] players = { 'X', 'O' };
        public int turns = 0;
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
            //DrawBoard();
            turns = 0;
        }

        public void XorO(int player, int input)
        {

            if (player == 1) playerName = 'X';
            else if (player == 2) playerName = 'O';

            switch (input)
            {
                case 1: board[0] = playerName; break;
                case 2: board[1] = playerName; break;
                case 3: board[2] = playerName; break;
                case 4: board[3] = playerName; break;
                case 5: board[4] = playerName; break;
                case 6: board[5] = playerName; break;
                case 7: board[6] = playerName; break;
                case 8: board[7] = playerName; break;
                case 9: board[8] = playerName; break;
            }

        } // player is X or O.

        public void HorizontalWin()
        {

            foreach (char playerName in players)
            {
                if (((board[0] == playerName) && (board[1] == playerName) && (board[2] == playerName))
                    || ((board[3] == playerName) && (board[4] == playerName) && (board[5] == playerName))
                    || ((board[6] == playerName) && (board[7] == playerName) && (board[8] == playerName)))
                {
                    Console.Clear();
                    if (playerName == 'X')
                    {
                        Console.WriteLine("Congratulations Player 1.\nYou have a achieved a horizontal win! " +
                                          "\nYou're the Tic Tac Toe Master!\n" +
                                          "\nTurns taken{0}", turns);
                    }
                    else if (playerName == 'O')
                    {
                        Console.WriteLine("Congratulations Player 2.\nYou have a achieved a horizontal win! " +
                                          "\nYou're the Tic Tac Toe Master!\n" +
                                          "\nTurns taken{0}", turns);
                    }


                    Console.WriteLine("Press any key to reset the game");
                    Console.ReadKey();
                    Reset();

                    break;
                }
            }
        } //Method is called to check for a horizontal win.  

        public void VerticalWin()
        {
            char[] players = { 'X', 'O' };

            foreach (char player in players)
            {
                if (((board[0] == player) && (board[3] == player) && (board[6] == player))
                    || ((board[1] == player) && (board[4] == player) && (board[7] == player))
                    || ((board[2] == player) && (board[5] == player) && (board[8] == player)))
                {
                    Console.Clear();
                    if (player == 'X')
                    {
                        Console.WriteLine("Player 1 won." + Environment.NewLine);
                    }
                    else
                    {
                        Console.WriteLine("Player 2 won." + Environment.NewLine);
                    }

                    Console.WriteLine("Press any key to reset the game.");
                    Console.ReadKey();
                    Reset();

                    break;
                }
            }
        } //Method is called to check for a vertical win.  

        public void DiagonalWin()
        {
            char[] players = { 'X', 'O' };

            foreach (char player in players)
            {
                if (((board[0] == player) && (board[4] == player) && (board[8] == player))
                    || ((board[6] == player) && (board[4] == player) && (board[2] == player)))
                {
                    Console.Clear();
                    if (player == 'X')
                    {
                        Console.WriteLine("Player 1 won." + Environment.NewLine);
                    }
                    else
                    {
                        Console.WriteLine(@"Player 2 won." + Environment.NewLine);
                    }

                    Console.WriteLine("Press any key to reset the game.");
                    Console.ReadKey();
                    Reset();

                    break;
                }
            }
        } //Method is called to check for a diagonal win.

        public void Draw()
        {

            {
                Console.WriteLine("Draw." + Environment.NewLine +
                                  "Press any key to reset the game.");
                Console.ReadKey();
                Reset();

            }
        } //Method is called to check if the game is a draw.
    }
}
