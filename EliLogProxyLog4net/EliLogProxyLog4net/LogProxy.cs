using log4net;
using System;
using System.Configuration;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace EliLogProxyLog4net
{
    public class LogProxy
    {
        private static ILog _Log = LogManager.GetLogger("Performance");
        private static Action<string> _action;
        private static UdpClient _udpClient = new UdpClient();
        private static string remUdpIp;
        private static int remUdpPort;
        public static void Info(string logStr)
        {
            ProcessLog(logStr);
            if (_action != null)
            {
                _action(logStr);
            }
        }

        public static void RegLog(Action<string> action)
        {
            _action = action;
        }

        private static void ProcessLog(string logStr)
        {
            _Log.Info(logStr);//记录日志
            if (string.IsNullOrWhiteSpace(remUdpIp))
            {
                remUdpIp = ConfigurationManager.AppSettings["remUdpIp"] == null ? "127.0.0.1" :
                    ConfigurationManager.AppSettings["remUdpIp"].ToString();
                remUdpPort = ConfigurationManager.AppSettings["remUdpPort"] == null ? 4000 :
                   int.Parse(ConfigurationManager.AppSettings["remUdpPort"].ToString());
            }
            IPAddress HostIP = IPAddress.Parse(remUdpIp);
            IPEndPoint host = new IPEndPoint(HostIP, remUdpPort);
            var bs = Encoding.UTF8.GetBytes(logStr);
            _udpClient.Send(bs, bs.Length, host);//发送日志
        }
    }
}
