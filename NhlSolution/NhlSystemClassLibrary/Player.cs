using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using NhlSystemClassLibrary;

namespace NhlSystemClassLibrary
{
    public class Player
    {
        const int MinPlayerNo = 1;
        const int MaxPlayerNo = 98;

        private int _playerNo;
        private string _playerName;
        private int _gamesPlayed;
        private int _goals;
        private int _assists;
        private int _points;

        public int PlayerNo
        {
            get
            {
                return _playerNo;
            }
            private set
            {
                if (value < MinPlayerNo || value > MaxPlayerNo)
                {
                    throw new ArgumentException($"PlayerNo must be between {MinPlayerNo} and {MaxPlayerNo}.");
                }
                _playerNo = value;
            }
        }

        public string Name
        {
            get
            {
                return _playerName;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be blank.");
                }
                //validate for only latters a-z
                string lettersOnlyPattern = @"^[a-zA-Z ]{1,}$";
                if (!Regex.IsMatch(value, lettersOnlyPattern))
                {
                    throw new ArgumentException("Name can only contain letters.");
                }
                _playerName = value.Trim();
            }
        }

        public Position Position { get; private set; }

        public int GamesPlayed
        {
            get => _gamesPlayed;         
            protected set
            {
                if (!Utilities.IsPositiveOrZero(value))
                {
                    throw new ArgumentOutOfRangeException("Games played cannot be less than 0");
                }
                _gamesPlayed = value;
            }
        }

        public int Goals
        {
            get => _goals;

            private set
            {
                if (!Utilities.IsPositiveOrZero(value))
                {
                    throw new ArgumentOutOfRangeException("Goals cannot be less than 0");
                }
                _goals = value;
            }
        }

        public int Assists
        {
            get => _assists;

            private set
            {
                if (!Utilities.IsPositiveOrZero(value))
                {
                    throw new ArgumentOutOfRangeException("Assists cannot be less than 0");
                }
                _assists = value;
            }
        }

        // public int Points => Goals + Assists;
        public int Points
        {
            get
            {
                return Goals + Assists;
            }
        }

        //Need specific methods for adding to gamesplayed, goals, assists?
        //Why 2?
        public Player(int playerNo, string name, Position position)
        {
            PlayerNo = playerNo;
            Name = name;
            Position = position;
        }

        public Player(int playerNo, string name, Position position, int gamesPlayed, int goals, int assists, int points)
        {
            PlayerNo = playerNo;
            Name = name;
            Position = position;
            GamesPlayed = gamesPlayed;
            Goals = goals;
            Assists = assists;
        }

        public void AddGamesPlayed()
        {
            GamesPlayed += 1;
        }

        public void AddGoals()
        {
            Goals += 1;
        }

        public void AddAssists()
        {
            Assists += 1;
        }




        /*
        public override string ToString()
        {
            return $"PlayerNo: {PlayerNo}, Name: {Name}, Position: {Position}, Games Played: {GamesPlayed}, Goals: {Goals}, Assists: {Assists}, Points: {Points}";
        }
        */
    }
}
