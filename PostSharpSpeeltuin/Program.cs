using System;
using PostSharp.Patterns.Diagnostics;
using PostSharp.Patterns.Diagnostics.Backends.Serilog;
using Serilog;
using PostSharp.Patterns.Diagnostics.Audit;
using PostSharpSpeeltuin.Implementation.Models;
using PostSharpSpeeltuin.Implementation.Repositories;
using PostSharpSpeeltuin.Implementation.Audits;

namespace PostSharpSpeeltuin
{
    class Program
    {

        static void Main(string[] args)
        {
            // Configure Serilog.
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.File("serilog.log")
                .WriteTo.ColoredConsole()
                .CreateLogger();

            // Configure PostSharp Logging to use Serilog
            LoggingServices.DefaultBackend = new SerilogLoggingBackend();
            LoggingServices.Roles[LoggingRoles.Audit].Backend = new ExtendedAuditBackend();

            AuditServices.RecordPublished += delegate (object o, AuditRecordEventArgs e)
            {
                Log.Debug(e.Record.Text);
            };

            var customer = new CustomerModel();
            customer.SetFullName("Eric", "Kerst");
            var customerRepository = new CustomerRepository();
            customerRepository.Insert(customer);
            customerRepository.Insert(customer);

            Console.ReadLine();
        }
    }
}
