using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleShip
{
    public class Game
    {
        Player Player1 = new Player();
        Player Player2 = new Player();

        Grid P1Grid = new Grid();
        Grid P2Grid = new Grid();

        Grid BlankGrid = new Grid();

        Grid P1PreviewGrid = new Grid();
        Grid P2PreviewGrid = new Grid();

        public void Setup()
        {
            Console.WriteLine("What will player 1's name be? Type below a name under 10 characters.");
            Player1.PlayerName = Player1.NamePlayer();

            Console.WriteLine("What will player 2's name be? Type below a name under 10 characters.");
            Player2.PlayerName = Player2.NamePlayer();

            P1Grid.MakeNewGrid();
            P2Grid.MakeNewGrid();

            BlankGrid.MakeNewGrid();

            P1PreviewGrid.MakeNewGrid();
            P2PreviewGrid.MakeNewGrid();

            P1Grid.DisplayGrid();
            ShipSetup(Player1, P1Grid);

            P2Grid.DisplayGrid();
            ShipSetup(Player2, P2Grid);

            Console.WriteLine("");
        }

        public void TurnLoop()
        {
            Console.WriteLine(Player1.PlayerName + "'s turn.");
            Console.WriteLine("Your Grid: ");
            P1Grid.DisplayGrid();
            Console.WriteLine("Enemy Grid: ");
            P1PreviewGrid.DisplayGrid();
            PrintScore(Player1);

            PlayerShoot(Player1, P2Grid, P1PreviewGrid);
            if (Player1.DownedShips.Count == 4)
            {
                return;
            }
            P1PreviewGrid.DisplayGrid();

            Console.WriteLine("Press ENTER for the next player's turn");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine(Player2.PlayerName + "'s turn.");
            Console.WriteLine("Your Grid: ");
            P2Grid.DisplayGrid();
            Console.WriteLine("Enemy Grid: ");
            P2PreviewGrid.DisplayGrid();
            PrintScore(Player2);

            PlayerShoot(Player2, P1Grid, P2PreviewGrid);
            if (Player2.DownedShips.Count == 4)
            {
                return;
            }
            P2PreviewGrid.DisplayGrid();

            Console.WriteLine("Press ENTER for the next player's turn");
            Console.ReadLine();
            Console.Clear();
        }

        public void GameLoop()
        {
            Setup();
            while( Player1.DownedShips.Count < 4 && Player2.DownedShips.Count < 4 )
            {
                TurnLoop();
            }
            if (Player1.DownedShips.Count == 4)
            {
                Console.WriteLine(Player1.PlayerName + " wins!!");
            }
            else if (Player2.DownedShips.Count == 4)
            {
                Console.WriteLine(Player2.PlayerName + " wins!!");
            }
        }

        public void PlayerShoot(Player Player, Grid Grid1, Grid Grid2)
        {
            int[] cords = Player.AskLook();
            if (Grid1.arr[cords[0], cords[1]] == "S ")
            {
                Console.WriteLine("Hit!!");
                Player.SubCount += 1;

                Grid1.arr[cords[0], cords[1]] = "! ";
                Grid2.arr[cords[0], cords[1]] = "! ";
            }
            else if (Grid1.arr[cords[0], cords[1]] == "D ")
            {
                Console.WriteLine("Hit!!");
                Player.DesCount += 1;

                Grid1.arr[cords[0], cords[1]] = "! ";
                Grid2.arr[cords[0], cords[1]] = "! ";
            }
            else if (Grid1.arr[cords[0], cords[1]] == "B ")
            {
                Console.WriteLine("Hit!!");
                Player.BatCount += 1;

                Grid1.arr[cords[0], cords[1]] = "! ";
                Grid2.arr[cords[0], cords[1]] = "! ";
            }
            else if (Grid1.arr[cords[0], cords[1]] == "A ")
            {
                Console.WriteLine("Hit!!");
                Player.AirCount += 1;

                Grid1.arr[cords[0], cords[1]] = "! ";
                Grid2.arr[cords[0], cords[1]] = "! ";
            }
            else
            {
                Console.WriteLine("Miss!!");
                Grid1.arr[cords[0], cords[1]] = "? ";
                Grid2.arr[cords[0], cords[1]] = "? ";
            }

            if (Player.SubCount == 2)
            {
                Console.WriteLine("Enemy submarine sunk!!");
                Player.DownedShips.Add("Submarine");
                Player.SubCount = 10;
            }
            else if (Player.DesCount == 3)
            {
                Console.WriteLine("Enemy destroyer sunk!!");
                Player.DownedShips.Add("Destroyer");
                Player.DesCount = 10;
            }
            else if (Player.BatCount == 4)
            {
                Console.WriteLine("Enemy batleship sunk!!");
                Player.DownedShips.Add("Batleship");
                Player.BatCount = 10;
            }
            else if (Player.AirCount == 5)
            {
                Console.WriteLine("Enemy aircraft carrier sunk!!");
                Player.DownedShips.Add("Aircraft carrier");
                Player.AirCount = 10;
            }
        }

        public void PrintScore(Player Player)
        {
            if (Player.DownedShips.Count > 0)
            {
                Console.WriteLine("Enemy ships sunk: ");
                for (int i = 0; i < Player.DownedShips.Count; i ++)
                {
                    Console.WriteLine(Player.DownedShips[i]);
                }
            }
        }

        public void ShipSetup(Player Player, Grid Grid)
        {
            int gridIncriment = 0;
            for (int i = 0; i < 4; i++)
            {
                if (i == 0)
                {
                    gridIncriment = 0;
                    while (gridIncriment < 2)
                    {
                        int[] cords = Player.AskShips(i);
                        if (GridCheck(cords, Grid, 1, gridIncriment))
                        {
                            Console.WriteLine("You can't place a submarine part there!");
                        }
                        else
                        {
                            Grid.arr[cords[0], cords[1]] = "S ";
                            Grid.DisplayGrid();
                            gridIncriment += 1;
                        }
                    }
                }
                else if (i == 1)
                {
                    gridIncriment = 0;
                    while (gridIncriment < 3)
                    {
                        int[] cords = Player.AskShips(i);
                        if (GridCheck(cords, Grid, 2, gridIncriment))
                        {
                            Console.WriteLine("You can't place a destroyer part there!");
                        }
                        else
                        {
                            Grid.arr[cords[0], cords[1]] = "D ";
                            Grid.DisplayGrid();
                            gridIncriment += 1;
                        }
                    }
                }
                else if (i == 2)
                {
                    gridIncriment = 0;
                    while (gridIncriment < 4)
                    {
                        int[] cords = Player.AskShips(i);
                        if (GridCheck(cords, Grid, 3, gridIncriment))
                        {
                            Console.WriteLine("You can't place a battleship part there!");
                        }
                        else
                        {
                            Grid.arr[cords[0], cords[1]] = "B ";
                            Grid.DisplayGrid();
                            gridIncriment += 1;
                        }
                    }
                }
                else if (i == 3)
                {
                    gridIncriment = 0;
                    while (gridIncriment < 5)
                    {
                        int[] cords = Player.AskShips(i);
                        if (GridCheck(cords, Grid, 4, gridIncriment))
                        {
                            Console.WriteLine("You can't place an aircraft carrier part there!");
                        }
                        else
                        {
                            Grid.arr[cords[0], cords[1]] = "A ";
                            Grid.DisplayGrid();
                            gridIncriment += 1;
                        }
                    }
                }
            }
            Console.Clear();
            Console.WriteLine("All ships set up by "+ Player.PlayerName);
        }

        public bool GridCheck(int[] checkedCords, Grid checkedGrid, int shipType, int gridInc)
        {
            if (shipType == 1)
            {
                if (checkedGrid.arr[checkedCords[0], checkedCords[1]] == "S " ||
                      checkedGrid.arr[checkedCords[0], checkedCords[1]] == "D " ||
                      checkedGrid.arr[checkedCords[0], checkedCords[1]] == "B " ||
                      checkedGrid.arr[checkedCords[0], checkedCords[1]] == "A ")
                {
                    return true;
                }
                else if (gridInc >= 1
                        && checkedGrid.arr[checkedCords[0] - 1, checkedCords[1]] != "S "
                        && checkedGrid.arr[checkedCords[0], checkedCords[1] - 1] != "S "
                        && checkedGrid.arr[checkedCords[0] + 1, checkedCords[1]] != "S "
                        && checkedGrid.arr[checkedCords[0], checkedCords[1] + 1] != "S ")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (shipType == 2)
            {
                if (checkedGrid.arr[checkedCords[0], checkedCords[1]] == "S " ||
                      checkedGrid.arr[checkedCords[0], checkedCords[1]] == "D " ||
                      checkedGrid.arr[checkedCords[0], checkedCords[1]] == "B " ||
                      checkedGrid.arr[checkedCords[0], checkedCords[1]] == "A ")
                {
                    return true;
                }
                else if (gridInc >= 1
                        && checkedGrid.arr[checkedCords[0] - 1, checkedCords[1]] != "D "
                        && checkedGrid.arr[checkedCords[0], checkedCords[1] - 1] != "D "
                        && checkedGrid.arr[checkedCords[0] + 1, checkedCords[1]] != "D "
                        && checkedGrid.arr[checkedCords[0], checkedCords[1] + 1] != "D ")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (shipType == 3)
            {
                if (checkedGrid.arr[checkedCords[0], checkedCords[1]] == "S " ||
                      checkedGrid.arr[checkedCords[0], checkedCords[1]] == "D " ||
                      checkedGrid.arr[checkedCords[0], checkedCords[1]] == "B " ||
                      checkedGrid.arr[checkedCords[0], checkedCords[1]] == "A ")
                {
                    return true;
                }
                else if (gridInc >= 1
                        && checkedGrid.arr[checkedCords[0] - 1, checkedCords[1]] != "B "
                        && checkedGrid.arr[checkedCords[0], checkedCords[1] - 1] != "B "
                        && checkedGrid.arr[checkedCords[0] + 1, checkedCords[1]] != "B "
                        && checkedGrid.arr[checkedCords[0], checkedCords[1] + 1] != "B ")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (shipType == 4)
            {
                if (checkedGrid.arr[checkedCords[0], checkedCords[1]] == "S " ||
                      checkedGrid.arr[checkedCords[0], checkedCords[1]] == "D " ||
                      checkedGrid.arr[checkedCords[0], checkedCords[1]] == "B " ||
                      checkedGrid.arr[checkedCords[0], checkedCords[1]] == "A ")
                {
                    return true;
                }
                else if (gridInc >= 1
                        && checkedGrid.arr[checkedCords[0] - 1, checkedCords[1]] != "A "
                        && checkedGrid.arr[checkedCords[0], checkedCords[1] - 1] != "A "
                        && checkedGrid.arr[checkedCords[0] + 1, checkedCords[1]] != "A "
                        && checkedGrid.arr[checkedCords[0], checkedCords[1] + 1] != "A ")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}