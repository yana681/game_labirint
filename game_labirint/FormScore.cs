using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace game_labirint
{
    public partial class FormScore : Form
    {
        public FormScore()
        {
            InitializeComponent();
        }

        private void FormScore_Load(object sender, EventArgs e)
        {
            string[] names = new string[10];
            string[] scores = new string[10];
            string[] times = new string[10];
            int length = 0;

            StreamReader sr = new StreamReader("scoreGame.txt");
            try
            {
                
                while (!sr.EndOfStream && length < 10)
                {
                    string line = sr.ReadLine();
                    string[] temp = line.Split('|');
                    if (temp.Length == 3)
                    {
                        names[length] = temp[0];
                        scores[length] = temp[1];
                        times[length] = temp[2]; 
                        length++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при чтении файла: " + ex.Message);
            }
            finally
            {
                sr.Close();
            }
            for (int i = 0; i < length; i++)
            {
                ListViewItem item = new ListViewItem(new string[] { names[i], scores[i], times[i] });
                listViewScoreOfUsers.Items.Add(item);
            }
        }
    }
}
