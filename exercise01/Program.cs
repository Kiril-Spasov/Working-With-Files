using System;
using System.IO;
using System.Collections.Generic;

namespace exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\spaso\OneDrive\Документи\CodeWithMosh\5.Working-With-Files\exercise.txt";
            var allChars = File.ReadAllText(path);
            var words = allChars.Split(" ");

            var longestWord = words[0];

            for (var i = 0; i < words.Length; i++)
            {
                string item = words[i];
                if (item.Length > longestWord.Length)
                    longestWord = item;
            }

            Console.WriteLine("Total words in the text: {0}", words.Length);
            Console.WriteLine("Longest word: {0}", longestWord);
        }
    }
}
