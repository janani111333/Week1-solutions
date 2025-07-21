using Confluent.Kafka;
using System;
using System.Threading;

class KafkaConsumer
{
    public void StartListening()
    {
        var config = new ConsumerConfig
        {
            BootstrapServers = "localhost:9092",
            GroupId = "chat-consumer-group",
            AutoOffsetReset = AutoOffsetReset.Earliest
        };

        using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
        consumer.Subscribe("test-topic");

        Console.WriteLine("Listening for messages...");
        while (true)
        {
            var cr = consumer.Consume(CancellationToken.None);
            Console.WriteLine($"Received: {cr.Message.Value}");
        }
    }
}
