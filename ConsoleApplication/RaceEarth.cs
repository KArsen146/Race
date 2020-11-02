namespace ConsoleApplication
{
    public class RaceEarth : Race
    {
        public RaceEarth(double d) : base(d) { }
        
        override public void Add(Transport transport)
        {
            Add<TransportEarth>(transport);
        }
    }
}