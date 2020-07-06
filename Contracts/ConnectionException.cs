using System;

namespace Contracts
{
    public class ConnectionException: Exception
    {
        public ConnectionException(string message): base(message)
        {
        }
    }
}
