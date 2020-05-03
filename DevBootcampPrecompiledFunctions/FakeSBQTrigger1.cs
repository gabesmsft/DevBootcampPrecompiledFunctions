using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Microsoft.Azure.ServiceBus;
using System.Threading.Tasks;
using System.Threading;
using System.Text;

namespace DevBootcampPrecompiledFunctions
{
    public static class SBTrigger1
    {
        [FunctionName("FakeSBQTrigger1")]
        public static void Run([ServiceBusTrigger("fakesbq", Connection = "fakeSBconn")]Message myQueueItem, ILogger log)
        {
            Thread.Sleep(75000);
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {Encoding.UTF8.GetString(myQueueItem.Body)}");
            log.LogInformation($"SequenceNumber: {myQueueItem.SystemProperties.SequenceNumber}");
        }
    }
}
