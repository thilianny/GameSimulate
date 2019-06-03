using System;
using System.Collections.Generic;
using System.Linq;
using GameSimulate.Abstractions;
using GameSimulate.Enums;
using GameSimulate.Exceptions;
using GameSimulate.Interfaces;

namespace GameSimulate
{
    public static class Simulator
    {
        public static List<Session> Sessions { get; } = new List<Session>();

        public static Session OpenSession(Sport sport)
        {
            var session = Sessions.FirstOrDefault(s => s.Sport == sport && s.IsActive);
            
            if (session != null)
            {
                Console.WriteLine($"Active {sport.ToString().ToLower()} session already exists.");
                return session;
            }
           
            session = new Session(sport);
            Sessions.Add(session);
            return session;
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