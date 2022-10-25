using System;
using System.Linq;

namespace app
{
    public static class Solution30
    {
        ///예산
        ///신청한 금액이 들어있는 배열 d와 예산 budget이 넘어올때 최대 몇개의 부서에 
        ///물품을 지원할수 있는지 결과를 리턴하시오.
        public static int solution30(int[] d, int budget)
        {
            int answer = 0;
            Array.Sort(d);
            for (int i = 0; i < d.Count(); i++)
            {
                if (budget >= d[i])
                {
                    budget -= d[i];
                    answer++;
                }
            }
            return answer;
        }
        ///풀이 : 각 부서별 원하는 금액 배열을 오름차순으로 정렬한다.(최대한 많은 부서에 나눠주기 위해서)
        ///      그 다음 전체 예산에서 배열에 들어있는 금액을 하나씩 차감하여 차감된 횟수를 리턴한다.

    }
}