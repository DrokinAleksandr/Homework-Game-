using System;
using System.Collections.Generic;
using System.Globalization;
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
            
            int j,cheatPlayer, basketWeight, simplePlayer, notepadPlayer, uberPlayer, uberNumber = 40, countNotepadMass = 0, ubercheatPlayer;
            bool continueProg;

            continueProg = true;
            Console.WriteLine("=========Game=========");
            Console.Write("Write basket number: ");
            basketWeight = CheckInt();

            while (continueProg == true)
            {
                int[] mainMass = new int[200];
                int[] notepadMass = new int[200];
                for ( j = 0; j < 100; j++)
                {   

                    //Simple Player
                    simplePlayer = Players.SimplePlayer();
                    if (basketWeight == simplePlayer)
                    {
                        Console.WriteLine("Simple Player Win.");
                        Console.ReadKey();
                        continueProg = false;
                        break;
                    }
                    mainMass[j] = simplePlayer;
                    j++;

                    //Uber Player
                    uberPlayer = Players.UberPlayer(uberNumber);
                    if (basketWeight == uberPlayer)
                    {
                        Console.WriteLine("Uber Player Win.");
                        Console.ReadKey();
                        continueProg = false;
                        break;
                    }
                    mainMass[j] = uberPlayer;
                    uberNumber++;
                    j++;

                    //Notepad Player
                  
                    notepadPlayer = Players.notepadPlayer(notepadMass); 
                    if (basketWeight == notepadPlayer)
                    {
                        Console.WriteLine("Notepad Player Win.");
                        Console.ReadKey();
                        continueProg = false;
                        break;
                    }
                    notepadMass[countNotepadMass] = notepadPlayer;
                    mainMass[j] = notepadPlayer;
                    countNotepadMass++;
                    j++;

                    //Cheat Player
                    cheatPlayer = Players.cheatPlayer(mainMass);
                    if (basketWeight == cheatPlayer)
                    {
                        Console.WriteLine("Cheat Player Win.");
                        Console.ReadKey();
                        continueProg = false;
                        break;
                    }
                    mainMass[j] = cheatPlayer;
                    j++;

                    //Uber Cheat Player
                    ubercheatPlayer = Players.ubercheatPlayer(mainMass, uberNumber);
                    if (basketWeight == ubercheatPlayer)
                    {
                        Console.WriteLine("UberCheat Player Win.");
                       // Console.ReadKey();
                        continueProg = false;
                        break;
                    }
                    mainMass[j] = ubercheatPlayer;
                    j++;
                }
            }
            Console.ReadKey();
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

