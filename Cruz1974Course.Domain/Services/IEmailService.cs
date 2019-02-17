
namespace Cruz1974Course.Domain.Services
{
    public interface IEmailService
    {

        void Send(string to, string from, string subject, string body);

    }
}
