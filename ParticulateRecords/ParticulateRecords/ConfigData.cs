using System;
using System.Collections.Generic;
using System.Text;

namespace ParticulateRecords
{
    public class ConfigData
    {
        public List<ConfigRecord> configRecords { get; }

        public int NextRecord { get; set; }

        public ConfigData()
        {
            this.NextRecord = 0;
            configRecords = new List<ConfigRecord>();
        }
    }
}
