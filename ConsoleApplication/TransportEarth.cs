namespace ConsoleApplication
{
    abstract public class TransportEarth : Transport
    {
        protected double RestInterval;
        protected abstract double RestDuration(int i);
        public TransportEarth(double speed, double restinterval, string name)
        {
            Speed = speed;
            RestInterval = restinterval;
            Name = name;
        }
        public override double FinishTime(double distance)
        {
            int countRest = (int)(distance / (Speed * RestInterval));
            double time = distance / Speed;
            for (int i = 0; i < countRest; i++)
                time += RestDuration(i);
            return time;
        }
    }
    public class Camel : TransportEarth
    {
        protected override double RestDuration(int i)
        {
            switch (i)
            {
                case 0:
                    return 5;
                default:
                    return 8;
            }
        }

        public Camel():base(10, 30, "Camel")
        { }
    }
    public class CamelFast : TransportEarth
    {
        protected override double RestDuration(int i)
        {
            switch (i)
            {
                case 0:
                    return 5;
                case 1:
                    return 6.5;
                default:
                    return 8;
            }
        }

        public CamelFast():base(40,10, "CamelFast")
        { }
    }
    public class Centaur : TransportEarth
    {
        protected override double RestDuration(int i)
        {
            return 2;
        }

        public Centaur() : base(15,8, "Centaur")
        { }
    }
    public class AllTerrainBoots : TransportEarth
    {
        protected override double RestDuration(int i)
        {
            switch (i)
            {
                case 0:
                    return 5;
                default:
                    return 8;
            }
        }

        public AllTerrainBoots() :base(6,60, "AllTerrainBoots")
        { }
    }
}
   