using Sapper_Game.GameControl;

namespace Sapper_Game
{
    public partial class SapperMap : Form
    {

        public SapperMap()
        {
            InitializeComponent();
        }
        public void MapSettings(string MapShape, string Difficulty)
        {
            int MapSize;
            int BombsAmount;

            MapSize = MapShape switch
            {
                "SmallButton" => 4,
                "MediumButton" => 8,
                "LargeButton" => 12,
                _ => 2,
            };
            BombsAmount = Difficulty switch
            {
                "EasyButton" => (int)(MapSize * MapSize * 0.1),
                "NormalButton" => (int)(MapSize * MapSize * 0.15),
                "HardButton" => (int)(MapSize * MapSize * 0.25),
                _ => 1,
            };

            _ = new GameController(MapSize, BombsAmount, this);
        }
    }
}