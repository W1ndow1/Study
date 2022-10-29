using System;

namespace app
{
    ///예상 대진표
    ///n명이 참가 
    ///참가자수 N, 참가자번호 A, 경쟁자번호 B, A번의 참가자는 몇라운드에서 B참가자와 만나는지?
    public class Solution40
    {
        public static int solution(int n, int a, int b)
        {
            int answer = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                //1라운드에 종료 되는 경우
                //a가 짝수일때 b가 = a-1인 경우 , a가 홀수 b가 a+1인 경우
                if (a % 2 == 0 && a - 1 == b)
                {
                    answer++;
                    break;
                }
                if (a % 2 != 2 && a + 1 == b)
                {
                    answer++;
                    break;
                }
                //위 조건에 해당하지 않는 경우 각 라운드 마다 a,b 값을 계산
                a = a % 2 == 0 ? a / 2 : a / 2 + 1;
                b = b % 2 == 0 ? b / 2 : b / 2 + 1;
                answer++;
            }
            return answer;
        }
        //새로운 풀이
        public static int solution1(int n, int a, int b)
        {
            int round = 0;
            while (a != b)
            {
                a = a / 2 + a % 2;
                b = b / 2 + b % 2;
                round++;
            }
            return round;
        }
    }
}