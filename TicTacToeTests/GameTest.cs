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
            Assert.IsNotNull(board);
        }

        [TestCase]
        public void CheckForHorizontalWin()
        {

            game.Reset();
            game.XorO(1, 1);
            game.XorO(2, 5);
            game.XorO(1, 2);
            game.XorO(2, 7);
            game.XorO(1, 3);

            var status = game.HorizontalWin();

            Assert.IsNotEmpty(status);
        }
    } 
}
