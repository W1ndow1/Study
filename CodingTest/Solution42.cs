namespace app
{
    ///점프와 순간이동
    ///순간이동시 베터리 줄지 않음, 허나 순간이동은 현재 까지 온거리 X2로만 이동 가능
    ///배터리는 일반 이동시에만 줄어든다. 1칸에 1씩
    ///이동거리n이 주어질때 건전지 사용량 최소값을 반환해라
    public class Solution42
    {
        public static int solution(int n)
        {
            //5 -> 2
            //배터리가 가장 많이 드는건 순간이동 안하고 그냥 가는 경우
            //구해야 하는건 일반 이동 거리 = 건전지 사용량
            //순간이동은 몇번을 해도 상관없음 
            int answer = 1; //건전지 사용량
            while(n != 1)
            {
                if(n%2 != 0) //홀수일때
                {
                    n-= 1;
                    ++answer;
                }
                else //짝수일때
                {
                    n = n/2;
                }
            }
            return answer;
        }

        public static int solution1(int n)
        {
            int result = 0;
            while(n>1)
            {
                result += n%2;
                n = n/2;
            }
            return result + 1;
        }
    }
}