namespace Application.Providers
{
    public interface IWhatsappService
    {
        void SendWhatsappAsync(string from ,string to, string body, string mediaURL);
    }
}
