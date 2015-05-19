using System;

namespace SoftCircuitLibrary.Core
{
	public struct Nibble
	{
		private bool[] m_nibble;
		
		public Nibble(byte nibbleValue)
		{
			m_nibble= new bool[4];
			m_nibble[0]= (nibbleValue & 8)==8;
			m_nibble[1]= (nibbleValue & 4)==4;
			m_nibble[2]= (nibbleValue & 2)==2;
			m_nibble[3]= (nibbleValue & 1)==1;
		}
		
		public bool[] Value { get { return m_nibble; } }
	}
}

