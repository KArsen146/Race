using System;

namespace ConsoleApplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Camel c = new Camel();
            Race r = new Race(30000);
            CamelFast cf = new CamelFast();
            Mortar m = new Mortar();
            Broom br = new Broom();
            MagicCarpet car = new MagicCarpet();
            Centaur centaur = new Centaur();
            AllTerrainBoots b = new AllTerrainBoots();
            r.Add(car);
            r.Add(br);
            r.Add(c);
            r.Add(m);
            r.Add(centaur);
            r.Add(b);
            r.Add(cf);
            Console.WriteLine(r.Simulate().GetName());
        }
    }
}