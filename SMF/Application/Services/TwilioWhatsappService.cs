using System.Threading.Tasks;
using MimeKit;
using MailKit.Net.Smtp;
using System;

using Microsoft.Extensions.Options;
using Twilio.Types;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Application.Providers;

namespace Application.Services
{
    public class TwilioWhatsappService : IWhatsappService
    {
      

        public void SendWhatsappAsync(string from, string to, string body, string mediaURL)

        {
            var accountSid = "ACd465d4c8583052e27e3983ee11acea29";
            //var authToken = "[AuthToken]";
            var authToken = "bff592741b07121ab01b5cd309ad8f7f";
            TwilioClient.Init(accountSid, authToken);

            var messageOptions = new CreateMessageOptions(new PhoneNumber("whatsapp:+554599565299"));
            messageOptions.From = new PhoneNumber("whatsapp:+14155238886");
            //messageOptions.To = new PhoneNumber()

            var mediaU = new[] { new Uri(mediaURL)}.ToList();

            messageOptions.MediaUrl = mediaU;
            //messageOptions.Body = "Teste Enviado do ASP NET CORE DO SANDRO";
            messageOptions.Body = body;
            var message = MessageResource.Create(messageOptions);
            Console.WriteLine(message.Body);
        }
    }
}