using System;
using PostSharp.Patterns.Model;
using PostSharp.Patterns.Contracts;
using PostSharp.Patterns.Diagnostics;
using PostSharp.Patterns.Diagnostics.Audit;

namespace PostSharpSpeeltuin.Implementation.Models
{
    public class CustomerModel
    {
        public string Fullname { get; private set; }

        public void SetFullName([Required] string firstName, [Required] string lastName)
        {
            Fullname = $"{firstName} {lastName}";
        }
    }
}
