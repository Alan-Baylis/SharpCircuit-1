using System;

namespace Schematics
{
	public class ThreeWireLoadCell: ComponentBase
	{
		public ThreeWireLoadCell()
		{
			
		}
		
		public ITerminal BlackWire { get { return Terminals.First; } }
		
		public ITerminal RedWire { get { return null; } }
		
		public ITerminal WhiteWire { get { return null; } }
	}
}

