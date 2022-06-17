using System;

namespace TimeManager
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("WelCome to Time Manager \n");

            var startTimeSpan = TimeSpan.Zero;
            var periodTimeSpan = TimeSpan.FromSeconds(5);

            WriteLog writeLog = new WriteLog();

            var timer = new System.Threading.Timer((e) =>
            {
                writeLog.DoSomething();  //Call any function
            }, null, startTimeSpan, periodTimeSpan);


            Console.ReadLine();
        }
    }
}
