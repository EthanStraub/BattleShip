using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleShip
{
    public class Game
    {
        Player Player1 = new Player("Player 1");
        Player Player2 = new Player("Player 2");

        Grid Grid1 = new Grid();

        public void GameLoop()
        {
            Grid1.MakeNewGrid();
            Grid1.DisplayGrid();
            

            Player1.AskLook();
            Console.WriteLine("TEST");

            Console.ReadLine();
        }
    }
}