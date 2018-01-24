﻿using System.Net;
using System.Net.Sockets;

namespace NRpc.Transport.Socketing
{
    public interface IConnectionEventListener
    {
        void OnConnectionAccepted(ITcpConnection connection);

        /// <summary>
        /// 连接建立
        /// </summary>
        /// <param name="connection"></param>
        void OnConnectionEstablished(ITcpConnection connection);

        void OnConnectionFailed(EndPoint remotingEndPoint, SocketError socketError);

        void OnConnectionClosed(ITcpConnection connection, SocketError socketError);
    }
}