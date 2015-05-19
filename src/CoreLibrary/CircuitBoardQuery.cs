using System;
using System.Collections.Generic;

namespace SoftCircuitLibrary.Core
{
	public class CircuitBoardQuery
	{
		public CircuitBoardQuery ()
		{
		}
		
		public static INameGuidPair[] GetDeviceList()
		{
			List<INameGuidPair> deviceNames= new List<INameGuidPair>();
			
			foreach(IDevice device in CircuitBoard.Instance.Devices)
			{
				deviceNames.Add(device.Identity);
			}
			
			return deviceNames.ToArray();
		}
	}
}

