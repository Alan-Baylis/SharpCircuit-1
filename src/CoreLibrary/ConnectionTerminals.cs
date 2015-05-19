using System;
using System.Collections.Generic;

namespace SoftCircuitLibrary.Core
{
	public class ConnectionTerminals
	{
		private List<ITerminal> m_terminals;
		private IDevice m_connectedDevice;
		
		public ConnectionTerminals(int numberOfTerminals, IDevice connectedDevice)
		{			
		    Initialize(numberOfTerminals, connectedDevice);
			
			for(int i=0; i<numberOfTerminals; i++)
			{
				ConnectionTerminal terminal= new ConnectionTerminal();
				terminal.CurrentDetection+= m_connectedDevice.CurrentDetected;
				m_terminals.Add(terminal);
			}		
		}
		
		private void Initialize(int numberOfTerminals, IDevice connectedDevice)
		{
			m_terminals = new List<ITerminal>();	
			m_connectedDevice= connectedDevice;
		}
		
		public ConnectionTerminals()
		{
			Initialize(0, null);
		}
		
		public ITerminal this[int i]
		{
			get
			{
				return m_terminals[i];
			}
		}
		
		public int Count { get { return m_terminals.Count; } }
		
		public void Add(ITerminal terminal)
		{
			m_terminals.Add(terminal);
		}
	}
}

