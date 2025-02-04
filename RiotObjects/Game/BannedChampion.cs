﻿namespace PvpLib.RiotObjects.Game
{
    /// <summary>
    /// Class with banned champion information at specific ban turn.
    /// </summary>
    public class BannedChampion : RiotGamesObject
    {
        #region Constructors and Callbacks

        /// <summary>
        /// Initializes a new instance of the <see cref="BannedChampion"/> class.
        /// </summary>
        /// <param name="result">The result.</param>
        public BannedChampion(TypedObject result)
        {
            base.SetFields<BannedChampion>(this, result);
        }

        #endregion

        #region Member Properties

        /// <summary>
        /// Order of ban, pick turn
        /// </summary>
        [InternalName("pickTurn")]
        public int PickTurn { get; set; }

        /// <summary>
        /// Banned champion ID number.
        /// </summary>
        [InternalName("championId")]
        public int ChampionID { get; set; }

        /// <summary>
        /// Id of Team (100 = 1, 200 = 2)
        /// </summary>
        [InternalName("teamId")]
        public int TeamID { get; set; }

        #endregion
    }
}
