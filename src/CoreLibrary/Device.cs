using System;

namespace SoftCircuitLibrary.Core
{
	public class Device: IDevice
	{
		private ConnectionTerminals m_terminals= null;
		public ConnectionTerminals Terminals { get { return m_terminals; } set { m_terminals= value ; } }
		
		private CircuitBoard m_circuitBoard;
		
		public Device (int numberOfTerminals, string name=null)
		{
			m_circuitBoard= CircuitBoard.Instance;
			m_circuitBoard.AttachDevice(this);
			
			m_terminals= new ConnectionTerminals(numberOfTerminals, this);	
			
			m_identity= new DeviceIdentity(name);
		}

		#region IDevice implementation
		public void CurrentDetected (ITerminal terminal)
		{
			
		}
		
		private INameGuidPair m_identity= null;
		public INameGuidPair Identity {
			get {
				return m_identity;
			}
		}
		#endregion
	}
}

