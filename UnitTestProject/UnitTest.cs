using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Contracts;
using Main;

namespace UnitTestProject1
{
    public class LoggerMock : ILogger
    {
        private int _callCounter = 0;
        public void LogException(Exception e)
        {
            _callCounter++;
        }

        public int CallCounter
        {
            get { return _callCounter; }
        }
    }

    public class ClientMock : IClient
    {
        public bool Connect()
        {
            return true;
        }

        public void Disconnect()
        {
        }

        public void Send(object data)
        {
            throw new ConnectionException("Test exception");
        }
    }


    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {

        }
    }
}
