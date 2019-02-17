using Cruz1974Course.Domain.Commands.CustomerCommands.Input;
using Cruz1974Course.Domain.Commands.CustomerCommands.Outputs;
using Cruz1974Course.Domain.Entities;
using Cruz1974Course.Domain.Repositories;
using Cruz1974Course.Domain.Services;
using Cruz1974Course.Domain.ValueObjects;
using Cruz1974Course.Shared.Commands;
using FluentValidator;
using System;

namespace Cruz1974Course.Domain.Handles
{
    public class CustomerHandler : Notifiable, ICommandHandler<CreateCustomerCommand>
    {
        private ICustomerRepository _customerRepository;
        private IEmailService       _emailService;

        public CustomerHandler(ICustomerRepository customerRepository, IEmailService emailService)
        {
            _customerRepository = customerRepository;
            _emailService       = emailService;
        }

        public ICommandResult Handle(CreateCustomerCommand command)
        {
            // Verificar se o cpf já existe
            DocumentExists(command.Document);

            // Verificar se o e-mail já existe
            EmailExists(command.Email);

            // Criar os VOs
            var name     = new Name(command.FirstName, command.LastName);
            var document = new Document(command.Document);
            var email    = new Email(command.Email);

            // Criar entidade
            var customer = new Customer(name, document, email, command.Phone);

            AddNotifications(customer.Notifications);

            // Persistir o customer
            _customerRepository.Save(customer);

            // Enviar o e-mail de boas vindas
            _emailService.Send(customer.Email.Address, "hello@cruz.io", "Seja bem vindo", "Obrigado por se cadastrar");

            // Retornar o resultado para a tela
            return new CreateCustomerCommandResult(Guid.NewGuid(), name.ToString(), email.Address);
        }

        private void DocumentExists(string document)
        {
            if (_customerRepository.CheckDocument(document))
                AddNotification("CPF", "CPF já existe na base de dados");
            // Ou eu coloco um nível acima e retorno null
            
        }

        private void EmailExists(string email)
        {
            if (_customerRepository.CheckEmail(email))
                AddNotification("Email", "Email já existe na base de dados");
        }
    }
}
