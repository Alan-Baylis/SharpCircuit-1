using System;
using System.Collections.Generic;

namespace SoftCircuitLibrary.Core
{
	public class CircuitNodes
	{
		private List<ICircuitNode> m_nodes;
		
		public CircuitNodes()
		{
			m_nodes = new List<ICircuitNode>();	
//			m_connectedDevice= connectedDevice;
//			
//			for(int i=0; i<numberOfNodes; i++)
//			{
//				CircuitNode node= new CircuitNode();
//				node.CurrentDetection+= m_connectedDevice.CurrentDetected;
//				m_nodes.Add(node);
//			}		
		}
		
		public void Add(ICircuitNode node)
		{
			if (!m_nodes.Contains(node))
			{
				m_nodes.Add(node);
			}
		}
		
		public ICircuitNode this[int i]
		{
			get
			{
				return m_nodes[i];
			}
		}
		
		public int Count { get { return m_nodes.Count; } }
	}
}

