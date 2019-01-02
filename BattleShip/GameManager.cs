using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleShip
{
    public class GameManager
    {
        public void StartGame()
        {
            Game NewGame = new Game();
            NewGame.GameLoop();
            RestartGame();
        }

        public void RestartGame()
        {
            Console.WriteLine("Game over! Type 'restart' to restart, or 'quit' to quit!");
            bool isInputValid = false;
            while (!isInputValid)
            {
                string winOption = Console.ReadLine();
                switch (winOption)
                {
                    case "restart":
                        isInputValid = true;
                        Console.Clear();
                        StartGame();
                        break;
                    case "quit":
                        isInputValid = true;
                        System.Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Please try again.");
                        break;
                }
            }
        }
    }
}