using System;
using System.Threading;

namespace Streams
{
    class Program
    {
        public delegate void ThreadStart();
        static void Main()
        {
            Thread Tread1 = new Thread(Robot2Move); //создание второго потока
            Tread1.Start();
            Robot1Move();
        }
        static void Robot1Move() //выполняется в главном потоке
        {
            Robot robot1 = new Robot(0, 0, "Робот 1", "Вперед");
            for (int i = 0; i < 10; i++)
            {
                robot1.Move();
                Thread.Sleep(100);
            }
        }
        static void Robot2Move() //выполняется во втором потоке
        {
            Robot robot2 = new Robot(0, 0, "Робот 2", "Вперед");
            for (int i = 0; i < 10; i++)
            {
                robot2.Move();
                Thread.Sleep(200);
            }
        }
    }
}
