using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class Program5_CouponNumbers
    {
        static char[] code = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ123456789".ToCharArray();
        public static void CouponNumbers()
        {
            Console.Write("Enter a number coupon code length:   ");
            int num = Convert.ToInt32(Console.ReadLine());

            StringBuilder str = new StringBuilder();
          
            Random random = new Random();
            for (int i =0; i<num; i++)
            {
                int position = random.Next(0, code.Length);
                str.Append(code[position]);    
            }
            Console.WriteLine("\n\nCoupon Code:  "+str);
        }      
    }
}
