using System;

namespace Pascal_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type words seperated by a space: ");
            var input = Console.ReadLine();

            var words = input.Split(" ");
            for (var i = 0; i < words.Length; i++) 
                words[i] = char.ToUpper(words[i][0]).ToString() + words[i].Substring(1).ToLower();
            Console.WriteLine(string.Join("", words));
        }
    }
}
