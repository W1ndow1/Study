using System;

namespace app
{   
    ///2016년
    ///2016년 1월1일은 금요일 입니다. 2016년 a월 b일은 무슨요일인가? 두수 a,b를 입력받아 무슨 요일인지 리턴하시요
    ///윤년 -> 2월이 29일
    public class Solution45
    {
        public static string solution(int a, int b)
        {
            string[] strDay = {"FRI", "SAT","SUN", "MON" ,"TUE", "WED", "THU"} ;
            int[] lastDay = {31,29,31,30,31,30,31,31,30,31,30,31};
            int totalDay = 0;
            for (int i = 0; i < a - 1; i++)
            {
                totalDay += lastDay[i];
            }
            totalDay += b - 1;
            string answer = "";
            answer = strDay[totalDay % 7];
            return answer;
        }

        public static string solution1(int a, int b)
        {
            string answer = "";
            DateTime date = new DateTime(2016, a, b);
            answer = date.DayOfWeek.ToString();
            answer = answer.Substring(0, 3).ToUpper();
            return answer;
        }

    }
}
//일 월 화 수 목 금 토
//             1 2
//3 4 5 6 7 8 9 10