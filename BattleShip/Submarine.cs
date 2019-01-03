using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class Submarine
    {
        int rotateCount = 0;
        bool shipPlaced = false;

        int placeValue1 = 0;
        int placeValue2 = 0;
        int placeValue3 = 0;
        int placeValue4 = 0;

        public int[] ShipMove(int[] movedCords, Grid Grid, ConsoleKey KeyPress)
        {
            if (KeyPress == ConsoleKey.RightArrow)
            {
                shipPlaced = false;
                if (Grid.arr[movedCords[0], movedCords[1] + 1] == ". " && Grid.arr[movedCords[0] + 1, movedCords[1] + 1] == ". ")
                {
                    Grid.arr[movedCords[0], movedCords[1]] = ". ";
                    Grid.arr[movedCords[0] + 1, movedCords[1]] = ". ";
                    movedCords[1] += 1;
                }
                return movedCords;
            }
            else if (KeyPress == ConsoleKey.LeftArrow)
            {
                shipPlaced = false;
                if (Grid.arr[movedCords[0], movedCords[1] - 1] == ". " && Grid.arr[movedCords[0] + 1, movedCords[1] - 1] == ". ")
                {
                    Grid.arr[movedCords[0], movedCords[1]] = ". ";
                    Grid.arr[movedCords[0] + 1, movedCords[1]] = ". ";
                    movedCords[1] -= 1;
                }
                return movedCords;
            }
            else if (KeyPress == ConsoleKey.DownArrow)
            {
                shipPlaced = false;
                if (Grid.arr[movedCords[0] + 2, movedCords[1]] == ". ")
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
                    Grid.arr[movedCords[0] + 1, movedCords[1]] = ". ";
                    movedCords[0] -= 1;
                }
                return movedCords;
            }
            else if (KeyPress == ConsoleKey.R)
            {
                ShipRotate(movedCords, Grid);
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

        public int[] ShipRotate(int[] movedCords, Grid Grid)
        {
            if (rotateCount == 0)
            {
                shipPlaced = false;
                if (Grid.arr[movedCords[0], movedCords[1] + 1] == ". ")
                {
                    rotateCount = 1;
                    Grid.arr[movedCords[0] + 1, movedCords[1]] = ". ";
                    Grid.arr[movedCords[0], movedCords[1] + 1] = "S ";
                }
                return movedCords;
            }
            else if (rotateCount == 1)
            {
                shipPlaced = false;
                if (Grid.arr[movedCords[0] - 1, movedCords[1]] == ". ")
                {
                    rotateCount = 2;
                    Grid.arr[movedCords[0], movedCords[1] + 1] = ". ";
                    Grid.arr[movedCords[0] - 1, movedCords[1]] = "S ";
                }
                return movedCords;
            }
            else if (rotateCount == 2)
            {
                shipPlaced = false;
                if (Grid.arr[movedCords[0], movedCords[1] - 1] == ". ")
                {
                    rotateCount = 3;
                    Grid.arr[movedCords[0] - 1, movedCords[1]] = ". ";
                    Grid.arr[movedCords[0], movedCords[1] - 1] = "S ";
                }
                return movedCords;
            }
            else if (rotateCount == 3)
            {
                shipPlaced = false;
                if (Grid.arr[movedCords[0] + 1, movedCords[1]] == ". ")
                {
                    rotateCount = 0;
                    Grid.arr[movedCords[0], movedCords[1] - 1] = ". ";
                    Grid.arr[movedCords[0] + 1, movedCords[1]] = "S ";
                }
                return movedCords;
            }
            else
            {
                return movedCords;
            }
        }

        public int[] ShipOrientate(int[] movedCords, Grid Grid)
        {
            if (rotateCount == 0)
            {
                if (Grid.arr[movedCords[0] + 1, movedCords[1]] == ". ")
                {
                    Grid.arr[movedCords[0], movedCords[1]] = "S ";
                    Grid.arr[movedCords[0] + 1, movedCords[1]] = "S ";
                }
                return movedCords;
            }
            else if (rotateCount == 1)
            {
                if (Grid.arr[movedCords[0], movedCords[1] + 1] == ". ")
                {
                    Grid.arr[movedCords[0], movedCords[1]] = "S ";
                    Grid.arr[movedCords[0], movedCords[1] + 1] = "S ";
                }
                return movedCords;
            }
            else if (rotateCount == 2)
            {
                if (Grid.arr[movedCords[0] - 1, movedCords[1]] == ". ")
                {
                    Grid.arr[movedCords[0], movedCords[1]] = "S ";
                    Grid.arr[movedCords[0] - 1, movedCords[1]] = "S ";
                }
                return movedCords;
            }
            else if (rotateCount == 3)
            {
                if (Grid.arr[movedCords[0], movedCords[1] - 1] == ". ")
                {
                    Grid.arr[movedCords[0], movedCords[1]] = "S ";
                    Grid.arr[movedCords[0], movedCords[1] - 1] = "S ";
                }
                return movedCords;
            }
            else
            {
                return movedCords;
            }
        }

        public void evaluate()
        {
            if (rotateCount == 0)
            {
                placeValue1 = 0;
                placeValue2 = 0;
                placeValue3 = 0;
                placeValue4 = 0;
            }
            else if (rotateCount == 1)
            {
                placeValue1 = 0;
                placeValue2 = 0;
                placeValue3 = 0;
                placeValue4 = 0;
            }
            else if (rotateCount == 2)
            {
                placeValue1 = 0;
                placeValue2 = 0;
                placeValue3 = 0;
                placeValue4 = 0;
            }
            else if (rotateCount == 3)
            {
                placeValue1 = 0;
                placeValue2 = 0;
                placeValue3 = 0;
                placeValue4 = 0;
            }
        }
    }
}
