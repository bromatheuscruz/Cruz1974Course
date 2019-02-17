using Cruz1974Course.Domain.Entities;
using Cruz1974Course.Domain.Repositories;

namespace Cruz1974Course.Test.FakesAndMocks
{
    class FakeCustomerRepository : ICustomerRepository
    {
        public bool CheckDocument(string document)
        {
            return false;
        }

        public bool CheckEmail(string email)
        {
            return false;
        }

        public void Save(Customer customer)
        {
            
        }
    }
}
