using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace game_labirint
{
    public partial class FormGame : Form
    {
        int sec = 0, min = 0;
        int cntLetterReserv, cntLetter = 0;
        int playerX = 1, playerY = 1;
        MazeManager mazeManager;
        char collectLetter;
        Random rnd = new Random();
        public int level;
        int currentWordIndex = 0;
        WordManager wordManager;

        public FormGame(int selectedLevel)
        {
            InitializeComponent();
            level = selectedLevel;
            timer1.Interval = 1000;
            wordManager = new WordManager(level);
            mazeManager = new MazeManager(); 
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            dataGridViewLab.DefaultCellStyle.Font = new Font("Georgia", 14, FontStyle.Bold);
            dataGridViewLab.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            NewGame();
        }

        void NewGame()
        {
            sec = min = cntLetter = cntLetterReserv = 0;
            labelTimer.Text = $"{min:D2}:{sec:D2}";
            playerX = playerY = 1;
            labelPoint.Text = cntLetterReserv + " Балл(ов)";
            mazeManager.LoadRandomMaze();
            wordManager.GenerateWords();
            currentWordIndex = 0;
            SetCurrentWordToLabel();
            LoadMaze();
            mazeManager.PlaceWordInMaze(wordManager.GetCurrentOssetianWord(currentWordIndex));
            UpdatePlayerPosition();
            timer1.Start();
        }

        void LoadMaze()
        {
            dataGridViewLab.ColumnCount = 20;
            dataGridViewLab.RowCount = 20;

            for (int i = 0; i < 20; i++)
            {
                dataGridViewLab.Rows[i].Height = 28;
                for (int j = 0; j < 20; j++)
                {
                    dataGridViewLab.Columns[j].Width = 28;
                    Color cellColor;

                    if (mazeManager.Maze[i, j] == 1)
                    {
                        cellColor = Color.SaddleBrown; // Это стена
                    }
                    else if (mazeManager.Maze[i, j] == 2) 
                    {
                        cellColor = Color.DarkOrange; //Горящая плитка
                    }
                    else
                    {
                        cellColor = Color.Beige; //проход
                    }
                    dataGridViewLab.Rows[i].Cells[j].Style.BackColor = cellColor;
                }
            }
        }

        void SetCurrentWordToLabel()
        {
            if (currentWordIndex < wordManager.WordCount)
            {
                string ossetianWord = wordManager.GetCurrentOssetianWord(currentWordIndex);
                string russianTranslation = wordManager.GetCurrentRussianTranslation(currentWordIndex);
                if (level == 2)
                {
                    labelHiddenWord.Text = russianTranslation;
                }
                else
                {
                    labelHiddenWord.Text = ossetianWord + " - " + russianTranslation;
                }
                labelCollectWord.Text = new string('*', ossetianWord.Length);
            }
        }
        void UpdatePlayerPosition()
        {
            for (int row = 0; row < 20; row++)
            {
                for (int col = 0; col < 20; col++)
                {
                    var currentCell = dataGridViewLab.Rows[row].Cells[col];
                    char letter = mazeManager.Letters[row, col];
                    if (letter != '\0')
                        currentCell.Value = letter.ToString();
                    else
                        currentCell.Value = "";
                    if (row == playerY && col == playerX)
                    {
                        currentCell.Style.BackColor = Color.Blue;
                    }
                    else if (mazeManager.Maze[row, col] == 1)
                    {
                        currentCell.Style.BackColor = Color.SaddleBrown;
                    }
                    else if (mazeManager.Maze[row, col] == 2)
                    {
                        currentCell.Style.BackColor = Color.DarkOrange;
                    }
                    else
                    {
                        currentCell.Style.BackColor = Color.Beige;
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            if (sec >= 60) { sec = 0; min++; }
            labelTimer.Text = $"{min:D2}:{sec:D2}";
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            int newX = playerX;
            int newY = playerY;

            switch (keyData)
            {
                case Keys.Up: newY--; break;
                case Keys.Down: newY++; break;
                case Keys.Left: newX--; break;
                case Keys.Right: newX++; break;
            }

            if (newX < 0 || newX >= 20 || newY < 0 || newY >= 20 || mazeManager.Maze[newY, newX] == 1)
                return true;

            if (mazeManager.Maze[newY, newX] == 2)
            {
                cntLetterReserv -= 1;
                labelPoint.Text = cntLetterReserv + " Балл(ов)";
            }

            if (mazeManager.GetLetterAt(newX, newY) != '\0')
            {
                collectLetter = mazeManager.GetLetterAt(newX, newY);
                char[] chars = labelCollectWord.Text.ToCharArray();
                if (cntLetter < chars.Length)
                {
                    chars[cntLetter] = collectLetter;
                    labelCollectWord.Text = new string(chars);
                }
                cntLetter++;
                cntLetterReserv++;
                labelPoint.Text = cntLetterReserv + " Балл(ов)";
                mazeManager.RemoveLetterAt(newX, newY);
            }

            playerX = newX;
            playerY = newY;
            UpdatePlayerPosition();
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            string expected = wordManager.GetCurrentOssetianWord(currentWordIndex);
            string actual = labelCollectWord.Text;

            if (expected == actual)
            {
                MessageBox.Show("Слово собрано!");
                currentWordIndex++;
                if (currentWordIndex < wordManager.WordCount)
                {
                    SetCurrentWordToLabel();
                    cntLetter = 0;
                    LoadMaze();
                    mazeManager.PlaceWordInMaze(wordManager.GetCurrentOssetianWord(currentWordIndex));
                    UpdatePlayerPosition();
                }
                else
                {
                    MessageBox.Show("Уровень завершён!");
                    timer1.Stop();
                    FormUsersName formUsersName = new FormUsersName(cntLetterReserv, labelTimer.Text);
                    formUsersName.ShowDialog();
                    this.Close();

                }
            }
            else
            {
                MessageBox.Show("Слово неверное! Попробуйте снова.");
                cntLetter = 0;
                LoadMaze();
                mazeManager.PlaceWordInMaze(wordManager.GetCurrentOssetianWord(currentWordIndex));
                UpdatePlayerPosition();
                labelCollectWord.Text = new string('*', expected.Length);
            }
        }

    }
}
