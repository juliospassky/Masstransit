using System.Threading.Tasks;
using Contracts;
using MassTransit;
using Microsoft.Extensions.Logging;

namespace Company.Consumers
{
    public class GettingStartedConsumer :
        IConsumer<HelloMessage>
    {
        readonly ILogger<GettingStartedConsumer> _logger;

        public GettingStartedConsumer(ILogger<GettingStartedConsumer> logger)
        {
            _logger = logger;
        }

        public Task Consume(ConsumeContext<HelloMessage> context)
        {
            _logger.LogInformation("Hello {Name}", context.Message.Name);
            return Task.CompletedTask;
        }
    }
}
