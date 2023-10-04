using System;
namespace Uppgift_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            string åldertext = Console.ReadLine();
            int ålder = int.Parse(åldertext);

            switch (ålder)
            {
                case 16:
                    {
                        Console.WriteLine("Du får vara med i tävlingen");
                        break;
                    }
                case 17:
                    {
                        Console.WriteLine("Du får vara med i tävlingen");
                        break;
                    }
                case 18:
                    {
                        Console.WriteLine("Du får vara med i tävlingen");
                        break;
                    }
                case 19: 
                    {
                        Console.WriteLine("Du får vara med i tävlingen");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Du är fel ålder för att vara med.");
                        break;
                    }

            }
          Console.ReadLine();
        }
    }
}