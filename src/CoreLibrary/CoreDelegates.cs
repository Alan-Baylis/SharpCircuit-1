using System;

namespace SoftCircuitLibrary.Core
{
	public static class CoreDelegates
	{
		public delegate void CurrentDetectionHandler(ITerminal terminal);
		public delegate void DigitalStateChangeHandler(DigitalStateOption state);
	}
}

