using Application.Providers;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Options;
using MimeKit;

namespace Application.Services
{
    public class SendinBlueService : IEmailService
    {
        private readonly SendinBlueSettings _emailSettings;

        public SendinBlueService(IOptions<SendinBlueSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }

        public async Task SendEmailAsync(string emailDestinatario, string assunto, string mensagemTexto, string mensagemHtml, string? filesattachments)
        {
            var mensagem = new MimeMessage();
            mensagem.From.Add(new MailboxAddress(_emailSettings.NomeRemetente, _emailSettings.EmailRemetente));
            //mensagem.From.Add(new MailboxAddress("Sandro R Castro","sandrorcastro@gmail.com"));
            mensagem.To.Add(MailboxAddress.Parse(emailDestinatario));
            //mensagem.To.Add(MailboxAddress.Parse("sandrorcastro@hotmail.com"));
            mensagem.Subject = assunto;
            
            //var attachments = new AttachmentCollection();
            //attachments.Add(IEnumerable<filesattachments>);
           
            var builder = new BodyBuilder { TextBody = mensagemTexto, HtmlBody = mensagemHtml };
            //var builder = new BodyBuilder { TextBody = "Mensagem de Texto", HtmlBody = "Mensagem em HTML"};
            //mensagem.Attachments=Mime 
            mensagem.Body = builder.ToMessageBody();
            try
            {
                var smtpClient = new SmtpClient();
                smtpClient.ServerCertificateValidationCallback = (s, c, h, e) => true;
                await smtpClient.ConnectAsync(_emailSettings.EnderecoServidor, _emailSettings.PortaServidor).ConfigureAwait(false);
                await smtpClient.AuthenticateAsync(_emailSettings.EmailRemetente, _emailSettings.Senha).ConfigureAwait(false);
                await smtpClient.SendAsync(mensagem).ConfigureAwait(false);
                await smtpClient.DisconnectAsync(true).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }
    }
}