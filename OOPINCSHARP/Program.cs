using OOPINCSHARPOOPS;

namespace OOPINCSHARP
{
    public class Program
    {

        public string quitGame;
        public bool StopConversion;

        public Program()
        {
            StopConversion = true;
             quitGame =  Console.ReadLine() ?? "YES";
        }

        public static void Main(string[] args)
        {
            //LeapYear.CheckLeapYears();
            //NumberGueser.Guess();
            //PigLatin.ConvertWorld();

            //Number Conversion
            Program ProgramClass = new Program();
            while (ProgramClass.StopConversion)
            {
                string isNegative = "";
                try
                {
                    Console.WriteLine("Enter a Number to convert to currency");
                    string number = Console.ReadLine();
                    number = Convert.ToDouble(number).ToString();

                    if (number.Contains("-"))
                    {
                        isNegative = "Minus ";
                        number = number.Substring(1, number.Length - 1);
                    }
                    if (number == "0")
                    {
                        Console.WriteLine("The number in currency fomat is \nZero Only");
                    }
                    else
                    {
                        Console.WriteLine("The number in currency fomat is \n{0}", isNegative + NumberToWord.ConvertToWords(number));
                    }
                    Console.WriteLine("Do want to quit [YES/NO]");
                 string inputToQuitGame =  ProgramClass.quitGame.ToUpper();
                    if(inputToQuitGame == "YES")
                    {
                        ProgramClass.StopConversion = false;

                    }else if(inputToQuitGame == "NO")
                    {
                        ProgramClass.StopConversion = true;

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

    }
}