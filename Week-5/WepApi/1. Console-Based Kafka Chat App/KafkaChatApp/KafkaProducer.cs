using Confluent.Kafka;
using System;
using System.Threading.Tasks;

class KafkaProducer
{
    public async Task SendMessage(string message)
    {
        var config = new ProducerConfig { BootstrapServers = "localhost:9092" };

        using var producer = new ProducerBuilder<Null, string>(config).Build();
        var result = await producer.ProduceAsync("test-topic", new Message<Null, string> { Value = message });

        Console.WriteLine($"Sent: '{message}' to {result.TopicPartitionOffset}");
    }
}
