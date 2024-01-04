using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace DesignPatterns_For_CSharp.Behavioral_Patterns.State
{
    // TCP 已建立
    internal class TCPEstablished : TCPState
    {
        public readonly static TCPEstablished Instance = new TCPEstablished();
        public override void SendMessage(TCPConnection connection, byte[] buffer)
        {
            if (connection.IsConnected)
                connection.Connector.Send(buffer);
            else
                ChangeState(connection, TCPUnconnected.Instance);
            ChangeState(connection, TCPListen.Instance);
        }
        public override void Close(TCPConnection connection)
        {
            connection.Connector?.Close();
            ChangeState(connection, TCPUnconnected.Instance);
        }
    }
    // TCP 监听
    internal class TCPListen : TCPState
    {
        public readonly static TCPListen Instance = new TCPListen();
        public override void Receive(TCPConnection connection, out byte[]? buffer)
        {
            byte[] arr = new byte[1024];
            int len = 0;
            try
            {
                while ((len = connection.Connector.Receive(arr)) <= 0)
                    continue;
            }
            catch
            {
                if (!connection.IsConnected)
                    ChangeState(connection, TCPUnconnected.Instance);
            }
            buffer = new byte[len];
            Array.Copy(arr, 0, buffer, 0, len);
            ChangeState(connection, TCPEstablished.Instance);
        }

    }
    // TCP 已关闭
    internal class TCPUnconnected : TCPState
    {
        public readonly static TCPUnconnected Instance = new TCPUnconnected();
        public override void Connect(TCPConnection connection)
        {
            while (true)
            {
                try
                {
                    connection.Connector = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    connection.Connector?.Connect(new IPEndPoint(connection.IPAddress, connection.Port));
                }
                catch
                {
                    Console.WriteLine($"Cannot connecet to >>> {connection.IPAddress}:{connection.Port}");
                    Thread.Sleep(1000);
                    continue;
                }
                Console.WriteLine("Connect to >>> " + connection.Connector?.RemoteEndPoint);
                break;
            }
            ChangeState(connection, TCPEstablished.Instance);
        }
    }
}

