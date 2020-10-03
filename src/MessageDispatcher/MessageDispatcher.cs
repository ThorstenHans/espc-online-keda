using System;
using System.IO;
using System.Text.Json;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using MessageDispatcher.Models;

namespace MessageDispatcher
{
    public static class MessageDispatcher
    {
        [FunctionName("MessageDispatcher")]
        public static void Run(
            [QueueTrigger("aaa-transformed", Connection = "ESPC2020StorageAccount")] string queueItem,
            [Blob("processed/{rand-guid}.json", FileAccess.Write, Connection = "ESPC2020StorageAccount")] Stream processedBlob,
            ILogger log)
        {
            log.LogInformation("Processing transformed Message");

            var task = JsonSerializer.Deserialize<TransformedMessage>(queueItem, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            if (task != null)
            {
                var numberOfKittens = task.ExtractNumberOfKittens();
                using (var writer = new StreamWriter(processedBlob))
                {
                    writer.Write(JsonSerializer.Serialize(new
                    {
                        Id = Guid.NewGuid(),
                        NumberOfKittens = numberOfKittens,
                        AreaRequirements = $"{numberOfKittens * 0.75}qm"
                    }, new JsonSerializerOptions
                    {
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                    }));
                    log.LogInformation("Message destructed and processed");
                }
                return;
            }
            log.LogWarning("Cant process am empty message");
        }
    }
}
