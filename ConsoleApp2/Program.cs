using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLib;

namespace Homework_Warehouse_
{
    class Program
    {
        static void Main(string[] args)
        {
            String continueProg, expirationDate;
            int menuNumber, basketWeight, simplePlayer, notepadPlayer, uberPlayer,uberNumber;
            double priceProduct;
            uberNumber = 40;
            continueProg = "yes";
            while (continueProg == "yes")
            {
                int[] matrix = new int[400];
                for (int j = 0; j < 400; j++)
                {
                    //matrix[j] = value;
                
                Console.WriteLine("=========Game=========");
                Console.WriteLine("Write basket number:");
                basketWeight = CheckInt();

                simplePlayer = Players.SimplePlayer();
                if (basketWeight == simplePlayer)
                {
                    break;
                    Console.WriteLine("Simple Player Win.");
                    Console.ReadKey();
                }
                    matrix[j] = simplePlayer;
                    j++;

                uberPlayer = Players.UberPlayer(uberNumber);

                if (basketWeight == uberPlayer)
                {
                    break;
                    Console.WriteLine("Uber Player Win.");
                    Console.ReadKey();
                }
                matrix[j] = uberPlayer;
                uberNumber++;
                j++;







                }

             
            }
            //Console.ReadKey();
        }

        static int CheckInt()
        {
            int checkResultInt;

            while (!int.TryParse(Console.ReadLine(), out checkResultInt))
            {
                Console.Write("Error, please write number: ");
            }

            return checkResultInt;
        }
        static double CheckDouble()
        {
            double checkResultDouble;

            while (!double.TryParse(Console.ReadLine(), out checkResultDouble))
            {
                Console.Write("Error, please write number: ");
            }

            return checkResultDouble;
        }
    }
}

