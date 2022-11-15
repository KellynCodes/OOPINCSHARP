using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPINCSHARP
{
    class PigLatin
    {
        public List<char> array;
        public List<char> Alphabet;
        public List<char> consonants;

        public PigLatin()
        {
          array = new List<char>(); 
          Alphabet = new List<char> {
                'B', 'C', 'Ç', 'D', 'F', 'G', 'H', 'J',
             'K', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'Y', 'X','Z', 'W'
        };
          consonants = new List<char>()  {
                'A', 'E', 'I', 'O', 'U'
        };
        }
        public static void ConvertWorld()
        {
        PigLatin newPig = new PigLatin();
            while (true)
            {
                Console.WriteLine("Enter Text To Convert");
                string UserInputText = Console.ReadLine().ToUpper();
                Console.WriteLine("Text = " + UserInputText);
       for (int i = 0; i < UserInputText.Length; i++)
                {
                    newPig.array.Add(UserInputText[i]);
                }
                if (newPig.Alphabet.Contains(newPig.array[0]) && newPig.consonants.Contains(newPig.array[1]))
                {
                    var newPos = newPig.array[0];
                    newPig.array.Remove(newPos);
                    newPig.array.Add(newPos);
                    TheTextOutPut(newPig.array);
                    for (int J = 0; J < newPig.array.Count; J++)
                    {
                        Console.Write(newPig.array[J]);
                    }
                }
                else if (newPig.Alphabet.Contains(newPig.array[0]) && newPig.Alphabet.Contains(newPig.array[1]))
                {
                    for (int i = 0; i < 2; i++)
                    {
                        var newPos = newPig.array[0];
                        newPig.array.Remove(newPos);
                        newPig.array.Add(newPos);
                    }
                    TheTextOutPut(newPig.array);
                    for (int J = 0; J < newPig.array.Count; J++)
                    {
                        Console.Write(newPig.array[J]);
                    }
                }
                else if (newPig.consonants.Contains(newPig.array[0]))
                {
                    TheTextOutPut(newPig.array);
                    for (int J = 0; J < newPig.array.Count; J++)
                    {
                        Console.Write(newPig.array[J]);
                    }
                }
                Console.WriteLine("\nPress Enter To Continue");
                Console.ReadKey();
            }
        }
        private static void TheTextOutPut(List<char> array)
        {
            for (int i = 0; i < 1; i++)
            {
                array.Add('A');
                array.Add('Y');
            }
        }

        private static void TheTextOutPut2(List<char> array)
        {
            for (int i = 0; i < 1; i++)
            {
                array.Add('Y');
                array.Add('A');
                array.Add('Y');
            }
        }
    }
}