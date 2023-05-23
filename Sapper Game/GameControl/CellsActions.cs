namespace Sapper_Game.GameControl
{
    partial class GameController
    {
        private void ShowCellsAround(int X, int Y)
        {
            if (cells[X, Y] == 0 && buttons[X, Y].BackColor != Color.White)
                BombsAround(X, Y);

            if (cells[X, Y] != 0)
            {
                buttons[X, Y].BackColor = Color.White;
                buttons[X, Y].Text = "" + cells[X, Y];
                return;
            }
            else if (buttons[X, Y].BackColor == Color.White)
            {
                return;
            }
            else
            {
                buttons[X, Y].BackColor = Color.White;
                for (int i = 0, k = X + 1; i < 3; i++)
                {
                    for (int j = 0, g = Y + 1; j < 3; j++)
                    {
                        if (Inbound(i, j, k, g))
                        {
                            ShowCellsAround(k - i, g - j);
                        }
                    }
                }
            }

        }
        private void BombsAround(int X, int Y)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Inbound(i, j, X + 1, Y + 1))
                    {
                        if (cells[X + 1 - i, Y + 1 - j] == -1 || cells[X + 1 - i, Y + 1 - j] == -2)
                        {
                            cells[X, Y] += 1;
                        }
                    }
                }
            }
        }
    }
}
