//Kyson Hensley
//RCET2265
//Fall 2025
//Fortune Cookie Program
//https://github.com/kysonhensley/FortuneCookie.git

namespace FortuneCookie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 5;
            int currentRandomNumber = 0;
            Random randomNumber = new Random();

            for (int i = 0; i < 1; i++)
            {
                currentRandomNumber = randomNumber.Next(1, 7); // Random number between 1 and 6
            }

            if (currentRandomNumber == 1)
            {
                Console.WriteLine("You will recieve luck in the next 7 days!");
            }
            else if (currentRandomNumber == 2)
            {
                Console.WriteLine("You bring light into this world!");
            }
            else if (currentRandomNumber == 3)
            {
                Console.WriteLine("An unexpected opportunity will knock when you least expect it—be ready to answer.");
            }
            else if (currentRandomNumber == 4)
            {
                Console.WriteLine("Your kindness today will open doors tomorrow.");
            }
            else if (currentRandomNumber == 5)
            {
                Console.WriteLine("Adventure is waiting just outside your comfort zone.");
            }
            else if (currentRandomNumber == 6)
            {
                Console.WriteLine("The effort you put in now will reward you tenfold soon.");
            }


            Console.WriteLine("Press enter to close program");

            //pause
            Console.Read();
        
        }
    }
}
