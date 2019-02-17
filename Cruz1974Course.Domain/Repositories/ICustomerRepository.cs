using Cruz1974Course.Domain.Entities;

namespace Cruz1974Course.Domain.Repositories
{
    public interface ICustomerRepository
    {

        bool CheckDocument(string document);
        bool CheckEmail(string email);
        void Save(Customer customer);

    }
}
