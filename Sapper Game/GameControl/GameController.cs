using Microsoft.VisualBasic.Devices;
using Sapper_Game.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sapper_Game.GameControl
{
    internal partial class GameController
    {
        private readonly int MapSize;
        private readonly int BombsAmount;

        private const int CellSize = 80;
        private readonly Form map;

        private readonly int[,] cells;
        private readonly Button[,] buttons;

        private bool FirstClick;
        public GameController(int MapSize, int BombsAmount, Form newform)
        {
            this.MapSize = MapSize;
            this.BombsAmount = BombsAmount;
            this.cells = new int[MapSize, MapSize];

            map = newform;
            buttons = new Button[MapSize, MapSize];
            InitMap();
        }

        private void InitMap()
        {
            map.ClientSize = new Size(CellSize * MapSize, CellSize * MapSize);
            FirstClick = true;

            for (int i = 0; i < MapSize; i++)
            {
                for (int j = 0; j < MapSize; j++)
                {
                    cells[i, j] = 0;
                }
            }

            for (int i = 0; i < MapSize; i++)
            {
                for (int j = 0; j < MapSize; j++)
                {
                    Button button = new()
                    {
                        Location = new Point(i * CellSize, j * CellSize),
                        Size = new Size(CellSize, CellSize),
                        Font = new Font("Arial", 50, FontStyle.Bold, GraphicsUnit.Pixel),
                        ForeColor = Color.CadetBlue,
                    };
                    button.MouseUp += new MouseEventHandler(ClickHandler!);
                    map.Controls.Add(button);
                    buttons[i, j] = button;
                }
            }
        }
        private void BombGeneration(int X, int Y)
        {
            Random rand = new();

            for (int i = 0; i < BombsAmount; i++)
            {
                int randI = rand.Next(0, MapSize);
                int randJ = rand.Next(0, MapSize);


                while (cells[randI, randJ] == -1 ||
                Math.Abs(X - randI) <= 1 && Math.Abs(Y - randJ) <= 1)
                {
                    randI = rand.Next(0, MapSize);
                    randJ = rand.Next(0, MapSize);
                }

                cells[randI, randJ] = -1;
            }
        }    
    }
}
