using System;

namespace SoftCircuitLibrary.Core
{
	public class ConnectionTerminal: ITerminal
	{
		private CircuitNodes m_connectedNodes= null;
		public CircuitNodes ConnectedNodes { get { return m_connectedNodes; } }
		
		public ConnectionTerminal ()
		{
			m_connectedNodes= new CircuitNodes();
		}				

		#region ITerminal implementation
		public event CoreDelegates.CurrentDetectionHandler CurrentDetection;

		public bool ConnectToNode (ICircuitNode circuitNode)
		{
			circuitNode.ConnectFrom(this);
			m_connectedNodes.Add(circuitNode);	
			
			//TODO: detect anomalies
			return true;
		}
		
		private bool m_isGrounded= false;
		
		public bool ConnectToGround ()
		{
			m_isGrounded= true;
			
			//TODO: detect anomalies
			return true;
		}
		
		public bool IsGrounded { get { return m_isGrounded; } }
		
		private bool m_isSupplyVoltageConnected= false;
		
		public bool IsSupplyVoltageConnected  { get { return m_isSupplyVoltageConnected; } }
		
		private ISupplyVoltageDC m_supplyVoltageDC= null;
		
		public bool ConnectToSupplyVoltage (ISupplyVoltageDC supplyVoltage)
		{
			m_supplyVoltageDC= supplyVoltage;
			m_isSupplyVoltageConnected= true;
			
			//TODO: detect anomalies
			return true;
		}
		#endregion
	}
}

