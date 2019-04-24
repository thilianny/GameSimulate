using System;
using System.Collections.Generic;

namespace GameSimulate.Interfaces
{
    public interface IPlayerBuilder
    {
        IPlayerBuilder SetName(string name);
        IPlayerBuilder SetPower(int power);
        IPlayerBuilder SetCountry(string country);
        IPlayerBuilder SetBirthdate(DateTime birthdate);

        IPlayer Create();
    }
}