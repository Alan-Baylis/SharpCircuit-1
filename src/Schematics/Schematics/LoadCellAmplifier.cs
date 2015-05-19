using System;

namespace Schematics
{
	public class LoadCellAmplifier: ComponentBase
	{
		public LoadCellAmplifier ()
		{
		}
		
		public ITerminal VCC { get { return null; } }
		
		public ITerminal GND { get { return null; } }
				
		public ITerminal VPositiveInput { get { return null; } }
		
		public ITerminal VNegativeInput { get { return null; } }
		
		public ITerminal SignalOutput { get { return null; } }
	}
}

