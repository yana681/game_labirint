using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_labirint
{
    public class WordManager
    {

        private Random rnd = new Random();
        private List<string> currentWords = new List<string>();
        private List<string> currentTranslations = new List<string>();
        private int level;

        private string[][] levels = new string[][]
        {
        new string[] { "ныртæккæ-сейчас", "рæсугъд-красивый", "зондамонæг-наставник", "бирæгъ-волк", "аккаг-достойный" },
        new string[] { "бузныг-спасибо", "рæсугъд-красивый", "зондамонæг-наставник" },
        };

        public WordManager(int level)
        {
            this.level = level;
        }

        public void GenerateWords()
        {
            currentWords.Clear();
            currentTranslations.Clear();
            HashSet<int> usedIndexes = new HashSet<int>();/* чтобы избежать повторов*/

            string[] wordPairs = levels[Math.Min(level - 1, levels.Length - 1)];
            while (currentWords.Count < 3 && usedIndexes.Count < wordPairs.Length)
            {
                int index = rnd.Next(wordPairs.Length);
                if (usedIndexes.Contains(index)) continue;

                usedIndexes.Add(index);
                string[] parts = wordPairs[index].Split('-');
                if (parts.Length == 2)
                {
                    currentWords.Add(parts[0]);
                    currentTranslations.Add(parts[1]);
                }
            }
        }
        public string GetCurrentOssetianWord(int index)
        {
            return currentWords[index];
        }

        public string GetCurrentRussianTranslation(int index)
        {
            return currentTranslations[index];
        }

        // Свойство, которое показывает сколько всего слов
        public int WordCount
        {
            get { return currentWords.Count; } 
        }

    }
}
