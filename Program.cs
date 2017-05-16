using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGame
{
    class Program
    {
        static void Play()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Random rd = new Random();
            int numOfPCGet = rd.Next(501);
            int numOfPlayerGet;
            int qtyOfGuess = 0;
            Console.WriteLine("PC has get a number in [0..500], please guess it:");
            while (true)
            {
                numOfPlayerGet = int.Parse(Console.ReadLine());
                qtyOfGuess++;
                Console.WriteLine("You're guessing {0} times",qtyOfGuess);
                if (numOfPlayerGet==numOfPCGet)//win
                {
                    Console.WriteLine("Congratulation! You had guess exactly number of PC get.");
                    break;
                }
                if(numOfPlayerGet<numOfPCGet)
                {
                    Console.WriteLine("Number which you guess < Number of PC get");
                }
                else
                {
                    Console.WriteLine("Number which you guess > Number of PC get");
                }
                if(qtyOfGuess==7)
                {
                    Console.WriteLine("GAME OVER! You had guess over 7 times.");
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Play();
                Console.WriteLine("Play again?(Y/N):");
                string s = Console.ReadLine();
                if (s == "N")
                    break;
            }
            Console.ReadLine();
        }
    }
}
