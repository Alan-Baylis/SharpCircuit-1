using System;

namespace Schematics
{
	public class SeriesCircuit: Circuit
	{
		private Resistor m_R1;
		private Resistor m_R2;
		
		public SeriesCircuit (): base(new PowerSource())
		{
			m_R1= new Resistor(1000);
			m_R2= new Resistor(1000);						
		}
		
		public override void Render()
		{
			Junction junction1= new Junction();			
			
			Connect(m_R1.LeadOut, junction1);			
			Connect (junction1, m_R2.LeadIn);
			
			Connect (VCC, m_R1.LeadIn);
			Connect (GND, m_R2.LeadOut);			
		}
	}
}

