using PostSharp.Patterns.Diagnostics.Audit;
using PostSharp.Patterns.Diagnostics.Backends.Audit;
using PostSharp.Patterns.Diagnostics.Contexts;
using PostSharp.Patterns.Diagnostics.RecordBuilders;
using PostSharp.Patterns.Formatters;
using PostSharpSpeeltuin.Implementation.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PostSharpSpeeltuin.Implementation.Audits
{
    public class ExtendedAuditRecordBuilder : AuditRecordBuilder
    {
        public ExtendedAuditRecordBuilder(AuditBackend backend) : base(backend)
        {
        }

        protected override AuditRecord CreateRecord(LoggingContext context, ref LogRecordInfo recordInfo, ref LogMemberInfo memberInfo)
        {
            return new ExtendedAuditRecord(context.Source.SourceType, memberInfo.MemberName, recordInfo.RecordKind);
        }

        public override void SetParameter<T>(int index, string parameterName, ParameterDirection direction, string typeName, T value,
            IFormatter<T> formatter)
        {
            var customerModel = value as CustomerModel;

            if (customerModel != null)
            {
                ((ExtendedAuditRecord)this.CurrentRecord).RelatedCustomerModels.Add(customerModel);
            }

            base.SetParameter(index, parameterName, direction, typeName, value, formatter);
        }
    }
}
