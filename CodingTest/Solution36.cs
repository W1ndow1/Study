using System;

namespace app
{
    class Solution36
    {
        ///문자열로 구성된 리스트를 인덱스 n번째 글자를 기준으로 오름차순으로 정렬한다.
        public static string[] solution(string[] strings, int n)
        {
            string[] answer = new string[strings.Length];//배열의 길이만큼 임시 배열생성
            //앞자리에 기준문자 붙이기
            for (int i = 0; i < strings.Length; i++)
            {
                answer[i] = (strings[i][n] + strings[i]);
            }
            //정렬
            Array.Sort(answer);
            //위에서 붙였던 기준문자 삭제
            for (int i = 0; i < strings.Length; i++)
            {
                answer[i] = answer[i].Substring(1);
            }
            return answer;
        }
        ///풀이 앞자리에 n번째 글자를 붙여준다음 정렬을 하고 
        ///출력하기 전에 앞의 n글짜를 삭제하여 반환한다.

        public string[] advancedSolution(string[] strings, int n)
        {
            string[] answer = strings.OrderBy(c=>c).ToArray();
            answer = answer.OrderBy(c=>c[n]).ToArray();
            return answer;
        }

    }
}