using System;

namespace SoftCircuitLibrary.Core
{
	public interface ICircuitBoard
	{
		string Name { get; }
		
		CircuitBoardDevices Devices { get; }
			
		void AttachDevice(IDevice device);
	}
}

