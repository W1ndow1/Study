using System;

namespace DesignPattern.Singleton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();
            
            if(s1 == s2)
            {
                Console.WriteLine("Objectes are the same instance");
            }

            Console.ReadKey();
        }
    }   

    public class Singleton
    {
         static Singleton? instance {get; set;}
         //생성자 만들기
        protected Singleton()
        {

        }
        //메서드 생성
        public static Singleton Instance()
        {
            if(instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}