using System;
using System.Collections.Generic;
using System.Text;

namespace ParticulateRecords
{
	public class Work
	{
		public ConfigRecord configRecord { get; }
		private ILocationFileReader IOhandler;

		public Work(ConfigRecord data, ILocationFileReader IOhandler)
		{
			this.configRecord = data;
			this.IOhandler = IOhandler;
		}

		public Location ReadData()
		{
			return IOhandler.ReadLocationFromFile(configRecord);
		}
	}
}
