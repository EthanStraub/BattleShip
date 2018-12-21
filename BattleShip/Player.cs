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

        public void AskLook()
        {
            Console.WriteLine("What would you like to look at, " + PlayerName + "?");
        }
    }

    
}