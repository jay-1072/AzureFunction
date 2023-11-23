using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace QueueDemo
{
    public class Function1
    {
        [FunctionName("Function1")]
        public void Run([QueueTrigger("myqueue-items", Connection = "Conn")]string myQueueItem, ILogger log)
        {
            myQueueItem = "Hello";

            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
