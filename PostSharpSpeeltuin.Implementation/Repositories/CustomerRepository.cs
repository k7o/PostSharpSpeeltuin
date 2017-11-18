using PostSharp.Patterns.Contracts;
using PostSharp.Patterns.Diagnostics.Audit;
using PostSharpSpeeltuin.Implementation.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PostSharpSpeeltuin.Implementation.Repositories
{
    public class CustomerRepository
    {
        [Audit]
        public void Insert([Required] CustomerModel customer)
        {
            Console.Write("Insert customer");
        }
    }
}
