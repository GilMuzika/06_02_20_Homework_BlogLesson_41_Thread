using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _06_02_20_Homework_BlogLesson_41_Thread
{
    class Targil1
    {
        public event EventHandler<PrintEventArgs> printOut;

        const int SECONDS_NUM = 5;
        private Random _rnd = new Random();

        private int _n1;
        private int _n2;
        private int _rez;

        public Targil1()
        {
            
        }
        private void SetValues()
        {
            _n1 = _rnd.Next(1, 9);
            _n2 = _rnd.Next(1, 9);
            _rez = _n1 * _n2;
        }

        public void PleaseTry(out int N1, out int N2, out int REZ)
        {
            SetValues();

            CountDown();

            N1 = _n1;
            N2 = _n2;
            REZ = _rez;
        }

        public void CountDown()
        {
            Thread thread = new Thread(() => 
                {
                    for(int i = SECONDS_NUM; i >= 0; i--)
                    {
                        Thread.Sleep(1000);
                        printOut?.Invoke(this, new PrintEventArgs { Seconds = i });
                    }
                });         
            thread.Start();
        }


    }
}
