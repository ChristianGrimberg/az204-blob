using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using System;
using System.IO;
using System.Threading.Tasks;

namespace az204_blob
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Azure Blob Storage exercise\n");

            // Run the examples asynchronously, wait for the results before proceeding
            ProcessAsync().GetAwaiter().GetResult();

            Console.WriteLine("Press enter to exit the sample application.");
            Console.ReadLine();
        }

        private static async Task ProcessAsync()
        {
            // Copy the connection string from the portal in the variable below.
            string storageConnectionString = "DefaultEndpointsProtocol=https;AccountName=novocaplearn;AccountKey=8YD3OKgqvK8KkjjM5WK13u2wNwqCjlavN1axRm+XvuI/H/3etUqewU0kp+qQ0CPyw6Pfc2945mk7+AStIN56JQ==;EndpointSuffix=core.windows.net";

            // Create a client that can authenticate with a connection string
            BlobServiceClient blobServiceClient = new BlobServiceClient(storageConnectionString);

            // EXAMPLE CODE STARTS BELOW HERE


        }
    }
}
