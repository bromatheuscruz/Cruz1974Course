using System;
using System.Collections.Generic;
using System.Text;

namespace Cruz1974Course.Domain.ValueObjects
{
    public class Document
    {
        public Document(string number)
        {
            Number = number;
        }

        public string Number { get; private set; }

        public override string ToString()
        {
            return Number.ToString();
        }
    }
}
