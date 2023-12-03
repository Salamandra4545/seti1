using System.Diagnostics;
using System;

Thread.CurrentThread.Name = "main";
ToTriangle();
Thread mythread = new Thread(ToTriangle);
mythread.Name = "back";
mythread.Start();

static void ToTriangle()
{
    int[] myMatrix = new int[16] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

    int count = 0;

    Console.WriteLine();
    Console.WriteLine(Thread.CurrentThread.Name + " начал работу...");
    Stopwatch stpWatch = new Stopwatch();
    stpWatch.Start();

    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            if (i > j)
            {

                Console.Write($"0 ");
            }
            else if (count < 16)
            {
                int symbol = myMatrix[count];
                Console.Write($"{symbol} ");
                count++;
            }
        }
        Console.WriteLine();
    }

    stpWatch.Stop();
    Console.WriteLine("StopWatch: " + stpWatch.ElapsedTicks.ToString());
    Console.WriteLine(Thread.CurrentThread.Name + " закончил работу...");
}

