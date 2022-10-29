using System;

namespace DesignPattern.FactoryMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {

        }
        
    }
    ///팩토리 메서드 패턴 
    public abstract class Unit
    {
        public string? m_strName;
        public int? m_intAttackPower;
        public int? m_intHealth;
        public abstract void move(string _strPoint);
        public abstract void Attacked(ref Unit _unitTarget);
    }
    public class Marin : Unit
    {
        public Marin(string _strName)
        {
            this.m_strName = _strName;
            this.m_intAttackPower = 6;
            this.m_intHealth = 100;
            Console.WriteLine($"{_strName} : Create Complete");
        }
        public override void Attacked(ref Unit _unitTarget)
        {
            this.m_intHealth -= _unitTarget.m_intAttackPower;
            Console.WriteLine($"{m_strName} 공격당함 : 공격자 -> {_unitTarget.m_strName} " +
                              $" 남은체력 {this.m_intHealth.ToString()}");
        }

        public override void move(string _strPoint)
        {
            Console.WriteLine($"{m_strName} : {_strPoint} 이동 완료");
        }
    }

}