using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    internal class wireframe
    {
        static void Main(string[] args)
        {
            //TODO Create A Player
            Console.WriteLine("Dungeon of Death");
            bool play = true; //COUNTER

            do
            {
                Console.WriteLine("A. Attack\nB.Run Away\nC. Character Info\nD. Monster Info\nE. Exit");
                string playerChoice = Console.ReadLine().ToUpper();

                Console.Clear();

                switch (playerChoice)
                {
                    case "A":
                    case "Attack":
                        Console.WriteLine();
                        break;

                    case "B":
                    case "RUN AWAY":
                        Console.WriteLine();
                        break;

                    case "C":
                    case "CHARACTER INFO":
                        Console.WriteLine();
                        break;

                    case "D":
                    case "MONSTER INFO":
                        Console.WriteLine();
                        break;

                    case "E":
                    case "EXIT":
                        Console.WriteLine();
                        play = false;
                        break;
                }


            } while (play); //CONDITION



        }
    }
}
