using ConnectionLib;
using Contracts;
using LoggerLib;
using System;
using System.Diagnostics;

namespace Main
{
    // Существующая система состоит из клиента удалённого сервиса RemoteClient и класса MainSystem.
    // Задача 1:
    // Обнаружилось, что при обращении к методам RemoteClient может возникать исключение ConnectionException.
    // Нужно изменить код, чтобы исключения из RemoteClient перехватывались, но при этом нельзя менять класс MainSystem.
    // Для логирования ошибок уже есть класс LoggerLib.Logger.

    // Задача 2:
    // Нужно ускорить выполнение метода MainSystem.Run() за счёт распаралелливания обращений к RemoteClient. 
    // Для этой задачи нам разрешили внести изменения в класс MainSystem.
    class Program
    {
        static void Main(string[] args)
        {
            IClient client = new RemoteClient();
            var mainSystem = new MainSystem(client);

            var stopwatch = new Stopwatch(); // Какая польза от Stopwatch?
            stopwatch.Start();
            mainSystem.Run();
            stopwatch.Stop();

            Console.Write($"ElapsedMilliseconds: {stopwatch.ElapsedMilliseconds}");
            Console.ReadLine();
        }
    }
}
