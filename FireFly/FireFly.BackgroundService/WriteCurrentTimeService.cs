using System;
using System.ComponentModel;
using System.Configuration;
using System.ServiceProcess;
using System.Threading;

namespace FireFly.BackgroundService
{
    [RunInstaller(true)]
    public partial class WriteCurrentTimeService : ServiceBase
    {

        int ScheduleTime = Convert.ToInt32(ConfigurationSettings.AppSettings["ThreadTime"]);
        public Thread Worker = null;
        public WriteCurrentTimeService()
        {
            InitializeComponent();
        }

        public void OnDebug()
        {
            OnStart(null);
        }

        protected override void OnStart(string[] args)
        {
            ThreadStart start = new ThreadStart(Working);
            Worker = new Thread(start);
            Worker.Start();
        }

        public void Working()
        {
            Console.WriteLine($"Curren Time is : {DateTime.Now}");
            Thread.Sleep(60000 * ScheduleTime);
        }

        protected override void OnStop()
        {
            if ((Worker != null) & Worker.IsAlive)
            {
                Worker.Abort();
            }
        }
    }
}