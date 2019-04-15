using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WebSocketWinForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form = new MainForm();


            Thread t = new Thread(() => RunServer(form));
            t.Start();
            


            Application.Run(form);            
                      
        }

        static void RunServer(MainForm form)
        {
            var server = new WSServer(form);
            server.Start("0.0.0.0", "8080");
        }


    }
}
