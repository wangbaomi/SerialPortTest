using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace 串口调试助手
{
    class Server
    {
        static void StartServer(string[] args)
        {
            const int BufferSize = 8192;    // 缓存大小，8192字节

            Console.WriteLine("Server is running ... ");
            IPAddress ip = new IPAddress(new byte[] { 127, 0, 0, 1 });
            TcpListener listener = new TcpListener(ip, 8500);

            listener.Start();           // 开始侦听
            Console.WriteLine("Start Listening ...");

            // 获取一个连接，中断方法
            TcpClient remoteClient = listener.AcceptTcpClient();
            // 打印连接到的客户端信息
            Console.WriteLine("Client Connected！{0} <-- {1}",
                remoteClient.Client.LocalEndPoint, remoteClient.Client.RemoteEndPoint);

            // 获得流，并写入buffer中
            NetworkStream streamToClient = remoteClient.GetStream();
            byte[] buffer = new byte[BufferSize];
            int bytesRead = streamToClient.Read(buffer, 0, BufferSize);
            Console.WriteLine("Reading data, {0} bytes ...", bytesRead);

            // 获得请求的字符串
            string msg = Encoding.Unicode.GetString(buffer, 0, bytesRead);
            Console.WriteLine("Received: {0}", msg);

            
            
        }
    }
}
