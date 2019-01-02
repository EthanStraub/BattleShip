using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleShip
{
    public class Game
    {
        Player Player1 = new Player("");
        Player Player2 = new Player("");

        Grid P1Grid = new Grid();
        Grid P2Grid = new Grid();

        Grid BlankGrid = new Grid();

        Grid P1PreviewGrid = new Grid();
        Grid P2PreviewGrid = new Grid();

        public void Setup()
        {
            Console.WriteLine("What will player 1's name be? Type below a name under 10 characters.");
            Player1.playerName = Player1.NamePlayer();

            Console.WriteLine("What will player 2's name be? Type below a name under 10 characters.");
            Player2.playerName = Player2.NamePlayer();

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
            Console.WriteLine(Player1.playerName + "'s turn.");
            P1PreviewGrid.DisplayGrid();
            PlayerShoot(Player1, P2Grid, P1PreviewGrid);
            P1PreviewGrid.DisplayGrid();

            Console.WriteLine("Press ENTER for the next player's turn");
            Console.ReadLine();
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("");
            }

            Console.WriteLine(Player2.playerName + "'s turn.");
            P2PreviewGrid.DisplayGrid();
            PlayerShoot(Player2, P1Grid, P2PreviewGrid);
            P2PreviewGrid.DisplayGrid();

            Console.WriteLine("Press ENTER for the next player's turn");
            Console.ReadLine();
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("");
            }
        }

        public void GameLoop()
        {
            Setup();
            while( ( Player1.SubCount < 10 ||
                     Player1.DesCount < 10 ||
                     Player1.BatCount < 10 ||
                     Player1.AirCount < 10 ) &&

                   ( Player2.SubCount < 10 ||
                     Player2.DesCount < 10 ||
                     Player2.BatCount < 10 ||
                     Player2.AirCount < 10 ) )
            {
                TurnLoop();
            }
            if (Player1.SubCount == 10 &&
                     Player1.DesCount == 10 &&
                     Player1.BatCount == 10 &&
                     Player1.AirCount == 10 && 
                     
                     Player2.SubCount == 10 &&
                     Player2.DesCount == 10 &&
                     Player2.BatCount == 10 &&
                     Player2.AirCount == 10)
            {
                Console.WriteLine("DRAW!!");
            }
            else if (Player1.SubCount == 10 &&
                Player1.DesCount == 10 &&
                Player1.BatCount == 10 &&
                Player1.AirCount == 10)
            {
                Console.WriteLine(Player1.playerName + " wins!!");
            }
            else if (Player2.SubCount == 10 &&
                     Player2.DesCount == 10 &&
                     Player2.BatCount == 10 &&
                     Player2.AirCount == 10)
            {
                Console.WriteLine(Player2.playerName + " wins!!");
            }
        }

        public void PlayerShoot(Player Player, Grid Grid1, Grid Grid2)
        {
            int[] cords = Player.AskLook();
            if (Grid1.arr[cords[0], cords[1]] == "S ")
            {
                Console.WriteLine("Hit!!");
                Player.SubCount += 1;

                Grid1.arr[cords[0], cords[1]] = "X ";
                Grid2.arr[cords[0], cords[1]] = "X ";
            }
            else if (Grid1.arr[cords[0], cords[1]] == "D ")
            {
                Console.WriteLine("Hit!!");
                Player.DesCount += 1;

                Grid1.arr[cords[0], cords[1]] = "X ";
                Grid2.arr[cords[0], cords[1]] = "X ";
            }
            else if (Grid1.arr[cords[0], cords[1]] == "B ")
            {
                Console.WriteLine("Hit!!");
                Player.BatCount += 1;

                Grid1.arr[cords[0], cords[1]] = "X ";
                Grid2.arr[cords[0], cords[1]] = "X ";
            }
            else if (Grid1.arr[cords[0], cords[1]] == "A ")
            {
                Console.WriteLine("Hit!!");
                Player.AirCount += 1;

                Grid1.arr[cords[0], cords[1]] = "X ";
                Grid2.arr[cords[0], cords[1]] = "X ";
            }
            else
            {
                Console.WriteLine("Miss!!");
            }

            if (Player.SubCount == 2)
            {
                Console.WriteLine("Enemy submarine sunk!!");
                Player.SubCount = 10;
            }
            else if (Player.DesCount == 2)
            {
                Console.WriteLine("Enemy destroyer sunk!!");
                Player.DesCount = 10;
            }
            else if (Player.BatCount == 2)
            {
                Console.WriteLine("Enemy batleship sunk!!");
                Player.BatCount = 10;
            }
            else if (Player.AirCount == 2)
            {
                Console.WriteLine("Enemy aircraft carrier sunk!!");
                Player.AirCount = 10;
            }
        }

        public void ShipSetup(Player Player, Grid Grid)
        {
            int gridIncriment = 0;
            for (int i = 0; i < Player.shipSetLength; i++)
            {
                if (i == 0)
                {
                    gridIncriment = 0;
                    while (gridIncriment < 2)
                    {
                        int[] cords = Player.AskShips(i);
                        if (Grid.arr[cords[0], cords[1]] == "S " ||
                            Grid.arr[cords[0], cords[1]] == "D " ||
                            Grid.arr[cords[0], cords[1]] == "B " ||
                            Grid.arr[cords[0], cords[1]] == "A ")
                        {
                            Console.WriteLine("You can't place a submarine there!");
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
                    while (gridIncriment < 2)
                    {
                        int[] cords = Player.AskShips(i);
                        if (Grid.arr[cords[0], cords[1]] == "S " ||
                            Grid.arr[cords[0], cords[1]] == "D " ||
                            Grid.arr[cords[0], cords[1]] == "B " ||
                            Grid.arr[cords[0], cords[1]] == "A ")
                        {
                            Console.WriteLine("You can't place a destroyer there!");
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
                    while (gridIncriment < 2)
                    {
                        int[] cords = Player.AskShips(i);
                        if (Grid.arr[cords[0], cords[1]] == "S " ||
                            Grid.arr[cords[0], cords[1]] == "D " ||
                            Grid.arr[cords[0], cords[1]] == "B " ||
                            Grid.arr[cords[0], cords[1]] == "A ")
                        {
                            Console.WriteLine("You can't place a battleship there!");
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
                    while (gridIncriment < 2)
                    {
                        int[] cords = Player.AskShips(i);
                        if (Grid.arr[cords[0], cords[1]] == "S " ||
                            Grid.arr[cords[0], cords[1]] == "D " ||
                            Grid.arr[cords[0], cords[1]] == "B " ||
                            Grid.arr[cords[0], cords[1]] == "A ")
                        {
                            Console.WriteLine("You can't place an aircraft carrier there!");
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

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("");
            }

            Console.WriteLine("All ships set up by "+ Player.playerName);
        }
    }
}