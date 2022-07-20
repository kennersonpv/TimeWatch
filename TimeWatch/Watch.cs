using System;
using System.Collections.Generic;
using System.Text;

namespace TimeWatch
{
    public static class Watch
    {
        private static DateTime _startTime;
        private static DateTime _stopTime;
        private static bool isRunnig = false;

        public static void StartWatch()
        {
            if (isRunnig)
            {
                throw new InvalidOperationException();
            }

            _startTime = DateTime.Now;
            isRunnig = true;
        }

        public static TimeSpan StopWatch()
        {
            if (!isRunnig)
            {
                throw new InvalidOperationException();
            }

            _stopTime = DateTime.Now;
            return _stopTime - _startTime;
        }

    }
}
