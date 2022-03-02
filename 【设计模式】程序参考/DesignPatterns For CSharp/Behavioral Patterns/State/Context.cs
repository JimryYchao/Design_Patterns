using System.Net;
using System.Net.Sockets;

namespace DesignPatterns_For_CSharp.Behavioral_Patterns.State
{
    public class TCPConnection
    {
        private TCPState _tcpState;
        public Socket? Connector;
        public IPAddress IPAddress = IPAddress.Parse("127.0.0.1");
        public int Port = 7777;
        public bool IsConnected
        {
            get
            {
                if (Connector != null)
                    return Connector.Connected;
                return false;
            }
        }
        public TCPConnection()
        {
            _tcpState = TCPUnconnected.Instance;
        }
        public void Connect()
        {
            _tcpState.Connect(this);
        }
        public void Receive(out byte[] buffer)
        {
            _tcpState.Receive(this, out buffer);
        }
        public void Close()
        {
            _tcpState.Close(this);
        }
        public void SendMessage(byte[] buffer)
        {
            _tcpState.SendMessage(this, buffer);
        }
        internal void ChangeState(TCPState state)
        {
            _tcpState = state;
        }
    }
}
