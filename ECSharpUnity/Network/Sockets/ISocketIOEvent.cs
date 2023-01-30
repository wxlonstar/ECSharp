﻿using System.Net.Sockets;

namespace ECSharp.Network.Sockets
{
    /// <summary>
    /// 套接字IO事件接口
    /// </summary>
    internal interface ISocketIOEvent
    {
        void IO_Completed(SocketAsyncEventArgs e);
    }
}
