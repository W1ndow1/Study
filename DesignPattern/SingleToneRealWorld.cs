using System;
using System.Collections.Generic;

namespace Singleton.RealWolrd
{
    ///싱글톤 디자인 패턴
    public class Program
    {
        public static void Main(string[] args)
        {
            LoadBalancer b1 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b2 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b3 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b4 = LoadBalancer.GetLoadBalancer();

            //샘플 인스턴스

            if(b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Same instance\n");
            }
            //로드 밸런스 서버 15회 요청 
            LoadBalancer balancer = LoadBalancer.GetLoadBalancer();
            for (int i = 0; i < 15; i++)
            {
                string server = balancer.Server;
                Console.WriteLine($"Dispatch Request to: {server}");
            }

            //유저 응답 
            Console.ReadKey();
        }
    }

    ///싱글톤 클래스
    public class LoadBalancer
    {
        static LoadBalancer? instance {get; set;}
        List<string> servers = new List<string>();
        Random random = new Random();

        //동기 객체 묶기
        private static object locker = new object();

        //생성자
        protected LoadBalancer()
        {
            //서버리스트
            servers.Add("ServerI");
            servers.Add("ServerII");
            servers.Add("ServerIII");
            servers.Add("ServerIV");
            servers.Add("ServerV");
        }

        public static LoadBalancer GetLoadBalancer()
        {
            //멀티스레드 지원 어플리케이션
            if (instance == null)
            {
                lock(locker)
                {
                    if(instance == null)
                    {
                        instance = new LoadBalancer();
                    }
                }
            }
            return instance;
        }
        //랜덤 서버명 리턴
        public string Server
        {
            get
            {
                int r = random.Next(servers.Count);
                return servers[r].ToString();
            }
        }

    }
    
}