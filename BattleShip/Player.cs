using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleShip
{


    public class Player
    {
        private int subCount = 0;
        private int desCount = 0;
        private int batCount = 0;
        private int airCount = 0;

        private string playerName;

        private List<string> downedShips = new List<string>();

        public int SubCount {  get { return subCount; } set { subCount = value; } }
        public int DesCount {  get { return desCount; } set { desCount = value; } }
        public int BatCount {  get { return batCount; } set { batCount = value; } }
        public int AirCount {  get { return airCount; } set { airCount = value; } }

        public string PlayerName { get { return playerName; } set { playerName = value; } }

        public List<string> DownedShips { get { return downedShips; } set { downedShips = value; } }

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
            Console.WriteLine("Where would you like to fire, " + playerName + "?");
            Console.WriteLine("Enter a grid entry i.e. 'A1' ");
            return Convert(Console.ReadLine(), 1, 0);
        }

        public int[] AskShips(int shipNum)
        {
            string shipName = " ";
            if (shipNum == 0)
            {
                shipName = "submarine";
            }
            else if (shipNum == 1)
            {
                shipName = "destroyer";
            }
            else if (shipNum == 2)
            {
                shipName = "battleship";
            }
            else if (shipNum == 3)
            {
                shipName = "aircraft carrier";
            }
            Console.WriteLine("Where would you like to place your " + shipName + ", " + playerName + "?");
            Console.WriteLine("Enter a grid entry i.e. 'A1' ");
            return Convert(Console.ReadLine(), 2, shipNum);
        }

        public int[] Convert(string coordsString, int mode, int currentShipNum)
        {
            int[] coordsSet = new int[2];

            int coordsInt1 = 0;
            int coordsInt2 = 0;
            int index1 = 0;
            int index2 = 1;

            if (index1 == coordsString.IndexOf("A"))
            {
                coordsInt2 = 1;
            }
            else if (index1 == coordsString.IndexOf("B"))
            {
                coordsInt2 = 2;
            }
            else if (index1 == coordsString.IndexOf("C"))
            {
                coordsInt2 = 3;
            }
            else if (index1 == coordsString.IndexOf("D"))
            {
                coordsInt2 = 4;
            }
            else if (index1 == coordsString.IndexOf("E"))
            {
                coordsInt2 = 5;
            }
            else if (index1 == coordsString.IndexOf("F"))
            {
                coordsInt2 = 6;
            }
            else if (index1 == coordsString.IndexOf("G"))
            {
                coordsInt2 = 7;
            }
            else if (index1 == coordsString.IndexOf("H"))
            {
                coordsInt2 = 8;
            }
            else if (index1 == coordsString.IndexOf("I"))
            {
                coordsInt2 = 9;
            }
            else if (index1 == coordsString.IndexOf("J"))
            {
                coordsInt2 = 10;
            }
            else if (index1 == coordsString.IndexOf("K"))
            {
                coordsInt2 = 11;
            }
            else if (index1 == coordsString.IndexOf("L"))
            {
                coordsInt2 = 12;
            }
            else if (index1 == coordsString.IndexOf("M"))
            {
                coordsInt2 = 13;
            }
            else if (index1 == coordsString.IndexOf("N"))
            {
                coordsInt2 = 14;
            }
            else if (index1 == coordsString.IndexOf("O"))
            {
                coordsInt2 = 15;
            }
            else if (index1 == coordsString.IndexOf("P"))
            {
                coordsInt2 = 16;
            }
            else if (index1 == coordsString.IndexOf("Q"))
            {
                coordsInt2 = 17;
            }
            else if (index1 == coordsString.IndexOf("R"))
            {
                coordsInt2 = 18;
            }
            else if (index1 == coordsString.IndexOf("S"))
            {
                coordsInt2 = 19;
            }
            else if (index1 == coordsString.IndexOf("T"))
            {
                coordsInt2 = 20;
            }
            else
            {
                Console.WriteLine("Invalid coordinate. Please try again.");
                if (mode == 1)
                {
                    return AskLook();
                }
                else if (mode == 2)
                {
                    return AskShips(currentShipNum);
                }
            }

            if (index2 == coordsString.IndexOf("1") && coordsString.Length == 2)
            {
                coordsInt1 = 1;
            }
            else if (index2 == coordsString.IndexOf("2") && coordsString.Length == 2)
            {
                coordsInt1 = 2;
            }
            else if (index2 == coordsString.IndexOf("3") && coordsString.Length == 2)
            {
                coordsInt1 = 3;
            }
            else if (index2 == coordsString.IndexOf("4") && coordsString.Length == 2)
            {
                coordsInt1 = 4;
            }
            else if (index2 == coordsString.IndexOf("5") && coordsString.Length == 2)
            {
                coordsInt1 = 5;
            }
            else if (index2 == coordsString.IndexOf("6") && coordsString.Length == 2)
            {
                coordsInt1 = 6;
            }
            else if (index2 == coordsString.IndexOf("7") && coordsString.Length == 2)
            {
                coordsInt1 = 7;
            }
            else if (index2 == coordsString.IndexOf("8") && coordsString.Length == 2)
            {
                coordsInt1 = 8;
            }
            else if (index2 == coordsString.IndexOf("9") && coordsString.Length == 2)
            {
                coordsInt1 = 9;
            }
            else if (index2 == coordsString.IndexOf("10") && coordsString.Length == 3)
            {
                coordsInt1 = 10;
            }
            else if (index2 == coordsString.IndexOf("11") && coordsString.Length == 3)
            {
                coordsInt1 = 11;
            }
            else if (index2 == coordsString.IndexOf("12") && coordsString.Length == 3)
            {
                coordsInt1 = 12;
            }
            else if (index2 == coordsString.IndexOf("13") && coordsString.Length == 3)
            {
                coordsInt1 = 13;
            }
            else if (index2 == coordsString.IndexOf("14") && coordsString.Length == 3)
            {
                coordsInt1 = 14;
            }
            else if (index2 == coordsString.IndexOf("15") && coordsString.Length == 3)
            {
                coordsInt1 = 15;
            }
            else if (index2 == coordsString.IndexOf("16") && coordsString.Length == 3)
            {
                coordsInt1 = 16;
            }
            else if (index2 == coordsString.IndexOf("17") && coordsString.Length == 3)
            {
                coordsInt1 = 17;
            }
            else if (index2 == coordsString.IndexOf("18") && coordsString.Length == 3)
            {
                coordsInt1 = 18;
            }
            else if (index2 == coordsString.IndexOf("19") && coordsString.Length == 3)
            {
                coordsInt1 = 19;
            }
            else if (index2 == coordsString.IndexOf("20") && coordsString.Length == 3)
            {
                coordsInt1 = 20;
            }
            else
            {
                Console.WriteLine("Invalid coordinate. Please try again.");
                if (mode == 1)
                {
                    return AskLook();
                }
                else if (mode == 2)
                {
                    return AskShips(currentShipNum);
                }
            }

            coordsSet[0] = coordsInt1;
            coordsSet[1] = coordsInt2;

            return coordsSet;
        }
    }

    
}