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
            Console.Write("Enter number of coupons that you want to generate:   ");
            int num = Convert.ToInt32(Console.ReadLine());


            
            int couponLength = 8;
            Random random = new Random();
            for(int couponNumber =1; couponNumber <= num; couponNumber++)
            {
                StringBuilder str = new StringBuilder();
                for (int i = 0; i < couponLength; i++)
                {
                    int position = random.Next(0, code.Length);
                    str.Append(code[position]);
                }
                Console.WriteLine("\n\nCoupon Code-{0}:  {1}",couponNumber, str);
            }
          
            
          }      
    }
}
