using EliLogProxyLog4net;
using NUnit.Framework;
using System.Threading;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Assert.Pass();
            //while (true)
            {
                Thread.Sleep(10);
                LogProxy.Write(ELogLevel.DEBUG, "zxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxzxxxxxxxxv");
            }
           
        }
    }
}