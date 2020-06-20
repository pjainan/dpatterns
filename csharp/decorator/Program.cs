using System;
namespace decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting with the Decorator Pattern");
            //Create the object of the concrete IItinerary i.e. RoadTravel (this can be SeaTravel - accordingly decorator can vary and defined)
            RoadTravel objRoadTravel = new RoadTravel();
            //The base RoadTravel baseline distance is :
            Console.WriteLine("RoadTravel baseline distance is: " + objRoadTravel.returnDistance().ToString());


            // Start Decorating
            Console.WriteLine("Start Decorating. \nAdding different transport medium to itinerary.");
            // Composition : Road Travel Itinerary now 'HAS' a BusTravel. ONLY.
            BusTravel bsTravel = new BusTravel(objRoadTravel);
            //Calculate the distance with addition of Bus Travel to the base RoadTravel
            Console.WriteLine("RoadTravel distance is (with Bus Travel): " + bsTravel.returnDistance().ToString());

            // Similarly 
            // Composition : Road Travel Itinerary now 'HAS' a Car Travel. ONLY.
            CarTravel carTravel = new CarTravel(objRoadTravel); // see the base RoadTravel object being passed.
            //Calculate the distance with addition of Car Travel to the base RoadTravel
            Console.WriteLine("RoadTravel distance is (with Car Travel): " + carTravel.returnDistance().ToString());

            Console.WriteLine("\n More deep into decoration with composition - \"HAS\" a relationship");
            Console.WriteLine("Adding BusTravel with CarPool travel to the base RoadTravel");
            
            BusTravel bsTravel1 = new BusTravel(objRoadTravel);
            // Observe the wrapping of object here. CarPool Travel "HAS" a BusTravel.
            // BusTravel "IS" a type of Itinerary ;-)
            CarPool crpoolTravel = new CarPool(bsTravel1); 
             //Calculate the distance with addition of Bus Travel AND CarPool Travel to the base RoadTravel
            Console.WriteLine("RoadTravel distance is (with Bus + CarPool Travel): " + crpoolTravel.returnDistance().ToString());
            Console.WriteLine("Validate from the concrete implementation of returnDistance() of RoadTravel, CarPool and BusTravel classes");
            Console.WriteLine("200 + 550 + 112 = " + crpoolTravel.returnDistance().ToString());
        }
    }
}
