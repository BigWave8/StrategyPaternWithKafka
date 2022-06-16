namespace ProjectStrategy
{
    internal class Strategy
    {
        private IStrategy _strategy;
        public Strategy(){}
        public Strategy(IStrategy strategy)
        {
            _strategy = strategy;
        }
        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }
        public void DoStrategy(List<string> text)
        {
            _strategy.WriteText(text);
        }
    }
}
