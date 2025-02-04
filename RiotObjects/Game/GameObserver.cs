﻿namespace PvpLib.RiotObjects.Game
{
    /// <summary>
    /// Class which defines a GameObserver and its information.
    /// </summary>
    public class GameObserver : RiotGamesObject
    {
        #region Constructors and Callbacks

        /// <summary>
        /// Initializes a new instance of the <see cref="GameObserver"/> class.
        /// </summary>
        /// <param name="result">The result.</param>
        public GameObserver(TypedObject result)
        {
            base.SetFields<GameObserver>(this, result);
        }

        #endregion

        #region Member Properties

        /// <summary>
        /// The account ID number of observer.
        /// </summary>
        [InternalName("accountId")]
        public int AccountID { get; set; }

        /// <summary>
        /// The summoner ID number of observer.
        /// </summary>
        [InternalName("summonerId")]
        public int SummonerID { get; set; }

        /// <summary>
        /// The difficulty of the bot (NONE,...)
        /// </summary>
        [InternalName("botDifficulty")]
        public string BotDifficulty { get; set; }

        /// <summary>
        /// Summoner name of the observer
        /// </summary>
        [InternalName("summonerInternalName")]
        public string SummonerInternalName { get; set; }

        /// <summary>
        /// Summoner name of the observer
        /// </summary>
        [InternalName("summonerName")]
        public string SummonerName { get; set; }

        /*[InternalName("locale")]
        public PlayerCredentials PlayerCredentials { get; set; }*/

        /// <summary>
        /// The skin ID that was last selected by the observer (summoner).
        /// </summary>
        [InternalName("lastSelectedSkinIndex")]
        public int LastSelectedSkinID { get; set; }

        /// <summary>
        /// The profile icon ID of the observer (summoner).
        /// </summary>
        [InternalName("profileIconId")]
        public int ProfileIconID { get; set; }

        /// <summary>
        /// Badges ??? unknown significance, seems to be int.
        /// </summary>
        [InternalName("badges")]
        public int Badges { get; set; }

        /// <summary>
        /// Pickturn of observer (probably always 0).
        /// </summary>
        [InternalName("pickTurn")]
        public int PickTurn { get; set; }

        /// <summary>
        /// PickMode of the game.
        /// </summary>
        [InternalName("pickMode")]
        public int PickMode { get; set; }

        #endregion
    }
}
