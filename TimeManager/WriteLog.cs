using System;
using System.Collections.Generic;
using System.Text;

namespace TimeManager
{
    public class WriteLog
    {
        private readonly TimeManager _timer;
        public WriteLog()
        {
            //_timer = new TimeManager();

            //if (!_timer.IsTimerStarted)
            //{
            //    _timer.PrepareTimer(() => DoSomething());
            //}

        }


        public Action DoSomething()
        {
            Console.WriteLine("Hello !!");
            return null;
        }
    }
}
