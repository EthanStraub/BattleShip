using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class Destroyer
    {
        bool shipPlaced = false;
        public int[] ShipMove(int[] movedCords, Grid Grid, ConsoleKey KeyPress)
        {
            if (KeyPress == ConsoleKey.RightArrow)
            {
                shipPlaced = false;
                if (Grid.arr[movedCords[0], movedCords[1] + 1] == ". " && Grid.arr[movedCords[0] + 1, movedCords[1] + 1] == ". " && Grid.arr[movedCords[0] + 2, movedCords[1] + 1] == ". ")
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
                if (Grid.arr[movedCords[0] + 3, movedCords[1]] == ". ")
                {
                    Grid.arr[movedCords[0], movedCords[1]] = ". ";
                    movedCords[0] += 1;
                }
                return movedCords;
            }
            else if (KeyPress == ConsoleKey.UpArrow)
            {
                shipPlaced = false;
                if (Grid.arr[movedCords[0] - 1, movedCords[1]] == ". ")
                {
                    Grid.arr[movedCords[0] + 2, movedCords[1]] = ". ";
                    movedCords[0] -= 1;
                }
                return movedCords;
            }
            else if (KeyPress == ConsoleKey.Enter)
            {
                shipPlaced = true;
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
    }
}
