namespace ProjectStrategy
{
    internal class ConsoleWriter : IStrategy
    {
        public void WriteText(List<string> text)
        {
            foreach (string line in text)
            {
                Console.WriteLine(line);
            }
        }
    }
}
