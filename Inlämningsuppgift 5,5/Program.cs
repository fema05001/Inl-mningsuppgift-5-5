using System;
namespace Uppgift_5_5
{
    class program
    {
        static void Main(string[] args)
        {
            Random random = new Random(9);
            Console.WriteLine("Skriv in antal frågor du vill ställa till programet");
            string a =Console.ReadLine();
            int b =int.Parse(a);
            Console.WriteLine(" ");
            Console.WriteLine("Ställ en fråga");
            for (int i = 0; i < b; i++)
            {
                
                String[] Svar = new string[10];
                Svar[0] = ("Ja ");
                Svar[1] = ("Nej ");
                Svar[2] = ("Kanske ");
                Svar[3] = ("Troligtviss inte ");
                Svar[4] = ("Möjligen ");
                Svar[5] = ("Absolut ");
                Svar[6] = ("Antagligen ");
                Svar[7] = ("Definitivt ");
                Svar[8] = ("Aldrig ");
                Svar[9] = ("Säkert");

               string c = Console.ReadLine();
               for (int j = 0; j < Svar.Length; j++)
                {
                    if (c == "a")
                    {
                        break;
                    }
                }

               
                Console.WriteLine(" ");
                Console.WriteLine(Svar[random.Next(10)]);

            }
        }
    }
}