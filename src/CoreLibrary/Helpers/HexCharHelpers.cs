using System;

namespace SoftCircuitLibrary.Core
{
	public static class HexCharHelpers
	{
		public static bool[] HexToBoolArray(this char hex)
		{
			bool[] nibble= new bool[4];
			byte hexValue= (byte) (hex-48);
			if (hexValue>=0 && hexValue<=9)
			{					
				for (int i=0; i<4 ; i++)
				{
					nibble[i]= ((hexValue<<(i+1)) & 16)==16;
				}
			}
			else
			{
				switch (hex)
				{
					case 'a':
					case 'A': Array.Copy("1010".BitsToBoolArray(), nibble, 4);
						break;
					case 'b':
					case 'B': Array.Copy("1011".BitsToBoolArray(), nibble, 4);
						break;
					case 'c':
					case 'C': Array.Copy("1100".BitsToBoolArray(), nibble, 4);
						break;
					case 'd':
					case 'D': Array.Copy("1101".BitsToBoolArray(), nibble, 4);
						break;
					case 'e':
					case 'E': Array.Copy("1110".BitsToBoolArray(), nibble, 4);
						break;
					case 'f':
					case 'F': Array.Copy("1111".BitsToBoolArray(), nibble, 4);
						break;
				default:
					throw new Exception("Invalid hex digit '" + hex + "'");
					
				}
			}	
			
			return nibble;
		}
	}
}

