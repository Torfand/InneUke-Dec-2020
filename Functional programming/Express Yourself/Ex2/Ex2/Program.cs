using System;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace Ex2
{
    public sealed class MySingleton
    {
        private static MySingleton _instance;

        public MySingleton()
        {
        }

        public static MySingleton Instance => _instance ?? (_instance = new MySingleton());
        public override string ToString() => $"Type Name : {GetType().Name.Split('+')[0]}";
    }

    class Program
    {
        static void Main(string[] args)
        {
            var ins1 = MySingleton.Instance;
            var ins2 = MySingleton.Instance;
            var referenceEquals = ReferenceEquals(ins1, ins2);
            Console.WriteLine($"SameObject?,\n {referenceEquals}");
            Console.WriteLine($"{ins1}");
        }
    }
}