using System;
using System.Collections.Generic;
using System.Text;

namespace ParticulateRecords
{
    public class Location
    {
        public String Name { get; }
        public List<Reading> Readings { get; }

        public Location(String name)
        {
            this.Name = name;
            this.Readings = new List<Reading>();
        }

        public override String ToString()
        {
            return String.Format("Location: {0}", this.Name);
        }
    }
}
