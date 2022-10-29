using System;

namespace app
{
    ///N개의 최소공배수
    ///두 수의 a,b의 최소공배수는 a,b의 곱을 a,b의 최대공약수를 나눈 것과 같다.
    public class Solution38
    {
        //최소공배수로 처리
        public static int solution(int[] arr)
        {
            int answer = lcm(arr[0], arr[1]);
            for (int i = 2; i < arr.Length; i++)
            {
                answer = lcm(answer, arr[i]);
            }
            return answer;
        }
        //최대공약수로 처리
        public static int solution01(int[] arr)
        {
            int answer = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                answer *= arr[i] / gcd(answer, arr[i]);
            }
            return answer;
        }
        //최대공약수
        public static int gcd(int a, int b)
        {
            // while(b != 0)
            // {
            //     int r = a%b;
            //     a = b
            //     b = r;
            // }
            // return n;
            return a % b == 0 ? b : gcd(b, a%b);
        }
        //최소공배수
        public static int lcm(int a, int b)
        {
            int n= a;
            int m = b;
            int temp = 0;
            while (m > 0)
            {
                temp = n%m;
                n =m;
                m = temp;
            }
            return (a*b)/n;
        }
    }
}