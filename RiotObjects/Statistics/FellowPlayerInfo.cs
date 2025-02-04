﻿namespace PvpLib.RiotObjects.Statistics
{
    /// <summary>
    /// The class that defines the fellow player and its information.
    /// </summary>
    public class FellowPlayerInfo : RiotGamesObject
    {
        #region Constructors and Callbacks

        /// <summary>
        /// Create an empty Class
        /// </summary>
        public FellowPlayerInfo()
        {
        }

        /// <summary>
        /// Create the Class with a TypedObject result
        /// </summary>
        /// <param name="result"></param>
        public FellowPlayerInfo(TypedObject result)
        {
            base.SetFields<FellowPlayerInfo>(this, result);
        }

        #endregion

        #region Member Properties

        /// <summary>
        /// The champion ID number.
        /// </summary>
        [InternalName("championId")]
        public int ChampionID { get; set; }

        /// <summary>
        /// The Team ID number (100 = blue, 200 = purple).
        /// </summary>
        [InternalName("teamId")]
        public int TeamID { get; set; }

        /// <summary>
        /// The summoner ID number.
        /// </summary>
        [InternalName("summonerId")]
        public int SummonerID { get; set; }

        #endregion
    }
}
