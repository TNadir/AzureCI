using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Microsoft.WindowsAzure.Storage.Blob;

namespace NcAppFuncs
{
    public static class ImageAnalysis
    {
        [FunctionName("ImageAnalysis")]
        public static void Run([BlobTrigger("images/{name}", Connection = "ncappfuncs")]CloudBlockBlob blob, string name, ILogger log)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{blob.Name} \n Size: {blob.Properties.Length} Bytes");
        }
    }
}
