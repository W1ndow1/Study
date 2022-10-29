using System;

namespace app
{   
    ///멀리뛰기
    ///
    public class Solution43
    {
        public static long Solution(int n)
        {
            long[] arr = new long[2001];
            arr[0] = 1;
            arr[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                arr[i] = (arr[i - 1] + arr[i - 2]) % 1234567;
            }
            return arr[n];
        }
    }
}