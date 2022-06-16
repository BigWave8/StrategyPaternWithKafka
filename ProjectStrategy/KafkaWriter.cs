using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Confluent.Kafka;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ProjectStrategy
{
    internal class KafkaWriter : IStrategy
    {
        private readonly IProducer<Null, string> _producer;
        public KafkaWriter()
        {
            var config = new ProducerConfig()
            {
                BootstrapServers = "localhost:9092"
            };
            _producer = new ProducerBuilder<Null, string>(config).Build();
        }
        public void WriteText(List<string> text)
        {
            foreach (var line in text)
            {
                _producer.ProduceAsync("demo", new Message<Null, string>()
                {
                    Value = line
                });
            }
        }
    }
}
