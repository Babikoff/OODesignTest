namespace Contracts
{
    public interface IClient
    {
        bool Connect();
        void Send(object data);
        void Disconnect();
    }
}
