using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class EnglishFrenchDictionary
    {
        private Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

        public void AddWord(string FRWord, List<string> Translation)
        {
            if (!dictionary.ContainsKey(FRWord))
            {
                dictionary.Add(FRWord, Translation);
                Console.WriteLine($"Слово'{FRWord}' добавлено.");
            }
            else
            {
                Console.WriteLine($"Слово '{FRWord}' уже существует.");
            }
        }
        public void RemoveWord(string FRWord)
        {
            if (dictionary.ContainsKey(FRWord))
            {
                dictionary.Remove(FRWord);
                Console.WriteLine($"Слово '{FRWord}' удалено.");
            }
            else
            {
                Console.WriteLine($"Слово '{FRWord}' не найдено.");
            }
        }
        public void AddTranslation(string FRWord, string Translation)
        {
            if (dictionary.ContainsKey(FRWord))
            {
                dictionary[FRWord].Add(Translation);
                Console.WriteLine($"Перевод '{Translation}' к слову '{FRWord}' добавлен.");
            }
            else
            {
                Console.WriteLine($"Слово '{FRWord}' не найдено.");
            }
        }
        public void RemoveTranslation(string FRWord, string Translation)
        {
            if (dictionary.ContainsKey(FRWord))
            {
                if (dictionary[FRWord].Contains(Translation))
                {
                    dictionary[FRWord].Remove(Translation);
                    Console.WriteLine($"Перевод '{Translation}' для слова '{FRWord}' удалён.");
                }
                else
                {
                    Console.WriteLine($"Перевод '{Translation}' для слова '{FRWord}' не найдено.");
                }
            }
            else
            {
                Console.WriteLine($"Слово '{FRWord}' не найдено.");
            }
        }

        public void EditWord(string OldW, string NewW)
        {
            if (dictionary.ContainsKey(OldW))
            {
                List<string> translate = dictionary[OldW];
                dictionary.Remove(OldW);
                dictionary.Add(NewW, translate);
                Console.WriteLine($"Слово '{OldW}' изменено на '{NewW}'.");
            }
            else
            {
                Console.WriteLine($"Слово '{OldW}' не найдено.");
            }
        }
        public void EditTranslation(string FRWord, string OTranslate, string NTranslate)
        {
            if (dictionary.ContainsKey(FRWord))
            {
                if (dictionary[FRWord].Contains(OTranslate))
                {
                    int word = dictionary[FRWord].IndexOf(OTranslate);
                    dictionary[FRWord][word] = NTranslate;
                    Console.WriteLine($"Перевод '{OTranslate}' изменён на '{NTranslate}' для слова '{FRWord}'.");
                }
                else
                {
                    Console.WriteLine($"Перевод '{OTranslate}' для слова '{FRWord}' не найден.");
                }
            }
            else
            {
                Console.WriteLine($"Слово '{FRWord}' не найдено.");
            }
        }
        public void SearchTranslation(string FRWord)
        {
            if (dictionary.ContainsKey(FRWord))
            {
                Console.WriteLine($"Перевод для слова '{FRWord}':");
                foreach (var translation in dictionary[FRWord])
                {
                    Console.WriteLine(translation);
                }
            }
            else
            {
                Console.WriteLine($"Слово '{FRWord}' не найдено.");
            }
        }
    }
}
