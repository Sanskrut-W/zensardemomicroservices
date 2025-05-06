using MassTransit;
using OrederService.Models;

namespace OrederService.Messaging
{
    public class OrderPublisher
    {
        private readonly IPublishEndpoint _endpoint;

        public OrderPublisher(IPublishEndpoint endpoint)
        {
            _endpoint = endpoint;
        }

        public async Task PublishOrderAsync(Order order)
        {
            await _endpoint.Publish(order);
        }
    }
}
