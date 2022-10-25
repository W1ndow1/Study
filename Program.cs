using System;
using static app.Solution;
using static app.Solution29;
using static app.Solution30;
using static app.Solution31;
using static app.Solution32;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(-1 * 1);
            //Console.WriteLine("안녕하세요");
            //Console.WriteLine(solution("one4seveneight"));
            //Console.WriteLine(solution1(118372));
            //Console.WriteLine(solution2("-1827"));
            //Console.WriteLine(solution3(4, 3));
            //Console.WriteLine(solution4(10)); // 10 3
            //Console.WriteLine(solution5(626331));
            //Console.WriteLine(solution6(5, 3));
            //string[] sData = {"Jane", "Kim"};
            //Console.WriteLine(solution7(sData));
            //Console.WriteLine(solution8("0444"));
            //int[] sampleData = { 2, 36, 1, 3 };
            // Console.WriteLine(solution9(sampleData, 1));
            // int[] sampleData2 = { 10 };
            // Console.WriteLine(solution10(sampleData2));
            // int[] sampleData3 = {4, 7, 12};
            // bool[] sampleData4 = {true, false, true};
            // Console.WriteLine(solution11(sampleData3, sampleData4));
            // int[] sampleData5 = {1,2,3,4,6,7,8,0};
            // Console.WriteLine(solution12(sampleData5));
            // Console.WriteLine(solution13(3));
            // Console.WriteLine(solution14("abcdefg"));
            // int[] sampleData6 = {1,2,3,4};
            // int[] sampleData7 = {-3,-1,0,2};
            // Console.WriteLine(solution15(sampleData6, sampleData7));
            // Console.WriteLine(solution16("Zbcdefg"));
            // Console.WriteLine(solution17("-1 -2 -3 -4"));
            //Console.WriteLine(solution18("1234"));
            //Console.WriteLine(solution19(13, 17));
            //Console.WriteLine(solution20("A  Aa"));
            // int[,] sampleData8 = {{1}, {2}};
            // int[,] sampleData9 = {{3}, {4}};
            // Console.WriteLine(solution21(sampleData8, sampleData9));
            // Solution sl = new Solution();
            // Console.WriteLine(sl.solution002(3, 20, 4));
            //Console.WriteLine(solution22(5, 3));
            //Console.WriteLine(solution23(51, 59));
            // int[] sampleData10 = {1, 4, 2};
            // int[] sampleData11 = {5, 4, 4};
            // Console.WriteLine(solution24(sampleData10, sampleData11));
            //Console.WriteLine(solution25("()()"));
            //Console.WriteLine(solution26("01110"));
            //Console.WriteLine(solution27("try hello world"));
            //Console.WriteLine(solution28(45));
            //Console.WriteLine(Pibonachi(3));
            // int[] sampleData12 = {1,3,2,5,4};
            //Console.WriteLine(solution30(sampleData12, 9));
            //Console.WriteLine(solution31(78));            
            //Console.WriteLine(advancedSolution32("AB", 1));
            // int[,] sampleData13 = {{60, 50}, {30, 70}, {60, 30}, {80, 40}};
            // Console.WriteLine(Solution33.solution33(sampleData13));
            //Console.WriteLine(Solution34.solution34(10, 2));
            // string[] sampleData14 = {"o", "one", "even", "never", "raw", "aim"};
            // Console.WriteLine(Solution35.solution35(2, sampleData14));
            string[] sampleData15 = {"sun", "bed", "car"};
            Console.WriteLine(Solution36.solution(sampleData15, 1));
        }

        ///3진법 뒤집기
        private static int solution28(int n)
        {
            // int answer = 0;
            // List<int> threeList = new List<int>();
            // while(true)
            // {
            //     if(n==0)
            //     {
            //         break;
            //     }
            //     int a = n%3;
            //     threeList.Add(a);
            //     n = n/3;
            // }
            // threeList.Reverse();
            // //10진법 만들기
            // for (int i = 0; i < threeList.Count(); i++)
            // {
            //     answer += (int)(threeList[i] * Math.Pow(3, i));
            // }
            // return answer;

            int answer = 0;
            while (n > 0)
            {
                answer *= 3;
                answer += n % 3;
                n /= 3;
            }
            return answer;
        }
        ///이상한 문자 만들기
        ///각 단어의 짝수번째 알파벳은 대문자로 홀수번째 알파벳은 소문자로 리턴하기
        ///"try hello world" 이렇게 넘어오면 "TrY HeLlO WoRlD" 이렇게 리턴하라
        private static string solution27(string s)
        {
            // string answer = "";
            // string[] tempStr = s.Split(' ');
            // for (int i = 0; i < tempStr.Count(); i++)
            // {
            //     for (int j = 0; j < tempStr[i].Count(); j++)
            //     {
            //         if(j == 0)//0번째는 항상 짝수로 
            //         {
            //             answer += Char.ToUpper(tempStr[i][j]);
            //             continue;
            //         }
            //         //짝수일때 대문자 홀수일때 소문자
            //         answer += j%2 == 0 ? Char.ToUpper(tempStr[i][j]) : Char.ToLower(tempStr[i][j]); 
            //     }
            //     //단어 사이에 띄어씌기
            //     if(i != tempStr.Length - 1)
            //     {
            //         answer += " ";
            //     }
            // }
            // return answer;
            string answer = "";
            int num = 0; //띄어쓰기
            for (int i = 0; i < s.Length; i++)
            {
                answer += num%2 == 0 ? s[i].ToString().ToUpper() : s[i].ToString().ToLower();
                num = s[i] == ' ' ? 0 : num + 1;
            }
            return answer;
        }

        ///이진 변환 반복하기
        private static int[] solution26(string s)
        {
            // int[] answer = new int[2];
            // int zeroCount = 0; //이진 변환의 횟수
            // int wholeCount = 0; //제거된 모든 0의 개수
            // while(s != "1")
            // {
            //     //1의 갯수
            //     int tempCount = 0;
            //     for(int i = 0; i<s.Length; i++)
            //     {
            //         if(s[i] == '1')
            //         tempCount++;
            //     }
            //     //0의 갯수 = 전체길이 - 1의 갯수 
            //     zeroCount += s.Length - tempCount;
            //     s = "";
            //     //1갯수 
            //     while(tempCount > 0)
            //     {
            //         if(tempCount % 2 == 0)
            //         {
            //             s += "0";
            //         }else{
            //             s += "1";                                                                
            //             tempCount /= 2;
            //         }
            //     }
            //     wholeCount++; 
            //      //2진법 문자열을 10진법 정수형으로
    
            // }
            // answer[0] = wholeCount;
            // answer[1] = zeroCount;
            // return answer;
            int[] answer = new int[] { 0, 0 };
            while (!s.Equals("1"))
            {
                answer[0]++;
                var OneCharCount = s.Where(x => x.Equals('1')).Count();
                answer[1] += s.Length - OneCharCount;

                s = Convert.ToString(OneCharCount, 2);
            }

            return answer;
        }

        ///올바른 괄호
        private static bool solution25(string s)
        {
            bool answer = true;
            if(s[0] == ')')
            {
                return false;
            }
            int count = 0;
            for(int i = 0; i<s.Length; i++)
            {
                if(s[i] == '(')
                {
                    count += 1;
                }
                else
                {
                    count -= 1;
                    if(count < 0) return false;
                }
            }
            answer = count == 0 ? true : false;
            return answer;
        }

        ///최소값 만들기
        private static int solution24(int[] a, int[] b)
        {
            int answer = 0;
            Array.Sort(a);
            Array.Sort(b);
            Array.Reverse(b);
            for (int i = 0; i < a.Length; i++)
            {
                answer += a[i]*b[i];
            }
            return answer;
        }

        ///두수 입력 받아서 최대공약수와 최소공배수
        private static int[] solution23(int n, int m)
        {
            int[] answer = new int[2];
            //최대공약수
            int min = gcd(n, m);
            //최대공배수
            int max = (n*m)/min;
            answer[0] = min;
            answer[1] = max;
            return answer;
        }

        private static int gcd(int n, int m)
        {
            return n%m == 0 ? n : gcd(m, n%m);
        }


        ///직사각형 별찍기
        private static bool solution22(int n, int m)
        {   //가로n 세로m
            for (int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write("*");    
                }
                Console.Write("\n");
            }
            return true;
        }





        ///행렬의 덧셈
        private static int[,] solution21(int[,] arr1, int[,] arr2)
        {
            //넘어오는 행렬 크기 맞추기
            int[,] answer = new int[arr1.GetLength(0), arr1.GetLength(1)];
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    answer[i, j] = arr1[i, j] + arr2[i, j];
                }
            }
            return answer;
        }

        ///JadenCase문자열 만들기
        private static string solution20(string s)
        {
            // string[] temp = s.Split(' ');
            
            // foreach(string str in temp)
            // {
            //     if (str.Length != 0)
            //     {
            //         answer += $"{str.Substring(0, 1).ToUpper()}{str.Substring(1).ToLower()} ";    
            //     }
            // }
            // answer = answer.Substring(0, answer.Length -1);
            // return answer;
            string answer = "";
            //소문자로 변경
            s = s.ToLower(); 
            char[] tempchar = s.ToCharArray();
            for (int i = 0; i < tempchar.Length; i++)
            {
                tempchar[0] = char.ToUpper(tempchar[0]);
                if(tempchar[i] == ' ' && i+1 < tempchar.Length)
                {
                    tempchar[i+1] = char.ToUpper(tempchar[i+1]);
                }
            }
            for (int i = 0; i < tempchar.Length; i++)
            {
                answer += tempchar[i];
            }
            return answer;
        }


        ///약수 덧샘 뺄셈

        private static int solution19(int left, int right)
        {
            int answer = 0;
            for (int i = left; i <= right; i++)
            {
                int count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                answer = count%2 == 0 ? answer += i : answer -= i;
            }
            return answer;
        }
        ///문자열 다루기 기본
        private static bool solution18(string s)
        {
            int n;
            bool isNumberic = int.TryParse(s, out n); 
            return isNumberic;
        }

        ///최대값과 최소값
        private static string solution17(string s)
        {
            string answer = "";
            //int[] temp_int = Array.ConvertAll(s.Split(' '), a => int.Parse(a));
            int[] temp_int = s.Split(' ').Select(int.Parse).ToArray();
            answer = $"{temp_int.Min().ToString()} {temp_int.Max().ToString()}";
            return answer;
        }

        ///문자열 내림차순으로 배치하기
        private static string solution16(string s)
        {
            string answer = "";
            char[] temp = s.ToCharArray();
            Array.Sort(temp);
            Array.Reverse(temp);
            answer = new string(temp);
            return answer;
        }

        ///내적
        private static int solution15(int[] a, int[] b) 
        {
            // int answer = 0;
            // for (int i = 0; i < a.Count(); i++)
            // {
            //     answer += a[i] * b[i];
            // }
            // return answer;
            //Linq 사용시
            return a.Zip(b, (t1, t2) => t1 * t2).Sum();
        }

        ///가운데 글자 가져오기
        private static string solution14(string s)
        {
            string answer = "";
            if(s.Length%2 == 0)
            {
                //짝수
                answer = s.Substring((s.Length/2) -1, 1) + s.Substring(s.Length/2, 1);
            }
            else{
                //홀수
                answer = s.Substring(s.Length/2, 1);
            }
            return answer;
        }

        ///수박수박수박수박수박수?
        private static string solution13(int n)
        {
            //(1)홀수면 수, 짝수면 박으로 끝이남
            //(2)n값과 리턴되는 문자열의 길이는 같음 
            string answer = "";
            for (int i = 1; i <= n; i++)
            {
                answer += i%2 == 0 ? "박" : "수";
            }
            return answer;
        }

        ///없는 숫자 더하기
        private static int solution12(int[] numbers)
        {
            //0~9까지 더하면 45이므로 넘어온 배열을 더한 다음 뺀 값을 리턴하면된다.
            // int answer = 0;
            // foreach(int num in numbers)
            // {
            //     answer += num;
            // }
            // answer = 45 - answer;
            // return answer;
            
            //Linq 사용
            var numberArray = new int[] {1,2,3,4,5,6,7,8,9};
            return numberArray.Except(numbers).Sum();
        }

        ///음양 더하기
        private static int solution11(int[] absolutes, bool[] sign)
        {
            // 일반 방식
            // int answer = 0;
            // for (int i = 0; i < absolutes.Count(); i++)
            // {
            //     answer += absolutes[i] * (sign[i] == true ? 1 : -1);
            // }
            // return answer;
            
            //람다로 하는법
            return absolutes.Select((t, idx) => sign[idx]? t : -t).Sum();

        }

        ///제일 작은수 제거하기
        private static int[] solution10(int[] arr)
        {
            List<int> aList = arr.ToList();
            int[] answer = new int[] { };
            if (aList.Count() == 1)
            {
                aList = new List<int>();
                aList.Add(-1);
            }
            else
            {
                aList.Min();
                aList.Remove(aList.Min());
            }
            return aList.ToArray();
            //LINQ 사용해서 하는방법
            // int v = arr.Min();
            // int[] answer = arr.Where(x => x != v).ToArray();
            // if (answer.Count() == 0)
            // {
            //     answer = new int[] { -1 };
            // }
            // return answer;
        }

        //나누어 떨어지는 숫자배열
        private static int[] solution9(int[] arr, int divisor)
        {
            List<int> aList = new List<int>();
            foreach (int num in arr)
            {
                if (num % divisor == 0)
                {
                    aList.Add(num);
                }
            }
            if (aList.Count == 0)
            {
                aList.Add(-1);
            }
            aList.Sort();
            return aList.ToArray();
        }

        //핸드폰 번호 가리기
        private static string solution8(string phone_number)
        {
            // string answer = "";
            // if(phone_number.Length > 4)
            // {
            //     string fNum = phone_number.Substring(0, phone_number.Length - 4);
            //     answer = new String('*', fNum.Length);
            // }
            // string bNum = phone_number.Substring(phone_number.Length - 4);
            // answer += bNum;
            // return answer;
            string answer = phone_number.Substring(phone_number.Length - 4);
            answer = answer.PadLeft(phone_number.Length, '*');
            return answer;

        }

        //서울에서 김서방 찾기
        private static string solution7(string[] seoul)
        {
            // //(1)
            // int number = 0;
            // foreach (var item in seoul)
            // {
            //     if(item == "Kim")
            //     {
            //         break;
            //     }
            //     number++;
            // }
            // string answer = $"김서방은 {number}에 있다.";
            // return answer;
            int answer = 0;
            answer = Array.FindIndex(seoul, i => i == "Kim");
            return string.Format("김서방은 {0}에 있다", answer);
        }

        //두 정수 사이의 합
        private static long solution6(int a, int b)
        {
            //long answer = 0;
            // int temp = 0;
            // if (a > b)
            // {
            //     temp = a;
            //     a = b;
            //     b = temp;
            // }
            // for (int i = a; i <= b; i++)
            // {
            //     answer += i;
            // }
            return ((long)(Math.Abs(a - b) + 1) * (a + b) / 2);
            //return answer;
        }

        ///콜라츠 추측
        private static int solution5(long num)
        {
            int answer = 0;
            while (num > 1)
            {
                if (num % 2 == 0)
                {
                    num = num / 2;
                }
                else
                {
                    num = num * 3 + 1;
                }
                answer++;
                if (answer == 500)
                {
                    return -1;
                }
            }
            return answer;
        }

        ///나머지가 1이 되는 수 찾기
        private static int solution4(int n)
        {
            int answer = 1;
            while (n % answer != 1)
            {
                answer++;
            }
            return answer;
        }

        ///배수 구하기
        private static long[] solution3(int x, int n)
        {
            long[] answer = new long[n];
            for (int i = 0; i < n; i++)
            {
                answer[i] = (long)x * (i + 1);
            }
            return answer;
        }

        ///문자열을 정수로 바꾸기
        private static long solution2(string s)
        {
            long answer = 0;
            answer = Int16.Parse(s);
            return answer;
        }

        ///정수 내림차순으로 배치
        private static object solution1(long n)
        {
            long answer = 0;
            char[] temp = n.ToString().ToCharArray();
            Array.Sort(temp);
            Array.Reverse(temp);
            answer = Convert.ToInt64(new string(temp));
            return answer;
        }

        ///
        static public int solution(string s)
        {
            Dictionary<string, string> data = new Dictionary<string, string>()
            {
                {"zero", "0"},
                {"one", "1"},
                {"two", "2"},
                {"three", "3"},
                {"four", "4"},
                {"five", "5"},
                {"six", "6"},
                {"seven", "7"},
                {"eight", "8"},
                {"nine", "9"}
            };

            foreach (var keyValuePair in data)
            {
                s = s.Replace(keyValuePair.Key, keyValuePair.Value);
            }
            return Convert.ToInt32(s);
        }
    }
}