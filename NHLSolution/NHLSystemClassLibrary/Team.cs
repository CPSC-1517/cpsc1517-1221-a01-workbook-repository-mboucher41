using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NhlSystemClassLibrary
{
    public class Team
    {
        // Define fully implemented properties with a backing field for: Name, City, Arena
        private string _name;
        private string _city;
        private string _arena;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                // Validate new value is not blank and contains only letters a-z
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(Name), "Name cannot be blank.");
                }

                //validate for only latters a-z
                string lettersOnlyPattern = @"^[a-zA-Z ]{1,}$";             
                if(!Regex.IsMatch(value, lettersOnlyPattern))
                {
                    throw new ArgumentException("Name can only contain letters.");
                }
                _name = value.Trim();   // remove leading "   hello" and trailing "hello    " white spaces
            }
        }

        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                //verify that value is not blank
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(City), "City cannot be blank.");
                }
                //varify that value contains 3 or more characters
                if(value.Trim().Length < 3)
                {
                    throw new ArgumentException("City must contain 3 or more characters.");
                }
                _city = value.Trim();
            }
        }

        public string Arena
        {
            get
            {
                return _arena;
            }
            set
            {
                //verify that value is not blank
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(Arena), "Arena cannot be blank.");
                }
                _arena = value.Trim();
            }
        }

        // Define auto-implemented properties for: Conference, Division
        public Conference Conference { get; set; }
        public Division Division { get; set; }

        //need to define player list property
        //public List<Player> PlayerList { get; set; }

        //need to make method for validating and adding players to the list
        //Player cannot be null
        //cannot add same player twice
        //Cannot go over list maximum (23 players per team)


        // Greedy constructor
        public Team(string Name, string City, string Arena, Conference conference, Division division)
        {
            this.Name = Name;
            this.City = City;
            this.Arena = Arena;
            Conference = conference;
            Division = division;
            //_name = Name;
        }

        public override string ToString()
        {
            return $"Name: {Name}, City: {City}, Arena: {Arena}, Conference: {Conference}, Division: {Division}";
        }
    }
}
