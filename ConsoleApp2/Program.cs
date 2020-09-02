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
            
            int mainCounter, cheatPlayer, basketWeight, simplePlayer, notepadPlayer, uberPlayer, uberNumber = 40, countNotepadMass = 0, ubercheatPlayer;
            bool continueProg;

            continueProg = true;
            Console.WriteLine("=========Game=========");
            Console.Write("Write basket number: ");
            basketWeight = CheckInt();

            while (continueProg == true)
            {
                int[] mainMass = new int[200];
                int[] notepadMass = new int[200];
                for ( mainCounter = 0; mainCounter < 100; mainCounter++)
                {   

                    //Simple Player
                    simplePlayer = Players.SimplePlayer();
                    if (basketWeight == simplePlayer)
                    {
                        Console.WriteLine("Vasya (Simple Player) Win.");
                        Console.ReadKey();
                        continueProg = false;
                        break;
                    }
                    mainMass[mainCounter] = simplePlayer;
                    mainCounter++;

                    //Uber Player
                    uberPlayer = Players.UberPlayer(uberNumber);
                    if (basketWeight == uberPlayer)
                    {
                        Console.WriteLine("Kolya (Uber Player) Win.");
                        Console.ReadKey();
                        continueProg = false;
                        break;
                    }
                    mainMass[mainCounter] = uberPlayer;
                    uberNumber++;
                    mainCounter++;

                    //Notepad Player
                    notepadPlayer = Players.notepadPlayer(notepadMass); 
                    if (basketWeight == notepadPlayer)
                    {
                        Console.WriteLine("Gena (Notepad Player) Win.");
                        Console.ReadKey();
                        continueProg = false;
                        break;
                    }
                    notepadMass[countNotepadMass] = notepadPlayer;
                    mainMass[mainCounter] = notepadPlayer;
                    countNotepadMass++;
                    mainCounter++;

                    //Cheat Player
                    cheatPlayer = Players.cheatPlayer(mainMass);
                    if (basketWeight == cheatPlayer)
                    {
                        Console.WriteLine("Vova (Cheat Player) Win.");
                        continueProg = false;
                        break;
                    }
                    mainMass[mainCounter] = cheatPlayer;
                    mainCounter++;

                    //Uber Cheat Player
                    ubercheatPlayer = Players.ubercheatPlayer(mainMass, uberNumber);
                    if (basketWeight == ubercheatPlayer)
                    {
                        Console.WriteLine("Fedya (UberCheat Player) Win.");
                        continueProg = false;
                        break;
                    }
                    mainMass[mainCounter] = ubercheatPlayer;
                    mainCounter++;
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

