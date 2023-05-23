using Sapper_Game.Properties;

namespace Sapper_Game.GameControl 
{ 
    partial class GameController 
    {
        private void ClickHandler(object sender, MouseEventArgs e)
        {
            Button PressedButton = (sender as Button)!;
            if (e.Button.ToString() == "Right")
            {
                RightClickRespond(PressedButton);
            }
            else if (e.Button.ToString() == "Left")
            {
                LeftClickRespond(PressedButton);
            }
        }
        private void RightClickRespond(Button PressedButton)
        {
            int X = 0, Y = 0;
            FindIndex(ref X, ref Y, PressedButton);
            switch (cells[X, Y])
            {
                case 0:
                    if (buttons[X, Y].BackColor != Color.White)
                    {
                        cells[X, Y] = 10;
                        buttons[X, Y].Image = Resources.Flag;
                    }
                    break;
                case 10:
                    cells[X, Y] = 0;
                    buttons[X, Y].Image = null;
                    Victory();
                    break;
                case -1:
                    cells[X, Y] = -2;
                    buttons[X, Y].Image = Resources.Flag;
                    Victory();
                    break;
                case -2:
                    cells[X, Y] = -1;
                    buttons[X, Y].Image = null;
                    break;

            }
        }
        private void LeftClickRespond(Button PressedButton)
        {
            int X = 0, Y = 0;
            FindIndex(ref X, ref Y, PressedButton);

            if (FirstClick)
            {
                BombGeneration(X,Y);
                FirstClick = false;
            }
            if (cells[X, Y] == -1)
            {
                Defeat(X,Y);
            }
            if (cells[X, Y] == 0)
            {
                ShowCellsAround(X, Y);
            }

        }
    }
}