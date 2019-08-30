using System;

namespace ConsoleApplication
{
    public class Program
    {


        public static String Encrypt(string letters)
        {
            char[] chr = letters.ToCharArray();
            string hash = "";

            foreach (char item in chr)
            {
                int nth = Convert.ToInt32(item) - 64;

                if (nth % 2 == 0)
                {
                    hash = hash + 'e';
                    nth = nth / 2;
                    hash += nth.ToString();
                    Console.WriteLine($"Even harsh value  {nth}");

                }
                else
                {
                    hash = hash + 'o';
                    nth = nth * 3 + 1;
                    hash += nth.ToString();
                    Console.WriteLine($"Odd harsh value  {nth}");
                    
                }
            }

            return hash;
        }



        public static void Main(string[] args)
        {


            Console.WriteLine("Please Input The letters you wish to Encrypt");


            string letters = Console.ReadLine();

            Console.WriteLine($"Encryption Result  {Encrypt(letters)}");
            Console.ReadLine();

        }



    }
}