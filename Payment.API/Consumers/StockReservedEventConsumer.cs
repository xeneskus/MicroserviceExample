using MassTransit;
using Shared.Events;
using Shared.Events.Common;

namespace Payment.API.Consumers
{
    public class StockReservedEventConsumer : IConsumer<StockReservedEvent>
    {
        readonly IPublishEndpoint _publishEndpoint;

        public StockReservedEventConsumer(IPublishEndpoint publishEndpoint)
        {
            _publishEndpoint = publishEndpoint;
        }

        public Task Consume(ConsumeContext<StockReservedEvent> context)
        {
            //ödeme işlemleri
            if (true)
            {
                //ödemenin başarıyla tamamlandığı
                PaymentCompletedEvent paymentCompletedEvent = new()
                {
                    OrderId = context.Message.OrderId
                };
                _publishEndpoint.Publish(paymentCompletedEvent);
                Console.WriteLine("Ödeme Başarılı..");
            }
            else
            {
                PaymentFailedEvent paymentFailedEvent = new()
                {
                    OrderId = context.Message.OrderId,
                    Message = "Bakiye yetersiz.."
                    
                };
                _publishEndpoint.Publish(paymentFailedEvent);
                Console.WriteLine("Ödeme Başarısız..");

            }
            return Task.CompletedTask;
        }


    }
}
