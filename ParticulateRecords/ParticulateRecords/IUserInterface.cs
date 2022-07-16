using System;
using System.Collections.Generic;
using System.Text;

namespace ParticulateRecords
{
    public interface IUserInterface
    {
        void SetupConfigData();
        void RunProducerConsumer();
        void DisplayLocations();
        void DisplayDates();
        void DisplayLargestParticulates();
        void DisplayLocationReadings(String location);
    }
}
