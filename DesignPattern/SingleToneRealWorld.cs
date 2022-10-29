using System;
using System.Collections.Generic;

namespace Singleton.RealWolrd
{
    ///싱글톤 디자인 패턴
    public class Program
    {
        public static void Main(string[] args)
        {
            #region - sample instance
            var b1 = LoadBalancer.GetLoadBalancer();
            var b2 = LoadBalancer.GetLoadBalancer();
            var b3 = LoadBalancer.GetLoadBalancer();
            var b4 = LoadBalancer.GetLoadBalancer();
            #endregion

            //샘플 인스턴스
            if(b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Same instance\n");
            }
            //로드 밸런스 서버 15회 요청 
            var balancer = LoadBalancer.GetLoadBalancer();
            for (int i = 0; i < 15; i++)
            {
                var temp = balancer.NextServer;
                Console.WriteLine($"Dispatch Request to: {temp.Name}, {temp.IP}");
            }

            //유저 응답 
            Console.ReadKey();
        }
    }

    ///싱글톤 클래스
    public class LoadBalancer
    {
        
        //instance라는 맴버 변수에 접근 할 수 있도록 맴버변수를 리턴하는 매서드 생성. 
        private static readonly LoadBalancer instance = new LoadBalancer();
        //서버정보를 담고 있는 리스트
        private readonly List<Server> servers;
        //랜덤 인스턴스 
        private readonly Random random = new Random();
        
        //생성자는 private
        private LoadBalancer()
        {
            //서버리스트
            servers = new List<Server>()
            {
                new Server{Name = "ServerI", IP = "120.14.220.18"},
                new Server{Name = "ServerII", IP = "120.14.220.19"},
                new Server{Name = "ServerIII", IP = "120.14.220.20"},
                new Server{Name = "ServerIV", IP = "120.14.220.21"},
                new Server{Name = "ServerV", IP = "120.14.220.22"}
            };
        }
        //외부에서 사용가능한 메서드
        public static LoadBalancer GetLoadBalancer()
        {
            return instance;
        }
        //랜덤 서버명 리턴 속성
        public Server NextServer
        {
            get
            {
                int r = random.Next(servers.Count);
                return servers[r];
            }
        }

    }
    ///서버속성
    public class Server
    {
        public string? Name {get; set;}
        public string? IP {get; set;}
    }
}