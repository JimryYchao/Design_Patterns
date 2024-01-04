using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace DesignPatterns_For_CSharp.Behavioral_Patterns.State
{
    public class StatePatternDemo
    {
        public static void Enter()
        {
            // Open server
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 7777));
            server.Listen(10);
            Console.WriteLine("Server is Builded");
            Socket ServerSocket = null;
            Thread acceptThread = new Thread(() => ServerSocket = server.Accept());
            acceptThread.Start();
            string receive;
            byte[] receiveBytes = new byte[1024];
            // Build Client
            TCPConnection Client = new TCPConnection();
            byte[] Buffer;
            string message = string.Empty;

            while (true)
            {
                // 1. 建立连接
                if (!Client.IsConnected)
                {
                    Client.Connect();
                    Console.WriteLine("Input Buffer");
                    while ((message = Console.ReadLine()) == null || message == string.Empty || message[0] == ' ')
                        continue;
                }
                // 2. 客户端发送消息
                Client.SendMessage(Encoding.UTF8.GetBytes(message));
                // 3. 服务器接收并返回状态
                if (ServerSocket != null)
                {
                    int len = ServerSocket.Receive(receiveBytes);
                    if (len > 0)
                    {
                        receive = Encoding.UTF8.GetString(receiveBytes);
                        ServerSocket.Send(Encoding.UTF8.GetBytes("Successful"));
                        Console.WriteLine("Server Receive successful <<< " + ServerSocket.RemoteEndPoint);
                        ServerSocket.Close();
                        ServerSocket = null;
                    }
                }
                // 4. 客户端接收状态
                Client.Receive(out Buffer);
                // 5. 客户端打印状态
                if (Buffer != null && Buffer.Length > 0)
                {
                    string reFormServer = Encoding.UTF8.GetString(Buffer);
                    Console.WriteLine("Client Receive successful <<< " + Client.Connector?.RemoteEndPoint);
                    Client.Close();
                    Console.WriteLine("Test Finished, and input anyKey to exit");
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}
