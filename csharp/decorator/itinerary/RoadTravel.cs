using System;

namespace decorator
{
    class RoadTravel: IItinerary
    {
        public int returnDistance()
        {
            return 200;
        }
    }
}
