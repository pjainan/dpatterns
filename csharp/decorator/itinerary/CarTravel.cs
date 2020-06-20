using System;

namespace decorator
{
    class CarTravel : IRoadTravel // Decorator "IS" a relationship with Travel Itinerary.
    {
        private IItinerary itinerary = null;
        public CarTravel(IItinerary i)
        {
            // Decorator "HAS" a relationship with Travel Itinerary.
            this.itinerary = i;
        }
        public int returnDistance()
        {
            // decorating happens here. 
            //The base distance is added to the distance to be travelled using the Car for the itinerary.
            return this.itinerary.returnDistance() + 300;
        }
    }
}
