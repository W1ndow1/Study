using System;
using System.Linq;

namespace app
{
    public static class Solution29
    {
        ///피보나치 수
        ///n번째 피보나치 수를  1234567으로 나눈 나머지를 리턴하시오
        /// (A+B)%C = ((A%C) + (B%C))%C
        public static int Pibonachi(int n)
        {
            int answer = 0;
            int[] temp = new int[n+1];
            temp[0] = 0;
            temp[1] = 1;
            for (int i = 2; i < n+1; i++)
            {
                temp[i] = temp[i -2] % 1234567 + temp[i - 1] % 1234567; 
            }
            answer = temp[n] % 1234567;
            return answer;
        }

    }
}