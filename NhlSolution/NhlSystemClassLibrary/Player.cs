using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NhlSystemClassLibrary
{
    internal class Player
    {
        private int _playerNo;
        private string _name;
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
            set
            {
                if (value < 0 || value > 98)
                {
                    throw new ArgumentOutOfRangeException("Player Number cannot be less than zero or greater than 98.");
                }
                _playerNo = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(Name), "Name cannot be blank.");
                }
                //validate for only latters a-z
                string lettersOnlyPattern = @"^[a-zA-Z ]{1,}$";
                if (!Regex.IsMatch(value, lettersOnlyPattern))
                {
                    throw new ArgumentException("Name can only contain letters.");
                }
                _name = value.Trim();
            }
        }

        public Position Position { get; set; }

        public int GamesPlayed
        {
            get
            {
                return _gamesPlayed;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Games played cannot be less than 0");
                }
                _gamesPlayed = value;
            }
        }

        public int Goals
        {
            get
            {
                return _goals;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Goals cannot be less than 0");
                }
                _goals = value;
            }
        }

        public int Assists
        {
            get
            {
                return _assists;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Assists cannot be less than 0");
                }
                _assists = value;
            }
        }
        public int Points
        {
            get
            {
                return _points;
            }
            set
            {
                _points = _assists + _goals;
            }
        }

        //Need specific methods for adding to gamesplayed, goals, assists?

        public Player(int PlayerNo, string Name, Position position, int GamesPlayed, int Goals, int Assists, int Points)
        {
            this.PlayerNo = PlayerNo;
            this.Name = Name;
            Position = position;
            this.GamesPlayed = GamesPlayed;
            this.Goals = Goals;
            this.Assists = Assists;
            this.Points = Points;
        }

        public override string ToString()
        {
            return $"PlayerNo: {PlayerNo}, Name: {Name}, Position: {Position}, Games Played: {GamesPlayed}, Goals: {Goals}, Assists: {Assists}, Points: {Points}";
        }
    }
}
