using PostSharp.Patterns.Diagnostics.Audit;
using System;
using System.Collections.Generic;
using System.Text;
using PostSharp.Patterns.Diagnostics;
using PostSharpSpeeltuin.Implementation.Models;

namespace PostSharpSpeeltuin.Implementation.Audits
{
    public class ExtendedAuditRecord : AuditRecord
    {
        public List<CustomerModel> RelatedCustomerModels { get; } = new List<CustomerModel>();

        public ExtendedAuditRecord(Type declaringType, string memberName, LogRecordKind recordKind) : base(declaringType, memberName, recordKind)
        {
        }
    }
}
