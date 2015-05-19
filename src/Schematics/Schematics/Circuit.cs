using System;

namespace Schematics
{
	public abstract class Circuit
	{
		protected PowerSource m_powerSource;
		
		public IJunction VCC { get { return null; } }
		
		public IJunction GND { get { return null; } }
		
		public Circuit ()
		{
		}
		
		public Circuit (PowerSource powerSource)
		{
		}
		
		public void Connect(ITerminal fromTerminal, ITerminal toTerminal)
		{
		}
		
		public void Connect(ITerminal fromTerminal, IJunction toJunction)
		{
		}
		
		public void Connect(IJunction fromJunction, ITerminal toTerminal)
		{
		}
		
		public void Close()
		{
			m_powerSource.SwitchOn();
		}
		
		public void Open()
		{
			m_powerSource.SwitchOff();
		}
		
		public abstract void Render();
		
		public void Register(IComponent componenet)
		{
		}
				
	}
}

