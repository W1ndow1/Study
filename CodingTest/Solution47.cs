using System;

namespace app
{
    ///괄호 회전하기
    public class Solution47
    {
        public static int solution(string s)
        {
            //올바른 문자열 확인
            int answer = 0;
            List<char> listChar = s.ToList<char>();
            for (int i = 0; i < s.Length; i++)
            {
                bool isOK = IsRightBracket(listChar);
                if(isOK)
                    answer++;
                char c = listChar[0];
                listChar.RemoveAt(0);
                listChar.Add(c);      
            }
            return answer;
        }

        private static bool IsRightBracket(List<char> tempChar)
        {
            Stack<char> st = new Stack<char>();
            foreach (char c in tempChar)
            {
                switch(c)
                {
                    case '(':
                    case '{':
                    case '[':
                    {
                        st.Push(c);
                    }
                    break;
                    case ')':
                    case '}':
                    case ']':
                    {
                        if(st.Count == 0)
                        {
                            return false;
                        }
                        char pop_C = st.Pop();
                        if(!(pop_C + 1 == c || pop_C + 2 == c))
                        {
                            return false;
                        }
                    }
                    break;
                }
            }
            return st.Count > 0  ? false : true;
        }

        public static char[] shiftChar(char[] tempChar)
        {
            int size = tempChar.Length;
            char[] shiftChar = new char[size];
            for (int i = 0; i < size; i++)
            {
                shiftChar[i] = tempChar[(i + 1) % size];
            }
            return shiftChar;
        }
    }
}