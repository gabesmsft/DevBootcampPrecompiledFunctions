using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using System.IO;

namespace DevBootcampPrecompiledFunctions
{
    public static class QueueTrigger1
    {
        [FunctionName("QueueTrigger1")]
        public static void Run([QueueTrigger("fakeq", Connection = "AzureWebJobsStorage")]string myQueueItem, ILogger log)
        {
            throw new FileNotFoundException(@"fake thrown exception");
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
