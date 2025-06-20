using System;
using System.IO;
using System.Windows.Forms;

namespace game_labirint
{
    public partial class FormUsersName : Form
    {
        
        public int cntLetterReserv;
        public string timer;
        public FormUsersName(int cntLetter, string time)
        {
            InitializeComponent();
            this.cntLetterReserv = cntLetter;
            this.timer = time;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("scoreGame.txt",true);
            string userName = textBoxName.Text;
            sw.WriteLine(userName + "|" + cntLetterReserv + "|" + timer);
            sw.Close();
            Close(); 
            FormMenu formMenu = new FormMenu();
            formMenu.Show();

        }
    }
}
