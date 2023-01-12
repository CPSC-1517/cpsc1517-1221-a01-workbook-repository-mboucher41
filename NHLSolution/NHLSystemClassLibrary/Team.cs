using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace NHLSystemClassLibrary
{
    public class Team
    {
        //Define fully implemeted properties with a backing field for: name, city, arena
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
                //validate, not blank, letters only??
                if (string.IsNullOrWhiteSpace(value) == true)
                {
                    throw new ArgumentNullException(nameof(value),"Name cannot be blank.");
                }

                _name = value.Trim(); //removes leading and trailing white spaces
            }
        }

        public string City //SET UP
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }

        public string Arena //SET UP
        {
            get
            {
                return _arena;
            }
            set
            {
                _arena = value;
            }
        }
        //Define auto-implemented properties for: conference, division

        //Greedy constructor
        public Team(string name, Conference conference, Division division)
        {
            Name = name;
            Conference = conference;
            Division = division;
        }
        public Conference Conference { get; set; }
        public Division Division { get; set; }
    }
}
