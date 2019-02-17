using Cruz1974Course.Domain.Enums;
using FluentValidator;
using FluentValidator.Validation;

namespace Cruz1974Course.Domain.ValueObjects
{
    public class Address : Notifiable
    {
        public Address(
            string street,
            string number,
            string complement,
            string district,
            string city,
            string state,
            string country,
            string zipcode,
            EAddressType type

            )
        {
            Street = street;
            Number = number;
            Complement = complement;
            District = district;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipcode;
            Type = type;

            ApplyValidations();
        }

        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Complement { get; private set; }
        public string District { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
        public string ZipCode { get; private set; }
        public EAddressType Type { get; private set; }

        public override string ToString()
        {
            return $"{Street}, {Number} - {City}/{State} - {ZipCode}";
        }

        private void ApplyValidations()
        {
            AddNotifications(new ValidationContract()
                .Requires()
                .IsNotNullOrEmpty(Street, "Street", "A rua informada é inválida")
                .IsNotNullOrEmpty(Number, "Number", "O número informado é inválido")
                .IsNotNullOrEmpty(District, "District", "O bairro informado é inválido")
                .IsNotNullOrEmpty(City, "City", "A rua informada é inválida")
                .IsNotNullOrEmpty(State, "State", "O estado informado é inválido")
                .IsNotNullOrEmpty(Country, "Country", "O país informado é inválido")
                .IsNotNullOrEmpty(ZipCode, "ZipCode", "O CEP informado é inválido")
                .IsNotNull(Type, "Type", "O tipo de endereço não foi informado inválido")
                );
        }
    }
}
