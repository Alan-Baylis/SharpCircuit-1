using System;

namespace Schematics
{
	public class Resistor: ComponentBase
	{
		public Resistor (int ohms)
		{
		}
		
		public ITerminal LeadIn { get { return null; } }
		
		public ITerminal LeadOut { get { return null; } }
	}
}

