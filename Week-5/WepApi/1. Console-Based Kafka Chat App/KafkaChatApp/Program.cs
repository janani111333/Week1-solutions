using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Type 'send' to produce or 'receive' to consume:");
        var input = Console.ReadLine();

        if (input == "send")
        {
            var producer = new KafkaProducer();
            while (true)
            {
                Console.Write("Message: ");
                var msg = Console.ReadLine();
                await producer.SendMessage(msg??"0");
            }
        }
        else if (input == "receive")
        {
            var consumer = new KafkaConsumer();
            consumer.StartListening();
        }
    }
}
