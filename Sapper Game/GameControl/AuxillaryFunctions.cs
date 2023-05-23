using Sapper_Game.Properties;
using System.Security.Permissions;

namespace Sapper_Game.GameControl 
{ 
    partial class GameController
    {
        private void Victory()
        {
            bool win = true;
            for (int i = 0; i < MapSize; i++)
            {
                for (int j = 0; j < MapSize; j++)
                {
                    if (cells[i, j] == -1 || cells[i,j] == 10)
                    { win = false; }
                }
            }
            if (win)
            {
                MessageBox.Show("Ви перемогли!");
                map.Close();
            }
        }
        private void Defeat(int X, int Y)
        {
            cells[X, Y] = -100;
            buttons[X, Y].Image = Resources.Explosion;

            ShowAllBombs();
            MessageBox.Show("Ви програли!");
            map.Close();
        }
        private void ShowAllBombs()
        {
            for (int i = 0; i < MapSize; i++)
            {
                for (int j = 0; j < MapSize; j++)
                {
                    if (cells[i, j] == -1)
                        buttons[i, j].Image = Resources.Bomb;
                    if (cells[i, j] == -2)
                        buttons[i, j].BackgroundImage = Resources.Bomb;
                }
            }
        }
        private bool Inbound(int i, int j, int X, int Y)
        {
            if (X - i < 0 || X - i >= MapSize) { return false; }
            if (Y - j < 0 || Y - j >= MapSize) { return false; }
            return true;
        }
        private void FindIndex(ref int X, ref int Y, Button PressedButton) 
        {
            X = PressedButton.Location.X / CellSize;
            Y = PressedButton.Location.Y / CellSize;
        }
    }
}