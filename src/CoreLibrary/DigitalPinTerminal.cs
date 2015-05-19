using System;

namespace SoftCircuitLibrary.Core
{
	public class DigitalPinTerminal: ITerminal
	{
		private ITerminal m_baseTerminal= null;
		
		public event CoreDelegates.DigitalStateChangeHandler DigitalStateChange;
		
		public DigitalPinTerminal (ITerminal terminal)
		{
			m_baseTerminal= terminal;
		}
		
				
		private DigitalStateOption m_state= DigitalStateOption.Low;
		public DigitalStateOption State 
		{
			get { 
				return m_state; 
			} 
			set { 
				DigitalStateOption oldState= m_state;
				m_state= value; 
				if (oldState!=m_state && DigitalStateChange!=null)
				{
					DigitalStateChange(m_state);
				}
			} 
		}
	

		#region ITerminal implementation
		public event CoreDelegates.CurrentDetectionHandler CurrentDetection;

		public bool ConnectToNode (ICircuitNode circuitNode)
		{
			throw new NotImplementedException ();
		}

		public bool ConnectToGround ()
		{
			throw new NotImplementedException ();
		}

		public bool ConnectToSupplyVoltage (ISupplyVoltageDC supplyVoltage)
		{
			throw new NotImplementedException ();
		}

		public bool IsGrounded {
			get {
				throw new NotImplementedException ();
			}
		}

		public CircuitNodes ConnectedNodes {
			get {
				throw new NotImplementedException ();
			}
		}
		#endregion
	}
}

