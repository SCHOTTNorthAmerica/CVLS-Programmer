using System;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using log4net.Config;

[assembly: XmlConfigurator(Watch = false)]
namespace SCHOTT.CVLS.Programmer
{
    internal static class Program
    {
        public static ILog Log = LogManager.GetLogger("SCHOTT.CVLS.Apps.Dashboard");

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            XmlConfigurator.Configure();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadException += Application_ThreadException;
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            AppDomain.CurrentDomain.FirstChanceException += CurrentDomain_FirstChanceException;
            TaskScheduler.UnobservedTaskException += TaskScheduler_UnobservedTaskException;

            Application.Run(new MainForm());
        }

        private static void CurrentDomain_FirstChanceException(object sender, FirstChanceExceptionEventArgs e)
        {
            Log.Info(e.Exception.Message, e.Exception);
        }

        private static void TaskScheduler_UnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs e)
        {
            Log.Error(e.Exception);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Log.Error(e.ExceptionObject);
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            Log.Error(e.Exception);
        }
    }
}
