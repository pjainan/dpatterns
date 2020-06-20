using System;

namespace decorator
{
    interface IRoadTravel : IItinerary
    {
       
        public int returnDistance()
        {
            return 100;
        }
    }
}
