using System;
using System.Collections.Generic;
using System.Linq;
using GameSimulate.Abstractions;
using GameSimulate.Enums;
using GameSimulate.Exceptions;
using GameSimulate.Interfaces;
using GameSimulate.Sessions;

namespace GameSimulate
{
    public static class Simulator
    {
        public static List<Session> Sessions { get; } = new List<Session>();

        private static Session CreateSession(string sportType, Sport sport)
        {
            var session = Sessions.FirstOrDefault(s => s.Sport == sport && s.IsActive);
            if (session != null)
            {
                Console.WriteLine($"Active {sport.ToString().ToLower()} session already exists.");
                return session;
            }
            
            session = (Session) Activator.CreateInstance(
                Type.GetType($"GameSimulate.Sessions.{sportType}Session"), true);
            session.Sport = sport;
            session.InitializeCreators();
            Sessions.Add(session);
            return session;
        }

        public static TeamSession OpenTeamSession(TeamSport sport)
        {
            var teamSport = (Sport) Enum.Parse(typeof(Sport), sport.ToString());
            return (TeamSession) CreateSession("Team", teamSport);
        }

        public static RacingSession OpenRacingSession(RacingSport sport)
        {
            var racingSport = (Sport) Enum.Parse(typeof(Sport), sport.ToString());
            return (RacingSession) CreateSession("Racing", racingSport);
        }

        public static void CloseSession(Sport sport)
        {
            var session = Sessions.FirstOrDefault(s => s.Sport == sport && s.IsActive);
            if (session == null)
                Console.WriteLine($"Active {sport.ToString().ToLower()} wasn't found.");
            else
                session.Close();
        }

    }
}