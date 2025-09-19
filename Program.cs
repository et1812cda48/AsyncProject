using System;
using System.Threading.Tasks;

namespace AsyncProject
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var rand = new Random();
            int n_rockets;

            while(true)
            {
                Console.Write("Enter rockets' number: ");
                n_rockets = Convert.ToInt32(Console.ReadLine());
                if (n_rockets <= 0) break;
                Console.Clear();
                Console.WriteLine($"Rockets' number: {n_rockets}");
                await Run(n_rockets);                
            }
        }
        static async Task Run(int n_rockets)
        {
            Rocket rocket;
            Task[] tasks = new Task[n_rockets];
            for (var i = 0; i < n_rockets; i++)
            {
                rocket = new Rocket($"Rocket №{i + 1}");
                tasks[i] = rocket.Start();
            }
            Task.WaitAll(tasks);
            Console.WriteLine("\nAll rockets were started!!!\n");
        }
    }
}
