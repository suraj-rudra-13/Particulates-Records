using System;
using System.Collections.Generic;
using System.Text;

namespace ParticulateRecords
{
    public class ConfigRecord
    {
        public String Filename { get; }

        public ConfigRecord(String Filename)
        {
            this.Filename = Filename;
        }

        public override String ToString()
        {
            return String.Format("{0}", Filename);
        }
    }
}
