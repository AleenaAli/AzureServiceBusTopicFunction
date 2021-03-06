using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace AzureServiceBusTopicFunction
{
    public static class GetMessage
    {
        [FunctionName("GetMessage")]
        public static void Run([ServiceBusTrigger("orderstopic", "subscriptionA", Connection = "ServiceBusConn")]string mySbMsg, ILogger log)
        {
            log.LogInformation($"C# ServiceBus topic trigger function processed message: {mySbMsg}");
        }
    }
}
