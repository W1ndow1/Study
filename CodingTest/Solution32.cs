using System;
using System.Linq;

namespace app
{
    public static class Solution32
    {
        ///시저 암호
        ///어떤 문자의 알파펫을 일정 거리만큼 밀어서 다른 알파벳으로 변경하는 암호화 방식을 시저 암호라 한다.
        ///"AB"를 1만큼 밀면 "BC가 되는 방식이다.
        public static string solution32(string s, int n)
        {
            string answer = "";
            char[] temp = s.ToCharArray();
            for (int i = 0; i < temp.Length; i++)
            {
                //공백처리
                if(temp[i] == ' ')
                {
                    answer += temp[i].ToString();
                    continue;
                }
                //shift 처리
                for (int j = 0; j < n; j++)
                {
                    if(temp[i] == 'Z') //Z일때 다음으로
                    {
                        temp[i] = 'A';
                    }
                    else if(temp[i] == 'z') //z일때 다음으로
                    {
                        temp[i] = 'a';
                    }
                    else
                    {
                        temp[i] = (char)(temp[i] + 1);//나머지는 1칸씩 shift한다
                    }
                }
                answer += temp[i].ToString();
            }
            return answer;
        }
        ///풀이 (1)알파벳 배열에서 넘어온 n값에 맞춰서 shift를 한다.
        ///    (2)대소문자는 어떻게 할것인가? => char 배열 형식으로 바꾸면 정수형처럼 사용이 가능하다.

        public static string advancedSolution32(string s, int n)
        {
            string answer = "";
            char[] temp = s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                if((temp[i] >= 'a' && temp[i] <= 'z') || (temp[i] >='A' && temp[i] <= 'Z'))
                {
                    if(char.IsUpper(temp[i])) //대문자이면
                    {
                        temp[i] = (char)((temp[i] + n - 'A') % 26 + 'A');
                    }
                    else //소문자이면
                    {
                        temp[i] = (char)((temp[i] + n - 'a') % 26 + 'a');
                    }
                }
            }
            answer = new string(temp);
            return answer;
        }
    }
}
