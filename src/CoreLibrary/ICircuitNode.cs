using System;

namespace SoftCircuitLibrary.Core
{
	public interface ICircuitNode
	{
		void ConnectFrom(ITerminal terminal);
	}
}

