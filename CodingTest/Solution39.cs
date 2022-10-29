using System;

namespace app
{
    ///두개 뽑아서 더하기
    ///정수 배열이 주어진다. 서로 다른 인덱스에 있는 두개의 수를 뽑어서 더해서 만들수 있는 모든
    ///배열에 오름차순으로 담아 리턴하시오
    public class Solution39
    {
        public static int[] solution(int[] numbers)
        {
            int[] answer = new int[] {};
            List<int> tempList = new List<int>();
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int tempNum = (numbers[i] + numbers[j]);
                    if(!tempList.Contains(tempNum))
                    {
                        tempList.Add(tempNum);
                    }
                }
            }
            tempList.Sort();
            answer = tempList.ToArray();
            return answer;
        }
    }
}