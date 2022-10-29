namespace app
{
    ///삼총사
    ///주어진 배열에서 3개의 숫자를 더했을때 0이 나오면 삼총사라고 한다.
    public class Solution41
    {
        //-2, 3, 0, 2, -5
        public static int solution(int[] number)
        {
            int answer = 0;
            for (int i = 0; i < number.Length; i++)
            {
                for(int j = i + 1; j < number.Length; j++)
                {
                    for (int k = j + 1; k < number.Length; k++)
                    {
                        answer = number[i] + number[j] + number[k] == 0 ? ++answer : answer;
                    }
                }
            }
            return answer;
        }
    }
}