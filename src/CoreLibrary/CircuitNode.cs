using System;

namespace SoftCircuitLibrary.Core
{
	public class CircuitNode: ICircuitNode
	{
		private ConnectionTerminals m_terminals= null;
		public ConnectionTerminals ConnectedTerminals { get { return m_terminals; } set { m_terminals= value ; } }
		
		public CircuitNode ()
		{
			m_terminals= new ConnectionTerminals();
		}
		
		public void ConnectFrom(ITerminal terminal)
		{
			m_terminals.Add(terminal);
			terminal.ConnectedNodes.Add(this);
		}
	}
}

