using System;

namespace hw5
{
    class Program
    {
        static void Main(string[] args)
        {
            var fabrics = new FabricsParseUnitData(new LoadFromFile());
            fabrics.AddFabric(new FabricForMage());
            fabrics.AddFabric(new FabricForInfantry());
            fabrics.Parse("data.dat");
            Console.ReadKey();
        }
    }
}
