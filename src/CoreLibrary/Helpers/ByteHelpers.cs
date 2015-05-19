using System;

namespace SoftCircuitLibrary.Core
{
	public static class ByteHelpers
	{
		public static bool[] ToBoolArray(this byte byteVal)
		{
			bool[] byteResult= new bool[8];
			short shortVal= (short) byteVal; 	
			for (int i=0; i<8 ; i++)
			{
				byteResult[i]= ((shortVal<<(i+1)) & 256)==256;
			}
			
			return byteResult;
		}	
	}
}

