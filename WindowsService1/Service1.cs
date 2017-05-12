using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService1
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Commands that can be sent to a service include starting, pausing, resuming, and stopping the service; 
        /// you can also execute custom commands.
        /// </summary>
        /// <param name="args"></param>
        protected override void OnStart(string[] args)
        {
            //windows service run in windows.system32 directory , so Environment.CurrentDirectory won't be good choice
            System.IO.File.Create(AppDomain.CurrentDomain.BaseDirectory+"onStart.txt");
        }

        public void OnDebug()
        {
            OnStart(null);
        }

        protected override void OnStop()
        {
            System.IO.File.Create(AppDomain.CurrentDomain.BaseDirectory + "onStop.txt");
        }

        /// <summary>
        /// OnCustomCommand(): If you need to send a command to your
        ///   service without the need for Remoting or Sockets, use
        ///   this method to do custom methods.
        /// </summary>
        /// <param name="command">Arbitrary Integer between 128 & 256</param>
        protected override void OnCustomCommand(int command)
        {
            //  A custom command can be sent to a service by using this method:
            //#  int command = 128; //Some Arbitrary number between 128 & 256
            //#  ServiceController sc = new ServiceController("NameOfService");
            //#  sc.ExecuteCommand(command);

            base.OnCustomCommand(command);
        }

    }
}
