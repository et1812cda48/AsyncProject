using System;
using System.Threading.Tasks;

namespace AsyncProject
{
    class Rocket
    {
        string name;
        int count;
        public Rocket(string name)
        {
            int max = 28, min = 5;
            var rand = new Random();
            this.count = rand.Next(min, max);
            this.name = name;
            //this.Start();
        }

        public async Task Start()
        {
            while(this.count > 0)
            {
                Console.WriteLine($"{this.name}:\t{this.count}");
                this.count -= 1;
                await Task.Delay(1000);
            }
            Console.WriteLine($"{this.name}:\trun!!!");
        }
    }
}
