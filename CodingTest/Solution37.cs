using System;

namespace app
{
    class Solution37
    {
        ///K번째 수(정렬)
        ///i번째 숫자부터 j번째 숫자까지 자르고 정렬했을때 k번째에 있는 수를 구하기
        public static int[] solution(int[] array, int[,] commands)
        {
            int[] answer = new int[commands.GetLength(0)];
            for (int i = 0; i < commands.GetLength(0); i++)
            {
                int a = commands[i, 0];
                int b = commands[i, 1];
                int c = commands[i, 2];
                int[] segment = new ArraySegment<int>(array, a - 1, (a==b? 1 : b - 1)).ToArray();
                Array.Sort(segment);
                answer[i] = segment[c - 1];
            }
            return answer;
        }

        public static int[] solution01(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];
        for (int i = 0; i < commands.GetLength(0); i++)
        {
            int a = commands[i,0];
            int b = commands[i,1] + 1;
            int c = commands[i,2];
            int [] sub = new int[b-a];

            Array.Copy(array,a-1,sub,0,b-a);

            Array.Sort(sub);
            answer[i] = sub[c-1];
        }
        return answer;
    }
    }
}