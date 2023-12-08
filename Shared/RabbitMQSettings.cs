﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    static public class RabbitMQSettings
    {
        //_ öncesi burada  tanımlanan kuyrugu kullanacak servisi gösteirr içerisinde order created ile ilgili veriler var
        public const string Stock_OrderCreatedEventQueue = "stock-order-craeted-event-queue";
        public const string Payment_StockReservedEventQueue = "payment-stock-reserved-event-queue";
        public const string Order_PaymentCompletedEventQueue = "order-payment-completed-event-queue";
        public const string Order_StockNotReservedEventQueue = "order-stock-not-reserved-event-queue";
        public const string Order_PaymentFailedEventQueue = "order-payment-failed-event-queue";

    }
}
