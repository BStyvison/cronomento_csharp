using System.Threading;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args) 
        {
            Menu();
            /* start(); */
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S - Segundos");
            Console.WriteLine("M - Minutos");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            char type =char.Parse(data.Substring(data.Length - 1,1)) ;
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if(type == 'm')
                multiplier = 60;

            if(time == 0)
                System.Environment.Exit(0);


            
            PreStart(time * multiplier);

        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(800);
            Console.WriteLine("Set...");
            Thread.Sleep(800);
            Console.WriteLine("Go...");
            Thread.Sleep(1500);

            start(time);
            

        }
        static  void start(int time)
        {
            int currentTime = 0;
            
            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Cronometro Finalizado...");
            Thread.Sleep(1500);
            Menu();
        }

    }
}
