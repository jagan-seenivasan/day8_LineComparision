using System;

namespace Line_Comparision
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("\n Line Comparison problem");

            Console.WriteLine("Enter X1 value :-");
            int X1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y1 value :-");
            int Y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter X2 value :-");
            int X2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y2 value :-");
            int Y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n -------\n")

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the program number which is to be executed \n 1.UC-1, \n 2.UC-2, \n 3.UC-3, \n 4.UC-4, \n 5.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                         Line_Comparision.CalculateXandYLength uc1 = new Line_Comparision.CalculateXandYLength();
                         uc1.LengthOfXandy(X1, X2, Y1, Y2);
                        break;
                    case 2:
                        CheckEqualofLines uc2 = new CheckEqualofLines();
                        uc2.CheckLinesOrEqual(X2, X1, Y1, Y2);
                        break;
                    case 3:
                       GreaterOrLessThanInLine uc3  = new GreaterOrLessThanInLine();
                        uc3.CheckLineisGreaterOrLess(X1, X2, Y1, Y2);
                        break;
                    case 4:
                        LineOfPointsEqual uc4 = new LineOfPointsEqual();
                        uc4.LineOfPointsEqual(X1, X2, Y1, Y2);
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
}
