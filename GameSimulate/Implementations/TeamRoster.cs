using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Sockets;
using System.Xml.Serialization;
using GameSimulate.Interfaces;

namespace GameSimulate.Implementations
{
    public class TeamRoster : IParticipantList
    {
        public TeamRoster(IEnumerable<IPlayer> participants)
        {
           // Participants = ((IEnumerable<IParticipant>) participants).ToList().AsReadOnly();
            //var x = (IEnumerable<IPlayer>) participants;
        }

        public ReadOnlyCollection<IParticipant> Participants { get; }
    }
}