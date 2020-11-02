namespace ConsoleApplication
{
    public class RaceAir : Race
    {
        public RaceAir(double d) : base(d) { }
        
        override public void Add(Transport transport)
        {
            Add<TransportAir>(transport);
        }
    }
}