using System;

namespace SingletonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstInstance = SingletonDesignPattern.GetInstance(1);
            var secondInstance = SingletonDesignPattern.GetInstance(2);
            var thirdInstance = SingletonDesignPattern.GetInstance(3);

            Console.WriteLine(firstInstance.GetInstanciatedVariable());
            Console.WriteLine(secondInstance.GetInstanciatedVariable());
            Console.WriteLine(thirdInstance.GetInstanciatedVariable());
        }
    }
}
