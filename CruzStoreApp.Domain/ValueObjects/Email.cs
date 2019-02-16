using FluentValidator;
using FluentValidator.Validation;

namespace Cruz1974Course.Domain.ValueObjects
{
    public class Email : Notifiable
    {
        public Email(string address)
        {
            Address = address;

            AddNotifications(new ValidationContract().
                Requires()
                .IsEmail(address, "Address", "O endereço de e-mail não é um e-mail válido")
            );
        }

        public string Address { get; private set; }

        public override string ToString()
        {
            return Address.ToString();
        }
    }
}
