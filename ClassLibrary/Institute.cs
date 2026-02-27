using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Institute
    {
        public List<Group> Groups { get; set; }

        public override string ToString()
        {
            string listOfGroups = string.Empty;
            Groups.ForEach(group => listOfGroups += $"Klas {group.Name}");

            return listOfGroups;
        }
    }
}
