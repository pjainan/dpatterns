using System;
using System.Collections.Generic;
namespace ObserverPattern
{
    class TransportAvailabilityCheckService : ITransportMediumAvailability
    {
        public string Availability { get; set; } = "Not Available";
        private List<ITransportService> lstTransportServiceObservers = new List<ITransportService>();

        public void Attach(ITransportService transportMedium)
        {
            Console.WriteLine("Attaching Obeserver - Transport Service");
            this.lstTransportServiceObservers.Add(transportMedium);
        }

        public void Detach(ITransportService transportMedium)
        {
            Console.WriteLine("Detaching Obeserver - Transport Service");
            this.lstTransportServiceObservers.Remove(transportMedium);
        }

        public void NotifyTransportService()
        {
            Console.WriteLine("Transport Availablity service updating to all the transport service");
            foreach (ITransportService instance in lstTransportServiceObservers)
            {
                instance.updateMedium();
            }
        }

        public void informAll()
        {
            this.Availability = "Available";
            this.NotifyTransportService();
        }
    }
}
