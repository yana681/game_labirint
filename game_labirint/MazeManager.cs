using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_labirint
{
    public class MazeManager
    {
        public int[,] Maze { get; private set; }
        public char[,] Letters { get; private set; }
        public List<Point> LetterPositions { get; private set; } = new List<Point>();

        private Random rnd = new Random();

        public void LoadRandomMaze()
        {
            string filename = "maze/maze" + rnd.Next(1, 6) + ".txt";
            Maze = new int[20, 20];
            using (StreamReader reader = new StreamReader(filename))
            {
                for (int i = 0; i < 20; i++)
                {
                    string s = reader.ReadLine();
                    if (s == null) break;
                    string[] values = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); /*рабиваем строку и удаляем ненужные пробелы*/
                    for (int j = 0; j < Math.Min(20, values.Length); j++)
                        Maze[i, j] = Convert.ToInt32(values[j]);
                }
            }
            Letters = new char[20, 20];
        }

        public void PlaceWordInMaze(string word)
        {
            LetterPositions.Clear();
            for (int i = 0; i < word.Length; i++)
            {
                bool placed = false;
                while (!placed)
                {
                    int x = rnd.Next(0, 20);
                    int y = rnd.Next(0, 20);
                    if (Maze[y, x] == 0 && Letters[y, x] == '\0')
                    {
                        Letters[y, x] = word[i];
                        LetterPositions.Add(new Point(x, y));
                        placed = true;
                    }
                }
            }
        }

        public void RemoveLetterAt(int x, int y)
        {
            Letters[y, x] = '\0';
        }

        public char GetLetterAt(int x, int y)
        {
            return Letters[y, x];
        }
    }
}
