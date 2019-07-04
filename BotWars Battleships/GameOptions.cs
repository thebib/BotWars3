namespace BotWars_Battleships
{
    struct GameOptions
    {
        /// <summary>
        /// The Size of the Arena x*x (always a square)
        /// </summary>
        public int ArenaSize;
        /// <summary>
        /// The Amount of Boats
        /// </summary>
        public int BoatCount;
        /// <summary>
        /// Type of Boat Generation
        /// </summary>
        public string BoatGeneration;
        /// <summary>
        /// How many points a player will get for Sinking a Ship
        /// </summary>
        public int SinkPoints;
        /// <summary>
        /// How many points a player will get for Hitting a Ship
        /// </summary>
        public int HitPoints;

    }
}