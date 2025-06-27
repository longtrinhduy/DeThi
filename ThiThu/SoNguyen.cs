using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiThu
{
    public class SoNguyen
    {
        public int SoNguyenSum(int n)
        {
            if (n < 1)
            {
                throw new ArgumentOutOfRangeException("Invalid input");
            }
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
