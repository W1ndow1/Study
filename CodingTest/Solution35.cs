using System;

namespace app
{
    ///가장 먼저 탈락하는 사람의 번호와 그 사람이 자신의 몇번째 차례에 탈락하는지 반환하시요

    public static class Solution35
    {
        public static int[] solution35(int n, string[] words)
        {
            int[] answer = new int[2];
            int count = 1;
            //먼저 중복을 찾기
            var duplicate = words.GroupBy(x => x)
            .Where(g => g.Count() > 1)
            .Select(x => x.Key)
            .ToList();
            int dIndex = Array.FindLastIndex(words, e => e == (duplicate.Count() > 0 ? duplicate[0].ToString() : ""));
            if (dIndex != -1)
            {
                dIndex++;
                answer[0] = dIndex % n == 0 ? n : dIndex % n;
                answer[1] = (dIndex % n == 0 ? dIndex / n : (dIndex / n) + 1);
            }
            else
            {
                answer[0] = 0;
                answer[1] = 0;
            }
            //문자열 틀린 부분 확인하기
            for (int i = 0; i < words.Length - 1; i++)
            {
                count++;
                //끝 문자가 다음 첫 문자와 다르면 멈추기
                if (words[i].Length <= 1)
                {
                    answer[0] = 0;
                    answer[0] = 0;
                    break;
                }

                if (words[i][words[i].Length - 1] != words[i + 1][0])
                {
                    answer[0] = count % n == 0 ? n : count % n;
                    answer[1] = (count % n == 0 ? count / n : (count / n) + 1);
                    break;
                }
            }
            return answer;
        }

        public static int[] advancedSolution35(int n, string[] words)
        {
            int[] answer = new int[2];
            int count = 0; //번째 변수
            int time = 1; //턴 변수
            char back = ' ';
            for (int i = 0; i < words.Length; i++)
            {
                if (count == n) { count = 0; time++; }
                count++;
                //한글자 제외
                if (words[i].Length == 1)
                {
                    answer[0] = count;
                    answer[1] = time;
                    return answer;
                }
                //이어 쓰는 단어 비교
                if (i != 0 && back != words[i][0])
                {
                    answer[0] = count;
                    answer[1] = time;
                    return answer;
                }
                back = words[i][words[i].Length - 1];
                for (int j = 0; j < i; j++)
                {
                    if (i != j && words[i] == words[j])
                    {
                        answer[0] = count;
                        answer[1] = time;
                        return answer;
                    }
                }
            }
            return new int[] { 0, 0 };
        }
        public static int[] solution(int n, string[] words)
        {
            List<string> wordList = new List<string>();
            int index = 0;
            foreach (var v in words)
            {
                if (wordList.Count != 0)
                {
                    if (v.Length == 1 || wordList.Contains(v) || wordList[index - 1].Last() != v.First())
                    {
                        return new int[] { index % n + 1, index / n + 1 };
                    }
                }

                wordList.Add(words[index]);
                index++;
            }
            // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다. 
            System.Console.WriteLine("Hello C#");
            return new int[] { 0, 0 };
        }
    }
}