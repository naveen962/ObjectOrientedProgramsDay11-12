using Newtonsoft.Json;
using System;

namespace InventoryDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            FetchJson fetchjson = new FetchJson();
            Inventory data=fetchjson.Read("F:/JSON/Inventory.json");
            Console.WriteLine(JsonConvert.SerializeObject(data));



            Console.WriteLine("<-----------Details of Pulses-------------->");
            for ( int i = 0; i < data.TypesOfPulses.Count; i++)
            {
                Console.WriteLine(data.TypesOfPulses[i].name);
                Console.WriteLine(data.TypesOfPulses[i].Price);
                Console.WriteLine(data.TypesOfPulses[i].weight);
                Console.WriteLine("---------------");
            }
            Console.WriteLine("<-----------Details of Rice-------------->");

            for (int i = 0; i < data.TypesOfRice.Count; i++)
            {
                Console.WriteLine(data.TypesOfRice[i].name);
                Console.WriteLine(data.TypesOfRice[i].Price);
                Console.WriteLine(data.TypesOfRice[i].weight);
                Console.WriteLine("---------------");
            }
            Console.WriteLine("<-----------Details of Wheat-------------->");
            for (int i = 0; i < data.TypesOfWheat.Count; i++)
            {
                Console.WriteLine(data.TypesOfWheat[i].name);
                Console.WriteLine(data.TypesOfWheat[i].Price);
                Console.WriteLine(data.TypesOfWheat[i].weight);
                Console.WriteLine("---------------");
            }
        }
    }
}
