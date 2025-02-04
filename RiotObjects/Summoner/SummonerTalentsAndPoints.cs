﻿namespace PvpLib.RiotObjects.Summoner
{
    using System;

    /// <summary>
    /// The class that defines summoner talent and points information.
    /// </summary>
    public class SummonerTalentsAndPoints : RiotGamesObject
    {
        #region Constructors and Callbacks

        /// <summary>
        /// Initializes a new instance of the <see cref="SummonerTalentsAndPoints"/> class.
        /// </summary>
        /// <param name="result">The result.</param>
        public SummonerTalentsAndPoints(TypedObject result)
        {
            base.SetFields<SummonerTalentsAndPoints>(this, result);
        }

        #endregion

        #region Member Properties

        /// <summary>
        /// Number of total talent points.
        /// </summary>
        [InternalName("talentPoints")]
        public int TalentPoints { get; set; }

        /// <summary>
        /// Date/time since modified.
        /// </summary>
        [InternalName("modifyDate")]
        public DateTime ModifyDate { get; set; }

        /// <summary>
        /// Date/time when created.
        /// </summary>
        [InternalName("createDate")]
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Date/time since modified.
        /// </summary>
        [InternalName("summonerId")]
        public int SummonerId { get; set; }

        #endregion
    }
}
