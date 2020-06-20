using System;

namespace decorator
{
    class CarPool : IRoadTravel // Decorator "IS" a relationship with Travel Itinerary.
    {
        private IItinerary itinerary = null;
        public CarPool(IItinerary i)
        {
            // Decorator "HAS" a relationship with Travel Itinerary.
            this.itinerary = i;
        }
        public int returnDistance()
        {
            // decorating happens here. 
            //The base distance is added to the distance to be travelled using the CarPool for the itinerary.
            return this.itinerary.returnDistance() + 112;
        }
    }
}
