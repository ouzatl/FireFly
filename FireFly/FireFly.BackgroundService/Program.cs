using System.ServiceProcess;

namespace FireFly.BackgroundService
{
    static class Program
    {
        static void Main()
        {
#if DEBUG

            WriteCurrentTimeService service = new WriteCurrentTimeService();
            service.OnDebug();
#else
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new WriteCurrentTimeService()
            };
            ServiceBase.Run(ServicesToRun);
#endif
        }
    }
}
