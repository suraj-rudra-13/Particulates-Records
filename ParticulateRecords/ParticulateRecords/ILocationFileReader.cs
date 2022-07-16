using System;
using System.Collections.Generic;
using System.Text;

namespace ParticulateRecords
{
    public interface ILocationFileReader
    {
        Location ReadLocationFromFile(ConfigRecord configRecord);
    }
}
