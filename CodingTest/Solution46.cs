using System;

namespace app
{
    ///행렬의 곱셈
    public class Solution46
    {
        public static int[,] solution(int[,] arr1, int[,] arr2)
        {
            int row = arr1.Length / arr1.GetLength(1);// arr1의 가로크기
            int col = arr2.Length / (arr2.Length / arr2.GetLength(1)); // arr1의 세로크기
            //3, 2
            int[,] answer = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    int m = 0;
                    while(m < arr2.GetLength(0))
                    {
                        answer[i, j]  += arr1[i, m] * arr2[m, j];
                        m++;
                    }
                }
                //00, 01
            }
            return answer;
        }
    }
}