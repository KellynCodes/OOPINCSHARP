using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPINCSHARP
{
    public class PigLatin
    {
        public static void Piglan()
        {
            while (true)
            {

                Console.WriteLine("Enter a sentence to convert to PigLatin:");
                string sentence = Console.ReadLine();
                var pigLatin = GetSentenceInPigLatin(sentence);
                Console.WriteLine(pigLatin);
            }
        }

        private static string GetSentenceInPigLatin(string sentence)
        {
            const string vowels = "AEIOUaeio";
            var returnSentence = "";
            foreach (var word in sentence.Split())
            {
                var firstLetter = word.Substring(0, 1);
                var restOfWord = word.Substring(1, word.Length - 1);
                var currentLetter = vowels.IndexOf(firstLetter, StringComparison.Ordinal);

                if (currentLetter == -1)
                {
                    returnSentence += restOfWord + firstLetter + "ay ";
                }
                else
                {
                    returnSentence += word + "way ";
                }
            }
            return returnSentence;
        }
    }
}