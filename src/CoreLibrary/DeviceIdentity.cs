using System;

namespace SoftCircuitLibrary.Core
{
	public class DeviceIdentity: INameGuidPair
	{
		public static readonly string UNNAMED_DEVICE="<Unnamed>";
		
		public DeviceIdentity ()
		{
			m_name= UNNAMED_DEVICE;
		}
		
		public DeviceIdentity(string name)
		{
			m_name= name==null? UNNAMED_DEVICE: name;
		}

		#region INameGuidPair implementation
		private Guid m_id= Guid.NewGuid();
		
		public Guid Id {
			get {
				return m_id;
			}
		}
		
		private string m_name= null;
		
		public string Name {
			get {
				return m_name;
			}
		}
		#endregion
	}
}

