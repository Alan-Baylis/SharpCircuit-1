using System;

namespace Schematics
{
	public class BasicCircuit: Circuit
	{
		private Resistor _r1;
		
		public BasicCircuit (): base(new PowerSource())
		{
			#region Components
			_r1= new Resistor(1000);
			#endregion
		}
		
		public override void Render()
		{
			Connect(VCC, _r1.LeadIn);
			Connect(GND, _r1.LeadOut);
		}
	}
}

