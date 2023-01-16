using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
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
                    throw new ArgumentNullException(nameof(Name),"Name cannot be blank.");
                }
                _name = value.Trim();   // remove leading "   hello" and trailing "hello    " white spaces
            }
        }
        // Define auto-implemented properties for: Conference, Division
        public Conference Conference { get; set; }
        public Division Division { get; set; }


        // Greedy constructor
        public Team(string Name, Conference conference, Division division)
        {
            this.Name = Name;
            Conference = conference;
            Division = division;
            //_name = Name;
        }
    }
}
