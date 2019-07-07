using BotWars_Battleships.Battlefield;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotWars_Battleships.Player.Moves
{
    public class Bomb : IMove
    {
        /// <summary>
        /// A Fire Pattern of 1 - 9
        /// There's preset bombs but you can make your own e.g. with just 5 enabled this will fire
        /// in the center most square e.g. 
        /// x x x
        /// x B x
        /// x x x
        /// Players must manage there ammo and there bomb size!
        /// </summary>
        public Dictionary<int, Boolean> FirePattern;
        public Tile Target;
    }
}
