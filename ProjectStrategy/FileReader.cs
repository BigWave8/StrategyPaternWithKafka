namespace ProjectStrategy
{
    internal class FileReader
    {
        public static List<string> ReadFromFile(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                List<string> list = new();
                while (!reader.EndOfStream)
                {
                    list.Add(reader.ReadLine());
                }
                return list;
            }
        }
    }
}
