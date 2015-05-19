using System;

namespace SoftCircuitLibrary.Core
{
	public static class ShortHelper
	{
		public static bool[] ToBoolArray(this short shortVal)
		{
			bool[] byteResult= new bool[16];
			int intVal= (int) shortVal; 	
			for (int i=0; i<16 ; i++)
			{
				byteResult[i]= ((intVal<<(i+1)) & 65536)==65536;
			}
			
			return byteResult;
		}
	}
}

