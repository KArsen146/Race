using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class RaceException : Exception
    {
        public RaceException(string message)
            : base(message)
        {}
    }
    public class Race
    {
        protected readonly double Distance;
        protected readonly List<Transport> Partisipants;

        public Race(double d)
        {
            Distance = d;
            Partisipants = new List<Transport>();
        }

        protected void Add<T> (Transport transport)
        {
            try
            {
                if (transport is T)
                    Partisipants.Add(transport);
                else
                    throw new RaceException("Transport has incorrect type");
            }
            catch (RaceException e)
            {
                Console.WriteLine(e);
            }
        }

        public virtual void Add(Transport transport)
        {
            this.Add<Transport>(transport);
        }
        public Transport Simulate()
        {
            try
            {
                Transport winner = null;
                double winnerTime = Double.MaxValue;
                foreach (var t in Partisipants)
                {
                    if (t.FinishTime(Distance) < winnerTime)
                    {
                        winner = t;
                        winnerTime = t.FinishTime(Distance);
                    }
                }
                if (winner == null)
                    throw new RaceException("No partisipants");
                return winner;
            }
            catch (RaceException e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }
}