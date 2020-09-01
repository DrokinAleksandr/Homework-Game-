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
            int cheatPlayer, basketWeight, simplePlayer, notepadPlayer, uberPlayer, uberNumber = 40, countNotepadMass = 0;
            double priceProduct;
           
            continueProg = "yes";
            while (continueProg == "yes")
            {
                int[] mainMass = new int[400];
                for (int j = 0; j < 400; j++)
                {
                    //matrix[j] = value;

                    Console.WriteLine("=========Game=========");
                    Console.WriteLine("Write basket number:");
                    basketWeight = CheckInt();

                    simplePlayer = Players.SimplePlayer();
                    if (basketWeight == simplePlayer)
                    {
                        
                        Console.WriteLine("Simple Player Win.");
                        Console.ReadKey();
                        break;
                    }
                    mainMass[j] = simplePlayer;
                    j++;

                    uberPlayer = Players.UberPlayer(uberNumber);

                    if (basketWeight == uberPlayer)
                    {
                        
                        Console.WriteLine("Uber Player Win.");
                        Console.ReadKey();
                        break;
                    }
                    mainMass[j] = uberPlayer;
                    uberNumber++;
                    j++;


                    int[] notepadMass = new int[400];
                    notepadPlayer = Players.notepadPlayer(notepadMass); 
                    

                    if (basketWeight == notepadPlayer)
                    {
                        
                        Console.WriteLine("Notepad Player Win.");
                        Console.ReadKey();
                        break;
                    }
                    notepadMass[countNotepadMass] = uberPlayer;
                    mainMass[j] = uberPlayer;
                    countNotepadMass++;
                    j++;


                    int[] notepadMass = new int[400];
                    cheatPlayer = Players.notepadPlayer(notepadMass);


                    if (basketWeight == notepadPlayer)
                    {

                        Console.WriteLine("Notepad Player Win.");
                        Console.ReadKey();
                        break;
                    }
                    notepadMass[countNotepadMass] = uberPlayer;
                    mainMass[j] = uberPlayer;
                    countNotepadMass++;
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

