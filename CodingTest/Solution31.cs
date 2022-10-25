using System;
using System.Text.RegularExpressions;

namespace app
{
    public static class Solution31
    {
        ///다음 큰 숫자
        ///자연수 n이 주어졌을 때, n의 다음 큰 숫자는 다음과 같이 정의한다.
        ///(1) n 다음 큰숫자는 n보다 큰 자연수
        ///(2) n 다음 큰 숫자와 n은 2진수로 변환했을때 1의 갯수가 같다.
        ///(3) n 의 다음 큰 숫자는 조건 1, 2를 만족하는 숫자중 가장 작은 수이다.

        public static int solution31(int n)
        {
            int answer = 0;
            char[] cTemp = Convert.ToString(n, 2).ToCharArray();
            int oneCount = getOneCount(cTemp);
            int pNum = n + 1;
            while (true)
            {
                cTemp = Convert.ToString(pNum, 2).ToCharArray();
                if(oneCount == getOneCount(cTemp))
                {
                    return answer = pNum;
                }
                pNum++;
            }
        }
        ///2진수에서 1의 갯수 구하기
        public static int getOneCount(char[] cTemp)
        {
            int oneCount = 0;
            foreach (char item in cTemp)
            {
                if (item == '1')
                {
                    oneCount++;
                }
            }
            return oneCount;
        }
        ///풀이
        ///(1)자연수가 무엇인가?
        ///(2)이진수로 변환하여 1의 갯수를 자연수n과 비교한다.

        public static int iSolution31(int n)
        {
            int answer = 0;
            int temp = Regex.Matches(Convert.ToString(n, 2), "1").Count();
            while(true)
            {
                if(temp == Regex.Matches(Convert.ToString(++n, 2), "1").Count())
                {
                    break;
                }
            }
            answer = n;
            return answer;
        }
    }

}
