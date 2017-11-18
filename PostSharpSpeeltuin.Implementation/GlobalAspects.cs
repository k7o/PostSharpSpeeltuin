using PostSharp.Patterns.Diagnostics;
using PostSharp.Extensibility;
using PostSharp.Patterns.Diagnostics.Audit;

[assembly: Log(AttributePriority = 1, AttributeTargetMemberAttributes = MulticastAttributes.Protected | MulticastAttributes.Internal | MulticastAttributes.Public)]
[assembly: Log(AttributePriority = 2, AttributeExclude = true, AttributeTargetMembers = "get_*")]

