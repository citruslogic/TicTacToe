namespace TicTacToe.TicTacToeEngine
{
    public interface IBoard
    {
        void Reset();

        void XorO(int player, int input);

        string HorizontalWin();

        string VerticalWin();

        string DiagonalWin();

        bool Draw();
    }
}
