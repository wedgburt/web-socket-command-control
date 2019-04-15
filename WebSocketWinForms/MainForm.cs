using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebSocketWinForms
{
    public partial class MainForm : Form
    {
        private string Command;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void LogMessages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public void AddLogMessage(string message)
        {
            try
            {
                MethodInvoker methodInvokerDelegate = delegate ()
                { LogMessages.TopIndex = LogMessages.Items.Add(message); };

                //This will be true if Current thread is not UI thread.
                if (this.InvokeRequired)
                    this.Invoke(methodInvokerDelegate);
                else
                    methodInvokerDelegate();
            }
            catch (Exception)
            {
                // Do nothing
            }
        }

        public string GetCommand()
        {
            if (InvokeRequired)
            {
                return (string)Invoke(
                  new Func<string>(() => GetCommand())
                );
            }
            else
            {
                string varText = Command;
                Command = null;
                return varText;
            }
        }

        public void AddClient(string IP)
        {
            MethodInvoker methodInvokerDelegate = delegate ()
            { ConnectedBox.Items.Add(IP); };

            //This will be true if Current thread is not UI thread.
            if (this.InvokeRequired)
                this.Invoke(methodInvokerDelegate);
            else
                methodInvokerDelegate();
        }

        public void RemoveClient(string IP)
        {
            MethodInvoker methodInvokerDelegate = delegate ()
            {
                try
                {
                    ConnectedBox.Items.Remove(IP);
                }
                catch (Exception)
                {
                    // Do nothing
                }
            };

            //This will be true if Current thread is not UI thread.
            if (this.InvokeRequired)
                this.Invoke(methodInvokerDelegate);
            else
                methodInvokerDelegate();
        }




        private void PortScan_Click(object sender, EventArgs e)
        {
            Command = "portscan " + PortScanIPTextBox.Text;
        }

        private void PortScanBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
