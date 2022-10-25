using System;
using System.Linq;

namespace app
{
    public static class Solution33
    {
        ///최소 직사각형(완전 탐색)
        ///명함 지갑 크기를 정하려고 가로 세로 크기를 조사한 결과가 있는데 
        ///이중에서 모든 명함을 수납 할 수 있는 가장 작은 지갑 사이즈는?
        public static int solution33(int[,] sizes)
        {
            int answer = 0;
            List<int>aList = new List<int>();
            List<int>bList = new List<int>();
            for (int i = 0; i < sizes.GetLength(0); i++)
            {
                if(sizes[i, 0] > sizes[i, 1])
                {
                    Swap<int>(ref sizes[i, 0], ref sizes[i, 1]);
                }
                aList.Add(sizes[i, 0]);
                bList.Add(sizes[i, 1]);
            }
            aList.Sort();
            bList.Sort();
            answer = aList.Max() * bList.Max();
            return answer;
        }
        ///스왑함수
        public static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
        ///풀이
        ///(1)2차원 배열에서 2개의 1차원 배열로 변경 한다음 두개의 배열을 비교하여 큰값을 한쪽으로 이동시킨다.
        ///(2)그다음 두개의 1차원 배열에서 가장 큰수를 구한 다음 면적을 계산하여 반환한다.

        ///다른 사람 풀이
        public static int advancedSolution33(int[,] sizes)
        {
            int wmax = 0;
            int hmax = 0;

            int rlen = sizes.GetLength(0);
            for (int i = 0; i < rlen; i++)
            {
                if (sizes[i, 0] < sizes[i, 1])
                {
                    int t = sizes[i, 0];
                    sizes[i, 0] = sizes[i, 1];
                    sizes[i, 1] = t;
                }

                if (wmax < sizes[i, 0])
                    wmax = sizes[i, 0];

                if (hmax < sizes[i, 1])
                    hmax = sizes[i, 1];

            }
            return wmax * hmax;
        }
    }
}