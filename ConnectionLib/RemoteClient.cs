using Contracts;
using System;
using System.Threading;

namespace ConnectionLib
{
    public class RemoteClient : IClient
    {
        Random random = new Random();
        public bool Connect()
        {
            return true;
        }

        public void Send(object data)
        {
            Console.WriteLine("Отправка " + data);
            Thread.Sleep(50);
            if (random.Next(0, 2) == 1)
            {
                Console.WriteLine("Ошибка при отправке " + data);
                throw new ConnectionException("Не удалось отправить: " + data);
            }
        }

        public void Disconnect()
        {
        }
    }
}
