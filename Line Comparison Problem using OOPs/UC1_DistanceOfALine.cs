using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisonUsingOOPS
{
public class UC1_DistanceOfALine
{		// Instance Variables
		int x1;
		int y1;
		int x2;
		int y2;

	// Constructor Declaration of Class
	public UC1_DistanceOfALine(int x1, int y1, int x2, int y2)
    {
		this.x1 = x1;
		this.y1 = y1;
		this.x2 = x2;
		this.y2 = y2;
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

	// Method 1
	public String lengthOfLine()
	{
			float distance = (float)Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
			return ("Co-ordinates of Line AB are" + "("+this.getX1()+","+ this.getY1()+") and ("+ this.getX2()+","+this.getY2()+"). \n\nLength of line AB is:  "+distance);
	}

	
	
}
}