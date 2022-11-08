using System;

namespace app
{
    ///위장
    /** 스파이는 위장을 매일 변경한다. 스파이 의상이 담긴 2차원 배열 clothes를 주어질때
        서로 다른 옷의 조합을 수를 반환하시오.
        string[,] sampleData22 = {{"yellow_hat", "headgear"}, 
                                {"blue_sunglasses", "eyewear"}, 
                                {"green_turban", "headgear"}};
    */
    public class Solution48
    {
        public static int solution(string[,] clothes)
        {
            int answer = 1;
            //구분 키, 키에 들어갈 정보리스트 해시구조 만들기  => 모자 , {모자1, 모자2, 모자3}
            Dictionary<string, List<string>> cloDic = new Dictionary<string, List<string>>();
            for (int i = 0; i < clothes.GetLength(0); i++)
            {
                if (!cloDic.ContainsKey(clothes[i, 1]))
                {
                    cloDic[clothes[i, 1]] = new List<string>();
                    {
                        cloDic[clothes[i, 1]].Add(clothes[i, 0]);
                    }
                    foreach (KeyValuePair<string, List<string>> cloth in cloDic)
                    {
                        answer *= cloth.Value.Count() + 1;
                    }
                    answer--;
                }
            }
            return answer;
        }
        //다른방법
        public static int solution1(string[,] clothes)
        {
            int answer = 1;
            Dictionary<string, int> cloDic = new Dictionary<string, int>();
            for (int i = 0; i < clothes.GetLength(0); i++)
            {
                if(cloDic.ContainsKey(clothes[i, 1]))
                {
                    cloDic[clothes[i, 1]]++;
                }
                else
                {
                    cloDic.Add(clothes[i,1], 1);
                }
            }
            foreach (var item in cloDic)
            {
                answer *= (item.Value + 1);
            }
            return answer - 1;
        }
    }
}