using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisonUsingOOPS
{
	public class UC2_LineEquality
	{       // Instance Variables
		int x1, y1;
		int x2, y2;
		int p1, q1;
		int p2, q2;
		
		// Constructor Declaration of Class
		public UC2_LineEquality(int x1, int y1, int x2, int y2, int p1, int q1, int p2, int q2)
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

		// Property 1
		public int getX1()
		{
			return x1;
		}

		// Property 2
		public int getY1()
		{
			return y1;
		}

		// Property 3
		public int getX2()
		{
			return x2;
		}

		// Property 4
		public int getY2()
		{
			return y2;
		}
		// Property 5
		public int getP1()
		{
			return p1;
		}

		// Property 6
		public int getQ1()
		{
			return q1;
		}

		// Property 7
		public int getP2()
		{
			return p2;
		}

		// Property 8
		public int getQ2()
		{
			return q2;
		}

		// Method 1
		public String CheckLineEquality()
		{
			float distanceAB = (float)Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
			float distanceCD = (float)Math.Sqrt((Math.Pow(p1 - p2, 2) + Math.Pow(q1 - q2, 2)));
			Console.WriteLine("Co - ordinates of Line AB are" + "(" + this.getX1() + ", " + this.getY1() + ") and(" + this.getX2() + ", " + this.getY2() + "). \nLength of line AB is:  " + distanceAB);
			Console.WriteLine("\n\nCo - ordinates of Line CD are" + "(" + this.getP1() + ", " + this.getQ1() + ") and(" + this.getP2() + ", " + this.getQ2() + "). \nLength of line CD is:  " + distanceCD);

			String lineAB = distanceAB.ToString();
			String lineCD = distanceCD.ToString();


			if (lineAB.Equals(lineCD))
			{
				return ("\nLine AB and Line CD are equal.");
			}
			else
			{
				return ("\nLine AB and Line CD are not equal.");
			}
	
		}
	}
}
