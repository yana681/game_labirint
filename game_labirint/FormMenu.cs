using System;
using System.Windows.Forms;

namespace game_labirint
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonTableScore_Click(object sender, EventArgs e)
        {
            FormScore formScore = new FormScore();
            formScore.Show();
        }
        private void buttonLevellEasy_Click(object sender, EventArgs e)
        {
            FormGame formGame = new FormGame(1);
            formGame.Show();
        }

        private void buttonLevelHard_Click(object sender, EventArgs e)
        {
            FormGame formGame = new FormGame(2);
            formGame.Show();
        }
    }
}
