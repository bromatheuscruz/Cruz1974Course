using System;
using System.Collections.Generic;
using System.Text;

namespace Cruz1974Course.Domain.ValueObjects
{
    public class Name
    {
        public Name(string firstName, string lastName)
        {
            FirsName = firstName;
            LastName = lastName;
        }

        public string FirsName { get; private set; }

        public string LastName { get; private set; }

        public override string ToString()
        {
            return $"{FirsName} {LastName}";
        }

    }
}
