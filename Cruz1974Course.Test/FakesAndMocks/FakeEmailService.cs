using Cruz1974Course.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cruz1974Course.Test.FakesAndMocks
{
    class FakeEmailService : IEmailService
    {
        public void Send(string to, string from, string subject, string body)
        {
            Console.WriteLine("Email enviado com sucesso");
        }
    }
}
