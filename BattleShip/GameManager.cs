using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleShip
{
    public class GameManager
    {
        Game NewGame = new Game();

        public void StartGame()
        {
            NewGame.GameLoop();
        }
    }
}