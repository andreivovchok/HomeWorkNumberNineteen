using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncConsoleApp
{
    class Program
    {
        public static void DoAction(string text, int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(text);
                Thread.Sleep(100);
            }
        }

        static void Main(string[] args)
        {
            Do();
            Console.ReadKey();
        }

        private static async void Do()
        {
            await Task.Run(() => DoAction("ff", 2));
            Task.Run(() => DoAction("aa", 2));
        }
    }
}
