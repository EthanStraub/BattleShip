using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleShip
{
    public class ShipSet
    {
        private int[] set = new int[4] { 2, 3, 4, 5 };
        public int[] Set { get { return set; } set { set = value; } }
    }
}