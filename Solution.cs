using System;

namespace app
{
    public class Solution
    {
        public int[] solution001(int[] arr)
        {
            int[] answer = new int[]{};
            return answer;
        }
        ///부족한 금액 계산하기 (3, 20, 4) = 10
        internal long solution002(int price, int money, int count)
        {
            //이용료가 price일때  N번째 이용하면 N배로 값을 받는다.
            long answer = 0;
            long nPrice = 0;//n번 탔을때 가격
            for (int i = 1; i <= count; i++)
            {
               nPrice += price * i;
            }
            answer = nPrice - money;
            return answer;
        }
    }
}