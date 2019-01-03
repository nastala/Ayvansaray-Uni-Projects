using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace DelegateTutorial.Classes
{
    internal class GameTimer
    {
        private readonly Stopwatch _timer = new Stopwatch();

        public void StartTimer()
        {
            _timer.Start();
        }

        public string StopTimer()
        {
            return _timer.Elapsed.ToString();
        }
    }
}
