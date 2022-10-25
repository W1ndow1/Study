using System;

namespace app
{
    public static class Solution34
    {
        ///카펫
        ///갈색 갈색 갈색 갈색
        ///갈색 노랑 노랑 갈색
        ///갈색 갈색 갈색 갈색
        ///위와 같은 카펫을 봤음 집에와서 노락색과 갈색으로 색칠된 격자의 수는 기억했으나
        ///전체 카펫의 크기는 기억을 하지 못했다. 
        ///격자의 수가 각각 주어질때 카펫의 가로 세로를 반환해라   [10, 2]
        ///*카펫의 가로 길이는 세로길이와 같거나 길다.
        public static int[] solution34(int brown, int yellow)
        {
            //주어진 갯수를 더하면 크기가 나옴, 이때 크기는 반환하는 배열 의 곱
            int[] answer = new int[2];
            int sum = brown + yellow;
            int h = 0;
            int v = 0;
            for (int i = 1; i <= brown; i++)
            {
                h = i; //가로
                v = sum / h; //세로
                if(h >= v)
                {
                    if((sum - ((h*2)+(v*2) - 4)) == yellow)
                    {
                        answer[0] = h;
                        answer[1] = v;
                        break;
                    }
                }
            }
            return answer;
        }
    }
}