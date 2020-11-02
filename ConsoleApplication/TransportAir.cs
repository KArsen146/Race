namespace ConsoleApplication
{
    abstract public class TransportAir: Transport
    {
        abstract protected double DistanceReducer(double distance);
        public override double FinishTime(double distance)
        {
            var newDistance = DistanceReducer(distance);
            return newDistance / Speed;
        }
        public TransportAir(double speed, string name)
        {
            Speed = speed;
            Name = name;
        }
    }
    public class MagicCarpet : TransportAir
    {
        protected override double DistanceReducer(double distance)
        {
            if (distance <= 1000)
                return distance;
            if (distance <= 5000)
                return distance * 0.97;
            if (distance <= 10000)
                return distance * 0.9;
            return distance * 0.95;
        }

        public MagicCarpet() : base(10, "MagicCarpet")
        { }
    }
    public class Mortar : TransportAir
    {
        protected override double DistanceReducer(double distance)
        {
            return distance * 0.94;
        }

        public Mortar() : base(8, "Mortar")
        { }
    }
    public class Broom : TransportAir
    {
        protected override double DistanceReducer(double distance)
        {
            double newDistance = 0;
            while (distance > 1000)
            {
                distance -= 1000;
                newDistance += 1000;
                distance = distance * 0.99;
            }
            newDistance += distance;
            return newDistance;
        }
        public Broom() : base(20, "Broom")
        {}
    }
}