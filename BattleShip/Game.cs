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

        Grid Grid1 = new Grid();

        public void GameLoop()
        {
            Console.WriteLine("What will player 1's name be? Type below a name under 10 characters.");
            Player1.PlayerName = Player1.NamePlayer();

            Console.WriteLine("What will player 2's name be? Type below a name under 10 characters.");
            Player2.PlayerName = Player2.NamePlayer();

            Grid1.MakeNewGrid();
            Grid1.DisplayGrid();

            PlayerLook(Player2);

            Console.ReadLine();
        }

        public void PlayerLook(Player Player)
        {
            int[] cords = Player.AskLook();
            Console.WriteLine(Grid1.arr[cords[0], cords[1]]);
        }
    }
}