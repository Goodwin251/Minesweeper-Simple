namespace Sapper_Game
{
    public partial class Start_display : Form
    {
        public Start_display()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        private void NewGameButton_Click(object sender, EventArgs e)
        {
            SapperMap NewGame = new();
            Setup(NewGame);
            this.Hide();
            NewGame.ShowDialog();
            this.Show();
        }

        private void Setup(SapperMap NewGame)
        {
            string MapShape = "";
            string Difficulty = "";

            foreach (Control obj in SizePanel.Controls)
            {
                if (obj is RadioButton button)
                {
                    if (button.Checked) { MapShape = button.Name; }
                }
            }
            foreach (Control obj in DifficultyPanel.Controls)
            {
                if (obj is RadioButton button)
                {
                    if (button.Checked) { Difficulty = button.Name; }
                }
            }

            NewGame.StartPosition = FormStartPosition.CenterScreen;

            NewGame.MapSettings(MapShape, Difficulty);
        }
    }
}
