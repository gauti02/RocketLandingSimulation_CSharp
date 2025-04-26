using System.Reflection.Metadata;

namespace RocketLandingSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rocket1 = "   | ";
            string rocket2 = "  / \\ ";
            string rocket3 = " |   |";
            string rocket4 = " -----";
            string rocket5 = " // \\\\";
            string fullRocket = rocket1 + "\n" + rocket2 + "\n" + rocket3 + "\n" + rocket4 + "\n" + rocket5;
            string ground = "---------";
            string emptyString = "";

            for (int i = 0; i < 6; i++)
            {
                Console.Clear();
                Console.WriteLine("Counter: {0}",i);
                Console.WriteLine(fullRocket);
                fullRocket = "\n" + fullRocket;
                Thread.Sleep(1000);
                //if (i == 0) 
                //{
                //    Console.WriteLine(fullRocket);
                //    Console.WriteLine(emptyString);
                //    Console.WriteLine(emptyString);
                //    Console.WriteLine(emptyString);
                //    Console.WriteLine(emptyString);
                //    Console.WriteLine(emptyString);
                //    Console.WriteLine(ground);
                //    Thread.Sleep(1000);
                //    Console.Clear();
                //}
                //else if (i == 1)
                //{
                //    Console.WriteLine(emptyString);
                //    Console.WriteLine(fullRocket);
                //    Console.WriteLine(emptyString);
                //    Console.WriteLine(emptyString);
                //    Console.WriteLine(emptyString);
                //    Console.WriteLine(emptyString);
                //    Console.WriteLine(ground);
                //    Thread.Sleep(1000);
                //    Console.Clear();
                //}
                //else if (i == 2)
                //{
                //    Console.WriteLine(emptyString);
                //    Console.WriteLine(emptyString);
                //    Console.WriteLine(fullRocket);
                //    Console.WriteLine(emptyString);
                //    Console.WriteLine(emptyString);
                //    Console.WriteLine(emptyString);
                //    Console.WriteLine(ground);
                //    Thread.Sleep(1000);
                //    Console.Clear();
                //}
                //else if (i == 3)
                //{
                //    Console.WriteLine(emptyString);
                //    Console.WriteLine(emptyString);
                //    Console.WriteLine(emptyString);
                //    Console.WriteLine(fullRocket);
                //    Console.WriteLine(emptyString);
                //    Console.WriteLine(emptyString);
                //    Console.WriteLine(ground);
                //    Thread.Sleep(1000);
                //    Console.Clear();
                //}
                //else if (i == 4)
                //{
                //    Console.WriteLine(emptyString);
                //    Console.WriteLine(emptyString);
                //    Console.WriteLine(emptyString);
                //    Console.WriteLine(emptyString);
                //    Console.WriteLine(fullRocket);
                //    Console.WriteLine(emptyString);
                //    Console.WriteLine(ground);
                //    Thread.Sleep(1000);
                //    Console.Clear();
                //}
                //else
                //{
                //    Console.WriteLine(emptyString);
                //    Console.WriteLine(emptyString);
                //    Console.WriteLine(emptyString);
                //    Console.WriteLine(emptyString);
                //    Console.WriteLine(emptyString);
                //    Console.WriteLine(fullRocket);
                //    Console.WriteLine(ground);
                //    Console.WriteLine("Congratulation! Your rocket has landed!");
                //    Console.ReadKey();
                //}
            }
            Console.WriteLine("Congratulation! Your rocket has landed!");
        }
    }
}
