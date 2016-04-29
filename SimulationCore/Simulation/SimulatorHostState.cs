using System;
using System.Collections.Generic;

namespace AntMe.Simulation
{
    /// <summary>
    /// Statusklasse zur Weitergabe des aktuellen Spielstandes aus dem Host zur�ck zum Simulator
    /// </summary>
    /// <author>Tom Wendel (tom@antme.net)</author>
    [Serializable]
    internal sealed class SimulatorHostState
    {
        /// <summary>
        /// Auflistung der Debug Messages
        /// </summary>
        public List<DebugMessage> DebugMessages = new List<DebugMessage>();

        /// <summary>
        /// Gesamtzeit f�r die Runde
        /// </summary>
        public long ElapsedRoundTime;

        /// <summary>
        /// Vergangene Zeiten f�r einzelne Spieler
        /// </summary>
        public Dictionary<Guid, long> ElapsedPlayerTimes = new Dictionary<Guid, long>();
    }
}