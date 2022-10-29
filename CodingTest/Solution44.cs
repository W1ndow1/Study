using System;

namespace app
{   
    ///H Index
    ///
    public class Solution44
    {
        //논문 n편중 h번 이상 인용된 논문이 h 편이상이고 나머지가 h번 이하
        //등재한 전체 논문중 많이 인용된 순으로 정렬하고
        //논문 수와 같아 지거나 작어지기 시작하면 H Index
        public static int Solution(int[] citations)
        {
            int answer = 0;
            //3,0,6,1,5
            Array.Sort(citations);
            Array.Reverse(citations);
            //6,5,3,1,0
            for (int i = 0; i < citations.Length; i++)
            {
                if((i+1 <= citations[i]))
                {
                    answer++;
                }
            }
            return answer;

        }
    }
}