using Azure.Messaging.EventHubs;
using Azure.Messaging.EventHubs.Producer;
using Newtonsoft.Json;
using System.Text;

string connectionString = "Hidded Information"

string eventHubName = "turbine-telemetry";





await using var producerClient = new EventHubProducerClient(connectionString, eventHubName);

Random random = new Random();

Console.WriteLine("Sending wind turbine telemetry...");
Console.WriteLine("Press Ctrl+C to stop.");

while (true)
{
    bool urgent = random.Next(1, 6) == 1;

    var telemetry = new
    {
        DeviceId = "TURBINE-" + random.Next(1, 4),
        MeasureTime = DateTime.UtcNow,
        GeneratedPower = urgent ? random.Next(1, 4) : random.Next(6, 20),
        WindSpeed = urgent ? random.Next(16, 25) : random.Next(5, 14),
        TurbineSpeed = random.Next(80, 160)
    };

    string json = JsonConvert.SerializeObject(telemetry);

    using EventDataBatch eventBatch = await producerClient.CreateBatchAsync();
    eventBatch.TryAdd(new EventData(Encoding.UTF8.GetBytes(json)));

    await producerClient.SendAsync(eventBatch);

    Console.WriteLine(json);

    await Task.Delay(3000);
}
