using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_02_20_Homework_BlogLesson_41_Thread
{
    public partial class MainForm : Form
    {
        private static int[] _numbersArr = new int[10000];
        private Stopwatch _stopwatch = new Stopwatch();

        private int _result;
        private int _number1;
        private int _number2;
        private Targil1 _currentTargil1 = new Targil1();
        public MainForm()
        {
            InitializeComponent();
            Initialize();
        }
        private void Initialize()
        {
            pnlExercise1.drawBorder(2, Color.Black);
            pnlExercise2.drawBorder(2, Color.Black);

            lblTargil2outputThreads.Text = "";
            lblTargil2outputThreads.TextAlign = ContentAlignment.MiddleCenter;
            lblTargil2outputThreads.drawBorder(1, Color.Black);
            lblTargil2outputNoThreads.Text = "";
            lblTargil2outputNoThreads.TextAlign = ContentAlignment.MiddleCenter;
            lblTargil2outputNoThreads.drawBorder(1, Color.Black);



            txtGuessedRezult.Click += (object sender, EventArgs e) => { (sender as TextBox).Text = string.Empty; };
            lblTargil1.Text = string.Empty;
        }
        private void ForEvent(object sender, PrintEventArgs e)
        {
            if (btnTargil1.InvokeRequired)
            {
                btnTargil1.Invoke((Action)delegate
                {
                    btnTargil1.Text = e.Seconds.ToString();
                    int guessedRez = -1;
                    bool guess = Int32.TryParse(txtGuessedRezult.Text, out guessedRez);
                    if (e.Seconds == 0 && (!guess || guessedRez == -1 || guessedRez != _result)) { lblTargil1.Text = "Time expired, you're loser!"; _currentTargil1.printOut -= ForEvent; }
                    if (e.Seconds != 0 && guessedRez == _result)
                    {
                        lblTargil1.Text = $"{_number1} * {_number2} = {_result}, You won!";
                        _currentTargil1.printOut -= ForEvent;
                    }
                });
            }
            else
            {
                btnTargil1.Text = e.Seconds.ToString();
                int guessedRez = -1;
                bool guess = Int32.TryParse(txtGuessedRezult.Text, out guessedRez);
                if (e.Seconds == 0 && (!guess || guessedRez == -1)) { lblTargil1.Text = "Time expired, you're loser!"; _currentTargil1.printOut -= ForEvent; }
                if (e.Seconds != 0 && guessedRez == _result)
                {
                    lblTargil1.Text = $"{_number1} * {_number2} = {_result}, You won!";
                    _currentTargil1.printOut -= ForEvent;
                }
            }

        }

        private void btnTargil1_Click(object sender, EventArgs e)
        {
            
                _currentTargil1.printOut += ForEvent;
                (sender as Button).Text = "Start";
            if (Int32.TryParse(txtGuessedRezult.Text, out int r)) txtGuessedRezult.Text = "type your rez here";
            
            _currentTargil1.PleaseTry(out int n1, out int n2, out int rez);
            lblTargil1.Text = $"{n1} * {n2} = ???";
            _number1 = n1;
            _number2 = n2;
            _result = rez;
        }


        private void Set1000ItemsInArray(object index)
        {
            for(int i = (int)index; i < (int)index + 100; i++) _numbersArr[i] = 1;            
        }

        private void btnExercise2_Click(object sender, EventArgs e)
        {
            Thread[] targil2threadsArr = create100threads();
            _stopwatch.Reset();
            _stopwatch.Start();            
            for(int i = 0; i < targil2threadsArr.Length; i++)
            {
                targil2threadsArr[i].Start(i*100);
                targil2threadsArr[i].Join();
            }
            if (IsAllThreadsStopped(targil2threadsArr))
            {
                _stopwatch.Stop();
                TimeSpan elapseedTime = _stopwatch.Elapsed;
                lblTargil2outputThreads.Text = $"{elapseedTime.TotalMilliseconds} ms";
            }
            else lblTargil2outputThreads.Text = "Not all the threads stopped yet!";
        }
        private void btnExercise2NoThreads_Click(object sender, EventArgs e)
        {
            Action<object>[] targil2actionsArr = create100actions();
            _stopwatch.Reset();
            _stopwatch.Start();
            for (int i = 0; i < targil2actionsArr.Length; i++)
            {
                targil2actionsArr[i](i * 100);
            }
            _stopwatch.Stop();

            TimeSpan elapseedTime = _stopwatch.Elapsed;

            lblTargil2outputNoThreads.Text = $"{elapseedTime.TotalMilliseconds} ms";
        }
        private Thread[] create100threads()
        {
            Thread[] targil2threads = new Thread[100];
            for (int i = 0; i < targil2threads.Length; i++)
            {
                Thread thread = new Thread(new ParameterizedThreadStart(Set1000ItemsInArray));
                thread.Name = "thread_" + i;
                targil2threads[i] = thread;
            }
            return targil2threads;
        }
        private Action<object>[] create100actions()
        {
            Action<object>[] targil2actions = new Action<object>[100];
            for (int i = 0; i < targil2actions.Length; i++)
            {
                Action<object> action = new Action<object>(Set1000ItemsInArray);
                targil2actions[i] = action;
            }
            return targil2actions;
        }
        private bool IsAllThreadsStopped(IList<Thread> threadsCollection)
        {
            bool isThemAllStopped = true;
            foreach(Thread s in threadsCollection)
            {
                if(s.ThreadState != System.Threading.ThreadState.Stopped)
                    isThemAllStopped = false;
            }
            return isThemAllStopped;
        }


    }
}
