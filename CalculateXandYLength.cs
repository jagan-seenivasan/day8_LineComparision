using System;
using System.Collections.Generic;
using System.Text;

namespace Line_Comparision
{
	public class CalculateXandYLength
	{
		public static void LengthOfXandY()

		{
			Console.WriteLine("line based on a point calculate Xandy \n");
			Console.WriteLine("-----------------------\n");

			Console.WriteLine("Enter X1 value :-");
			int X1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter Y1 value :-");
			int Y1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter X2 value :-");
			int X2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter Y2 value :-");
			int Y2 = Convert.ToInt32(Console.ReadLine());
			int xLength = (X1 - X2) * (Y1 - Y2);
			int yLength = (Y1 - Y2) * (Y1 - Y2);
			int Length = xLength + yLength;
			Console.WriteLine("X and Y lie length is :- " + Length);
		}


	}
}