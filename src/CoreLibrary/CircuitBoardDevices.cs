using System;
using System.Collections.Generic;
using System.Collections;

namespace SoftCircuitLibrary.Core
{
	public class CircuitBoardDevices: IEnumerable
	{
		private List<IDevice> m_devices;
		
		private void Initialize()
		{
			m_devices = new List<IDevice>();	
		}
		
		public CircuitBoardDevices()
		{
			Initialize();
		}
		
		public IDevice this[int i]
		{
			get
			{
				return m_devices[i];
			}
		}
		
		public int Count { get { return m_devices.Count; } }
		
		public void Add(IDevice circuitBoard)
		{
			m_devices.Add(circuitBoard);
		}

		#region IEnumerable implementation
		public IEnumerator GetEnumerator ()
		{
			return m_devices.GetEnumerator();
		}
		#endregion
		
		public void Clear()
		{
			m_devices.Clear();
		}
	}
}

