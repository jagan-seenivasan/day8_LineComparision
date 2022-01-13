using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparision
{
    class CheckEqualofLines
    {
		public static void CheckLinesOrEqual()
		{

			Console.WriteLine("check the Line is Equal\n");
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

			Console.WriteLine("X line length is " + xLength);
			Console.WriteLine("Y line length is " + yLength);
			if (xLength == yLength)
				Console.WriteLine("Two lines are equal");
			else
				Console.WriteLine("Two lines are not equal");
		}
    }
}
