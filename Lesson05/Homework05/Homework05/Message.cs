using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework05
{
    static class Message
    {
        static public string text;

        static Message()
        {
            text = "Повседневная практика показывает, что новая модель проект организационной деятельности напрямую зависит от экономической целесообразности опыта принимаемых решений! С другой стороны рамки и место обучения кадров в значительной степени обуславливает создание позиций, занимаемых участниками в отношении поставленных задач. Практический опыт показывает, что выбранный нами инновационный путь представляет собой интересный эксперимент проверки форм воздействия? \nПрактический опыт показывает, что консультация с профессионалами из IT влечет за собой процесс внедрения и модернизации позиций, занимаемых участниками в отношении поставленных задач! С другой стороны повышение уровня гражданского сознания способствует подготовке и реализации существующих финансовых и административных условий? Не следует, однако, забывать о том, что начало повседневной работы по формированию позиции обеспечивает широкому кругу специалистов участие в формировании новых предложений? Таким образом, курс на социально - ориентированный национальный проект обеспечивает актуальность дальнейших направлений развития проекта?";
        }

        
        static public void GetWordsByLength(int len)
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            //Console.WriteLine("Вывод слов, длинной не более " + len + ": " );
            foreach (string word in words)
            {
                if (word == "")
                    continue;
                if (word.Length <= len)
                    Console.Write(word + " ");
            }
        }
                
        static public void DeleteWordByEndChar(char ch)
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            //Console.WriteLine("Будут удалены слова, оканчивающиеся на символ '" + ch + "': ");
            foreach (string word in words)
            {
                if (word == "")
                    continue;
                if (word[word.Length - 1] == ch)
                {
                    Console.Write(word + " ");
                    text.Replace(word, "");
                }
            }
            
        }

       
        static public string FindMaxLengthWord()
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            string maxWord = words[0];
            int max = words[0].Length;

            foreach (string word in words)
            {
                if (word.Length > max)
                {
                    max = word.Length;
                    maxWord = word;
                }
            }
            return maxWord;
        }

        static public StringBuilder GetLongWordsString()
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            StringBuilder result = new StringBuilder();
            int max = Message.FindMaxLengthWord().Length;
            foreach (string word in words)
            {
                if (word.Length == max)
                {
                    result.Append(word.ToLower() + " ");
                }
            }
            return result;
        }

        static public void FrequencyAnalysis(string[] words, string text)
        {
            Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

            string[] textWords = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            foreach (string word in words)
            {
                foreach (string wordInText in textWords)
                {
                    if (word == "")
                        continue;
                    if (wordInText == word)
                    {
                        if (word == "")
                            continue;
                        if (wordFrequency.ContainsKey(word))
                            wordFrequency[word] += 1;
                        else
                            wordFrequency.Add(word, 1);
                    }
                }
            }

            ICollection<string> keys = wordFrequency.Keys;

            String result = String.Format("{0,-10} {1,-10}\n\n", "Слово", "Частота появления");

            foreach (string key in keys)
                result += String.Format("{0,-10} {1,-10:N0}\n",
                                   key, wordFrequency[key]);
            Console.WriteLine($"\n{result}");
        }
    }
}
