using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson9DzThree;
class Program
{
  static void Main(string[] args)
  {
    Console.Write("Введите текст: ");
    string text = Console.ReadLine();

    string[] words = text.Split(new[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

    Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

    foreach (string word in words)
    {
      if (wordFrequency.ContainsKey(word))
      {
        wordFrequency[word]++;
      }
      else
      {
        wordFrequency[word] = 1;
      }
    }

    Console.WriteLine("Уникальные слова и их количество:");
    foreach (var pair in wordFrequency)
    {
      Console.WriteLine($"{pair.Key} - {pair.Value}");
    }
    Console.ReadKey();
  }
}