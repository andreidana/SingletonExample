using System;

namespace SingletonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var singletonInstance = SingletonDesignPattern.GetInstance();

            Console.WriteLine(singletonInstance.GetInstanciatedVariable());
        }
    }
}
