using NUnit.Framework;
using TicTacToe.TicTacToeEngine;

namespace TicTacToeTests
{
    [TestFixture]
    public class GameTest
    {
        Board game;
        char[] board;
        
        [SetUp]
        public void RaiseTestBoard()
        {
            game = new Board();
            board = game.board;
        }

        [TestCase]
        public void ReadBoardTiles()
        {
            board[0] = 'X';
            board[1] = 'X';
            board[2] = 'X';

            board[3] = 'O';
            board[7] = 'O';
            board[8] = 'O';

            Assert.IsNotNull(board);
        }

        [TestCase]
        public void CheckForHorizontalWin()
        {
            board[0] = 'X';
            board[1] = 'X';
            board[2] = 'X';

            board[3] = 'O';
            board[7] = 'O';
            board[8] = 'O';

            var status = game.HorizontalWin();

            Assert.IsNotEmpty(status);
        }
    } 
}
