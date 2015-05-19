using System;

namespace Schematics
{
	public class ComponentBase: IComponent
	{
		public ComponentBase ()
		{
		}

		#region IComponent implementation
		public TerminalCollection Terminals {
			get {
				throw new NotImplementedException ();
			}
		}
		#endregion
	}
}

