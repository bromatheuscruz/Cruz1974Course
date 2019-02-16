using Cruz1974Course.Domain.ValueObjects;
using System.Collections.Generic;

namespace Cruz1974Course.Domain.Entities
{
    public class Customer
    {
        public Customer(Name name, Document document, string email, string phone)
        {
            Name = name;
            Document = document;
            Email = email;
            Phone = phone;
            Addresses = new List<Address>();
        }

        public Name Name { get; private set; }
        
        public Document Document { get; private set; }

        public string Email { get; private set; }

        public string Phone { get; private set; }

        public IReadOnlyCollection<Address> Addresses { get; private set; }

        public override string ToString()
        {
            return Name.ToString();
        }

    }

}
