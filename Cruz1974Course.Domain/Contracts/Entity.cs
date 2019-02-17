using FluentValidator;
using System;

namespace Cruz1974Course.Domain.Contracts
{
    public abstract class Entity : Notifiable
    {

        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
    }
}
