using PostSharp.Patterns.Diagnostics.Backends.Audit;
using PostSharp.Patterns.Diagnostics.RecordBuilders;
using System;
using System.Collections.Generic;
using System.Text;

namespace PostSharpSpeeltuin.Implementation.Audits
{
    public class ExtendedAuditBackend : AuditBackend
    {
        public override LogRecordBuilder CreateRecordBuilder()
        {
            return new ExtendedAuditRecordBuilder(this);
        }
    }
}
