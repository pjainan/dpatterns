using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decided to explore Land Transportation Medium");
            Transport landTransport = new Transport(new LandTransportMedium());
            landTransport.ShowTransportSelection();

            Console.WriteLine("Decided to explore Air Transportation Medium");
            Transport airTransport = new Transport(new AirTransportMedium());
            airTransport.ShowTransportSelection();
            
            Console.WriteLine("Decided to explore Water Transportation Medium");
            Transport waterTransport = new Transport(new WaterTransportMedium());
            waterTransport.ShowTransportSelection();
        }
    }
}
