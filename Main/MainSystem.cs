using Contracts;

namespace Main
{
    public class MainSystem
    {
        IClient _client;
        public MainSystem(IClient client)
        {
            _client = client;
        }

        public void Run()
        {
            for (int i = 0; i < 100; i++)
            {
                _client.Connect();
                _client.Send(i);
                _client.Disconnect();
            }
        }
    }
}
