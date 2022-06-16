using ProjectStrategy;

const string ConfigFileName = "config.cfg";
const string DefaultFileName = "FileForRead.csv";
const string KafkaConfig = "Kafka";
const string ConsoleConfig = "Console";
var config = LoadConfig();
var text = FileReader.ReadFromFile(DefaultFileName);
Strategy strategy = new();
if (Equals(config, KafkaConfig))
{
    strategy.SetStrategy(new KafkaWriter());
}
else if (Equals(config, ConsoleConfig))
{
    strategy.SetStrategy(new ConsoleWriter());
}
else
{
    throw new Exception("Not found config");
}
strategy.DoStrategy(text);

string LoadConfig() => File.ReadAllLines(ConfigFileName)[0];