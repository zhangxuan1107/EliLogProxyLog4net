using log4net;
using log4net.Config;
using log4net.Repository;
using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace EliLogProxyLog4net
{
    public class LogProxy
    {
        static ILoggerRepository repository = LogManager.CreateRepository("NETCoreRepository");

        private static ILog _Log = null;
        //private static ILog _Log = LogManager.GetLogger("logerror");
        private static Action<string> _action;
        private static UdpClient _udpClient = new UdpClient();
        /// <summary>
        /// 是否已经初始化
        /// </summary>
        private static bool isInited = false;
        /// <summary>
        /// 调用前必须先初始化
        /// </summary>
        private static void Init()
        {
            XmlConfigurator.Configure(repository, new FileInfo("config.xml"));
            _Log = LogManager.GetLogger(repository.Name, "NETCorelog4net");
        }
        /// <summary>
        /// 远程IP
        /// 用于接受日志
        /// </summary>
        private static string remUdpIp;

        /// <summary>
        /// 远程端口
        /// </summary>
        private static int remUdpPort;
        public static void Write(ELogLevel level, string logStr)
        {
            if (!isInited)
            {
                Init();
            }
            ProcessLog(level, logStr);
            if (_action != null)
            {
                _action(logStr);
            }
        }

        public static void RegLog(Action<string> action)
        {
            _action = action;
        }

        private static void ProcessLog(ELogLevel level, string logStr)
        {
            switch (level)
            {
                case ELogLevel.DEBUG:
                    _Log.Debug(logStr);
                    break;
                case ELogLevel.INFO:
                    _Log.Info(logStr);
                    break;
                case ELogLevel.WARN:
                    _Log.Warn(logStr);
                    break;
                case ELogLevel.ERROR:
                    _Log.Error(logStr);
                    break;
                default:
                    break;
            }
            SendMsg(logStr);
        }


        private static void SendMsg(string logStr)
        {
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
