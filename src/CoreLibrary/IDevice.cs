using System;

namespace SoftCircuitLibrary.Core
{
	public interface IDevice
	{		
		INameGuidPair Identity { get; }		
		void CurrentDetected(ITerminal terminal);
	}
}

