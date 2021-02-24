using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ensure a class has only one instance and provide a global point of access to it.

            Console.WriteLine("Hello World!");
        }
    }

    /// <summary>
    /// lazily initialized.
    /// </summary>
    class Singleton
    {
        private static Singleton instance;
        private static readonly object syncRoot = new object();
        private Singleton() { }

        public static Singleton GetInstance()
        {
            // Support multithreaded applications through
            // 'Double checked locking' pattern which (once
            // the instance exists) avoids locking each
            // time the method is invoked
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }
            return instance;
        }

    }

    // Static members are 'eagerly initialized', that is, 
    // immediately when class is loaded for the first time.
    // .NET guarantees thread safety for static initialization
    public sealed class Singleton2
    {
        private static readonly Singleton2 instance = new Singleton2();
        private Singleton2() { }
        public static Singleton2 GetInstance()
        {
            return instance;
        }
    }
}
