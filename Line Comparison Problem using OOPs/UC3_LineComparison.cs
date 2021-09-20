using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisonUsingOOPS
{
	public class UC3_LineComparison
	{   // Instance Variables
		int x1, y1;
		int x2, y2;
		int p1, q1;
		int p2, q2;

		// Constructor Declaration of Class
		public UC3_LineComparison(int x1, int y1, int x2, int y2, int p1, int q1, int p2, int q2)
		{
			this.x1 = x1;
			this.y1 = y1;
			this.x2 = x2;
			this.y2 = y2;
			this.p1 = p1;
			this.q1 = q1;
			this.p2 = p2;
			this.q2 = q2;

		}
		public int getX1()
		{
			return x1;
		}
		public int getY1()
		{
			return y1;
		}
		public int getX2()
		{
			return x2;
		}
		public int getY2()
		{
			return y2;
		}
		public int getP1()
		{
			return p1;
		}
		public int getQ1()
		{
			return q1;
		}
		public int getP2()
		{
			return p2;
		}


		public int getQ2()
		{
			return q2;
		}

		// Method 1
		public String LineComparison()
		{
			float distanceAB = (float)Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
			float distanceCD = (float)Math.Sqrt((Math.Pow(p1 - p2, 2) + Math.Pow(q1 - q2, 2)));
			Console.WriteLine("Co - ordinates of Line AB are" + "(" + this.getX1() + ", " + this.getY1() + ") and(" + this.getX2() + ", " + this.getY2() + "). \nLength of line AB is:  " + distanceAB);
			Console.WriteLine("\nCo - ordinates of Line CD are" + "(" + this.getP1() + ", " + this.getQ1() + ") and(" + this.getP2() + ", " + this.getQ2() + "). \nLength of line CD is:  " + distanceCD);


			// using comapreTo function
			int status = distanceAB.CompareTo(distanceCD);
			if (status > 0)
			{
				return ("\nLength of line AB is greater than length of line CD");
			}
			else if (status < 0)
			{
				return ("\nLength of line AB is less than length of line CD");
			}
			else
			{
				return ("\nLength of line AB and length of line CD are equal");
			}
		}



	}
}
