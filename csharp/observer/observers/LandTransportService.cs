using System;
namespace ObserverPattern
{
    class LandTransportService : ITransportService
    {
        private TransportAvailabilityCheckService transportAvailabilityState;
        public LandTransportService()
        {
            Console.WriteLine("Do Nothing");
        }
        public LandTransportService(TransportAvailabilityCheckService transportAvailabilityState)
        {
            this.transportAvailabilityState = transportAvailabilityState;
        }
        public void updateMedium()
        {
            Console.WriteLine("This update messagge is from Land Transport Service: " + this.transportAvailabilityState.Availability);
        }
    }
}