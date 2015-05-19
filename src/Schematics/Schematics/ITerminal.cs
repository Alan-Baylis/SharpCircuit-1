using System;

namespace Schematics
{
	public interface ITerminal
	{
		void ConnectTo(ITerminal otherTerminal);
	}
}

