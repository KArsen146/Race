namespace ConsoleApplication
{
    public abstract class Transport
    {
        protected string Name;
        protected double Speed;
        
        public string GetName()
        {
            return Name;
        }
        public abstract double FinishTime(double distance);
    }
}