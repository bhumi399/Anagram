using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Programs
{
    class anagramhu
    {
        static void Main(string[] args)
        {
            Console.Write("Insert 1st word :");
            string word1 = Console.ReadLine();
            Console.Write("Insert 2nd word :");
            string word2 = Console.ReadLine();

            char[] char1 = word1.ToLower().ToCharArray();
            char[] char2 = word2.ToLower().ToCharArray();

            Array.Sort(char1);
            Array.Sort(char2);

            string newword1 = new string(char1);
            string newword2 = new string(char2);

            if (newword1 == newword2)
            {
                Console.WriteLine("Both words are anagrams");
            }
            else
            {
                Console.WriteLine("No they ain't anagrams");
            }

            Console.ReadLine();


        }
    }
}
