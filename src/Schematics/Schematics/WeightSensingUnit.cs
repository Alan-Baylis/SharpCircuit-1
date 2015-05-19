using System;

namespace Schematics
{
	public class WeightSensingUnit: Circuit
	{
		protected ThreeWireLoadCell _loadCell;
		
		protected LoadCellAmplifier _amplifier;
		
		protected Resistor _r1;
		
		protected Resistor _r2;	
		
		private IJunction _junction1;
		
		public WeightSensingUnit (): base(new PowerSource(5.0f,0.2f))
		{
			#region Components
			Register(_loadCell= new ThreeWireLoadCell());
			Register(_amplifier= new LoadCellAmplifier());
			
			Register(_r1= new Resistor(1000));
			Register(_r2= new Resistor(1000));
			#endregion
			
			#region Junctions
			_junction1= new Junction();
			#endregion
			
			#region Wirings
			Connect (_loadCell.BlackWire, this.VCC);
			Connect (_loadCell.WhiteWire, this.GND);
			Connect (_loadCell.RedWire, _amplifier.VPositiveInput);
			
			Connect (_r1.LeadIn, this.GND);
			Connect (_r1.LeadOut, _junction1);
						
			Connect (_r2.LeadIn, _junction1);
			Connect (_r2.LeadOut, this.VCC);						
			
			Connect (_amplifier.VNegativeInput, _junction1);
			
			Connect (_amplifier.GND, this.GND);
			Connect (_amplifier.VCC, this.VCC);
			#endregion
		}

		#region implemented abstract members of Schematics.Circuit
		public override void Render ()
		{
			
		}
		#endregion
	}
}

