using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    public class Destroyer
    {
        bool shipPlaced = false;
        public bool shipError = false;
        public int[] ShipMove(int[] movedCords, Grid Grid, ConsoleKey KeyPress)
        {
            if (KeyPress == ConsoleKey.RightArrow)
            {
                shipPlaced = false;
                shipError = false;
                if ((Grid.arr[movedCords[0], movedCords[1] + 1] == ". " && Grid.arr[movedCords[0] + 1, movedCords[1] + 1] == ". " && Grid.arr[movedCords[0] + 2, movedCords[1] + 1] == ". ") ||
                    (Grid.arr[movedCords[0], movedCords[1] + 1] == "Y " && Grid.arr[movedCords[0] + 1, movedCords[1] + 1] == "Y " && Grid.arr[movedCords[0] + 2, movedCords[1] + 1] == "Y "))
                {
                    Grid.arr[movedCords[0], movedCords[1]] = ". ";
                    Grid.arr[movedCords[0] + 1, movedCords[1]] = ". ";
                    Grid.arr[movedCords[0] + 2, movedCords[1]] = ". ";
                    movedCords[1] += 1;
                }
                return movedCords;
            }
            else if (KeyPress == ConsoleKey.LeftArrow)
            {
                shipPlaced = false;
                shipError = false;
                if (Grid.arr[movedCords[0], movedCords[1] - 1] == ". " && Grid.arr[movedCords[0] + 1, movedCords[1] - 1] == ". " && Grid.arr[movedCords[0] + 2, movedCords[1] - 1] == ". ")
                {
                    Grid.arr[movedCords[0], movedCords[1]] = ". ";
                    Grid.arr[movedCords[0] + 1, movedCords[1]] = ". ";
                    Grid.arr[movedCords[0] + 2, movedCords[1]] = ". ";
                    movedCords[1] -= 1;
                }
                return movedCords;
            }
            else if (KeyPress == ConsoleKey.DownArrow)
            {
                shipPlaced = false;
                shipError = false;
                if ((Grid.arr[movedCords[0] + 3, movedCords[1]] == ". ") || (Grid.arr[movedCords[0] + 3, movedCords[1]] == "Y "))
                {
                    Grid.arr[movedCords[0], movedCords[1]] = ". ";
                    movedCords[0] += 1;
                }
                return movedCords;
            }
            else if (KeyPress == ConsoleKey.UpArrow)
            {
                shipPlaced = false;
                shipError = false;
                if (Grid.arr[movedCords[0] - 1, movedCords[1]] == ". ")
                {
                    Grid.arr[movedCords[0] + 2, movedCords[1]] = ". ";
                    movedCords[0] -= 1;
                }
                return movedCords;
            }
            else if (KeyPress == ConsoleKey.Enter)
            {
                if (movedCords[0] > 6 || movedCords[1] > 5)
                {
                    shipPlaced = true;
                }
                else
                {
                    shipError = true;
                }
                return movedCords;
            }
            else
            {
                return movedCords;
            }
        }

        public bool Authorize()
        {
            if (shipPlaced)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Grid ShipPlace(int[] movedCords, Grid Grid)
        {     
            Grid.arr[movedCords[0], movedCords[1]] = "D ";
            Grid.arr[movedCords[0] + 1, movedCords[1]] = "D ";
            Grid.arr[movedCords[0] + 2, movedCords[1]] = "D ";
            return Grid;
        }
    }
}
