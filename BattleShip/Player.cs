using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleShip
{


    public class Player
    {
        public string PlayerName;

        ShipSet NewShipSet = new ShipSet();

        public Player(string PlayerName)
        {
            this.PlayerName = PlayerName;
        }

        public string NamePlayer()
        {
            string Name = Console.ReadLine();

            if (Name.Length < 10)
            {
                return Name;
            }
            else
            {
                Console.WriteLine("Too many characters! Try again.");
                return NamePlayer();
            }
        }

        public int[] AskLook()
        {
            Console.WriteLine("What would you like to look at, " + PlayerName + "?");
            Console.WriteLine("Enter a grid entry i.e. 'A1' ");
            return Convert(Console.ReadLine());
        }

        public int[] Convert(string coordsString)
        {
            int[] coordsSet = new int[2];

            int coordsInt1 = 0;
            int coordsInt2 = 0;
            int index1 = 0;

            int index2_1 = 1;
            int index2_2 = 2;

            if (index1 == coordsString.IndexOf("A"))
            {
                coordsInt1 = 1;
            }
            else if (index1 == coordsString.IndexOf("B"))
            {
                coordsInt1 = 2;
            }
            else if (index1 == coordsString.IndexOf("C"))
            {
                coordsInt1 = 3;
            }
            else if (index1 == coordsString.IndexOf("D"))
            {
                coordsInt1 = 4;
            }
            else if (index1 == coordsString.IndexOf("E"))
            {
                coordsInt1 = 5;
            }
            else if (index1 == coordsString.IndexOf("F"))
            {
                coordsInt1 = 6;
            }
            else if (index1 == coordsString.IndexOf("G"))
            {
                coordsInt1 = 7;
            }
            else if (index1 == coordsString.IndexOf("H"))
            {
                coordsInt1 = 8;
            }
            else if (index1 == coordsString.IndexOf("I"))
            {
                coordsInt1 = 9;
            }
            else if (index1 == coordsString.IndexOf("J"))
            {
                coordsInt1 = 10;
            }
            else if (index1 == coordsString.IndexOf("K"))
            {
                coordsInt1 = 11;
            }
            else if (index1 == coordsString.IndexOf("L"))
            {
                coordsInt1 = 12;
            }
            else if (index1 == coordsString.IndexOf("M"))
            {
                coordsInt1 = 13;
            }
            else if (index1 == coordsString.IndexOf("N"))
            {
                coordsInt1 = 14;
            }
            else if (index1 == coordsString.IndexOf("O"))
            {
                coordsInt1 = 15;
            }
            else if (index1 == coordsString.IndexOf("P"))
            {
                coordsInt1 = 16;
            }
            else if (index1 == coordsString.IndexOf("Q"))
            {
                coordsInt1 = 17;
            }
            else if (index1 == coordsString.IndexOf("R"))
            {
                coordsInt1 = 18;
            }
            else if (index1 == coordsString.IndexOf("S"))
            {
                coordsInt1 = 19;
            }
            else if (index1 == coordsString.IndexOf("T"))
            {
                coordsInt1 = 20;
            }
            else
            {
                Console.WriteLine("Invalid coordinate. Please try again.");
                AskLook();
            }

            if (index2_1 == coordsString.IndexOf("1") && coordsString.Length == 2)
            {
                coordsInt2 = 1;
            }
            else if (index2_1 == coordsString.IndexOf("2") && coordsString.Length == 2)
            {
                coordsInt2 = 2;
            }
            else if (index2_1 == coordsString.IndexOf("3") && coordsString.Length == 2)
            {
                coordsInt2 = 3;
            }
            else if (index2_1 == coordsString.IndexOf("4") && coordsString.Length == 2)
            {
                coordsInt2 = 4;
            }
            else if (index2_1 == coordsString.IndexOf("5") && coordsString.Length == 2)
            {
                coordsInt2 = 5;
            }
            else if (index2_1 == coordsString.IndexOf("6") && coordsString.Length == 2)
            {
                coordsInt2 = 6;
            }
            else if (index2_1 == coordsString.IndexOf("7") && coordsString.Length == 2)
            {
                coordsInt2 = 7;
            }
            else if (index2_1 == coordsString.IndexOf("8") && coordsString.Length == 2)
            {
                coordsInt2 = 8;
            }
            else if (index2_1 == coordsString.IndexOf("9") && coordsString.Length == 2)
            {
                coordsInt2 = 9;
            }
            else if (index2_1 == coordsString.IndexOf("1") && index2_2 == coordsString.IndexOf("0") && coordsString.Length == 3)
            {
                coordsInt2 = 10;
            }
            else if (index2_1 == coordsString.IndexOf("1") && index2_2 == coordsString.IndexOf("1") && coordsString.Length == 3)
            {
                coordsInt2 = 11;
            }
            else if (index2_1 == coordsString.IndexOf("1") && index2_2 == coordsString.IndexOf("2") && coordsString.Length == 3)
            {
                coordsInt2 = 12;
            }
            else if (index2_1 == coordsString.IndexOf("1") && index2_2 == coordsString.IndexOf("3") && coordsString.Length == 3)
            {
                coordsInt2 = 13;
            }
            else if (index2_1 == coordsString.IndexOf("1") && index2_2 == coordsString.IndexOf("4") && coordsString.Length == 3)
            {
                coordsInt2 = 14;
            }
            else if (index2_1 == coordsString.IndexOf("1") && index2_2 == coordsString.IndexOf("5") && coordsString.Length == 3)
            {
                coordsInt2 = 15;
            }
            else if (index2_1 == coordsString.IndexOf("1") && index2_2 == coordsString.IndexOf("6") && coordsString.Length == 3)
            {
                coordsInt2 = 16;
            }
            else if (index2_1 == coordsString.IndexOf("1") && index2_2 == coordsString.IndexOf("7") && coordsString.Length == 3)
            {
                coordsInt2 = 17;
            }
            else if (index2_1 == coordsString.IndexOf("1") && index2_2 == coordsString.IndexOf("8") && coordsString.Length == 3)
            {
                coordsInt2 = 18;
            }
            else if (index2_1 == coordsString.IndexOf("1") && index2_2 == coordsString.IndexOf("9") && coordsString.Length == 3)
            {
                coordsInt2 = 19;
            }
            else if (index2_1 == coordsString.IndexOf("2") && index2_2 == coordsString.IndexOf("0") && coordsString.Length == 3)
            {
                coordsInt2 = 20;
            }
            else
            {
                Console.WriteLine("Invalid coordinate. Please try again.");
                AskLook();
            }

            coordsSet[0] = coordsInt1;
            coordsSet[1] = coordsInt2;

            return coordsSet;
        }
    }

    
}