using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    public class StopWatch
    {
        private Boolean _running { get; set; }
        private DateTime _startTime { get; set; }
        private DateTime _stopTime { get; set; }
        private TimeSpan _duration;



        public TimeSpan Duration
        {
            get { _duration = _stopTime - _startTime;
                  return _duration;
                }
            
        }

        public void Start()
        {
            if (_running == true)
            {
               throw new InvalidOperationException();
            }
            else
            {
                _running = true;
                _stopTime = DateTime.Now;
                _startTime = DateTime.Now;
            }


        }
        public void Stop()
        {
            if(_running == true) { _stopTime = DateTime.Now; }
                
            _running = false;           
        }


    }
}
