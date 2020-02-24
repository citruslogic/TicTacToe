using System;

namespace TicTacToe.TicTacToeEngine
{
    public class Game
    {
        int player = 2; // player 1 (X) always starts first.
        int input = 0;
        bool validMove = true;
        readonly Board game = new Board();

        public void NewGame()
        {

            do //Alternates player turns.
            {
                if (player == 2)
                {
                    player = 1;
                    game.XorO(player, input);
                }
                else if (player == 1)
                {
                    player = 2;
                    game.XorO(player, input);
                }


                //board.DrawBoard();
                game.turns++;

                // is there a winner?
                game.HorizontalWin();
                game.VerticalWin();
                game.DiagonalWin();

                if (game.turns == 10)
                {
                    game.Draw();
                }

                do
                {
                    Console.WriteLine($"Player {0}: ", player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a number.");
                    }

                    if ((input == 1) && (game.board[0] == '1'))
                        validMove = true;
                    else if ((input == 2) && (game.board[1] == '2'))
                        validMove = true;
                    else if ((input == 3) && (game.board[2] == '3'))
                        validMove = true;
                    else if ((input == 4) && (game.board[3] == '4'))
                        validMove = true;
                    else if ((input == 5) && (game.board[4] == '5'))
                        validMove = true;
                    else if ((input == 6) && (game.board[5] == '6'))
                        validMove = true;
                    else if ((input == 7) && (game.board[6] == '7'))
                        validMove = true;
                    else if ((input == 8) && (game.board[7] == '8'))
                        validMove = true;
                    else if ((input == 9) && (game.board[8] == '9'))
                        validMove = true;
                    else
                    {
                        Console.WriteLine("Not an accepted move.  \nTry again...");
                        validMove = false;
                    }


                } while (!validMove);
            } while (true);

        } //Gameplay loop.  Controls player turns & overrides the array with players input.

    }
}
