using OOPINCSHARPOOPS;

namespace OOPINCSHARP
{
    public class Program
    {

        public string quitGame;
        public bool StopConversion;
        public static void quitConversion(bool quitGame, string userAnswer)
        {
                    if(userAnswer == "YES")
                    {
                quitGame = false;

                    }else if(userAnswer == "NO")
                    {
                quitGame = true;

                    }
        }

        public Program()
        {
            StopConversion = true;
             quitGame =  Console.ReadLine();
           
        }

        public static void Main(string[] args)
        {
            // LeapYear.CheckLeapYears();
            //NumberGueser.Guess();
            //PigLatin.Piglan();
            //Number Conversion


                var key = "b14ca5898a4e4133bbce2ea2315a1916";

                //Console.WriteLine("Please enter a secret key for the symmetric algorithm.");  
                //var key = Console.ReadLine();  

                Console.WriteLine("Please enter a string for encryption");
                var str = Console.ReadLine();
                var encryptedString = Encrption.EncryptString(key, str);
                Console.WriteLine($"encrypted string = {encryptedString}");

                var decryptedString = Encrption.DecryptString(key, encryptedString);
                Console.WriteLine($"decrypted string = {decryptedString}");

                Console.ReadKey();
        }
    }
}
