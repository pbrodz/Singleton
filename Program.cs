using System;
using System.Collections.Generic;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Singleton.Instance.Server);
            Console.WriteLine(Singleton.Instance.Server);
            Console.WriteLine(Singleton.Instance.Server);
            Console.WriteLine(Singleton.Instance.Server);
            Console.WriteLine(Singleton.Instance.Server);
            Console.ReadLine();
        }
    }

    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> _instance = new Lazy<Singleton>(() => new Singleton());
        private List<string> _servers = new List<string>();
        private Singleton()
        {
            _servers.Add("Server1");
            _servers.Add("Server2");
            _servers.Add("Server3");
            _servers.Add("Server4");
            _servers.Add("Server5");
        }
        public static Singleton Instance
        {
            get
            {
                return _instance.Value;
            }
        }
        public string Server
        {
            get
            {
                int r = new Random().Next(_servers.Count);
                return _servers[r].ToString();
            }
        }
    }
}
