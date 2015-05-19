using System;
using System.Collections;

namespace SoftCircuitLibrary.Core
{
	public class CircuitBoard
	{
		public static readonly CircuitBoard Instance= new CircuitBoard();
		
		private const string DEFAULT_CIRCUIT_BOARD= "Default Circuit Board";
		
		private string m_boardName;
		
		private CircuitBoard ()
		{
			Initialize(DEFAULT_CIRCUIT_BOARD);
		}		
		
		public void Initialize(string boardName)
		{
			m_boardName= boardName;
			m_devices= new CircuitBoardDevices();
		}

		public string Name {
			get {
				return m_boardName;
			}
		}

		public void AttachDevice (IDevice device)
		{
			m_devices.Add(device);
		}
		
		private CircuitBoardDevices m_devices= null;
		
		public CircuitBoardDevices Devices {
			get {
				return m_devices;
			}
		}
		
		public void Clear()
		{
			m_devices.Clear();
		}
	}
}

