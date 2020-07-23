using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace DevExpressKiller
{
    /// <summary>
    ///     주기적으로 특정 팝업창을 검사하여 닫는 역할을 구현한 클래스
    /// </summary>
    public class ProcessKiller
    {
        #region singleton
        private static ProcessKiller _instance;

        public static ProcessKiller Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProcessKiller();
                return _instance;
            }
        }

        private ProcessKiller()
        {
        }
        #endregion

        #region Platform invoking
        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        #endregion

        private string _caption;

        private Timer _timer;

        private bool _oneTime;

        public int ShutDownCount { get; private set; }

        /// <summary>
        ///     팝업창 닫기를 시작한다.
        /// </summary>
        public void Start(string caption = "About DevExpress", double interval = 1000, bool oneTime = false)
        {
            _caption = caption;
            _oneTime = oneTime;

            _timer = new Timer(interval);
            _timer.Elapsed += Timer_Elapsed;

            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            _timer.Stop();

            IntPtr ptr = FindWindow(null, _caption);
            if (ptr != IntPtr.Zero)
            {
                SendMessage(ptr, 0x10, IntPtr.Zero, IntPtr.Zero);
                OnShutDown(ShutDownCount++);
            }

            if (_oneTime == false)
                _timer.Start();
            else
                _timer = null;
        }

        #region ShutDown event things for C# 3.0
        public event EventHandler<ShutDownEventArgs> ShutDown;

        protected virtual void OnShutDown(ShutDownEventArgs e)
        {
            if (ShutDown != null)
                ShutDown(this, e);
        }

        private ShutDownEventArgs OnShutDown(int count)
        {
            ShutDownEventArgs args = new ShutDownEventArgs(count);
            OnShutDown(args);

            return args;
        }

        private ShutDownEventArgs OnShutDownForOut()
        {
            ShutDownEventArgs args = new ShutDownEventArgs();
            OnShutDown(args);

            return args;
        }

        public class ShutDownEventArgs : EventArgs
        {
            public int Count { get; set; }

            public ShutDownEventArgs()
            {
            }

            public ShutDownEventArgs(int count)
            {
                Count = count;
            }
        }
        #endregion
    }
}
