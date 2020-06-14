using System;
// Import our pattern Namespace
using ObserverPattern;

namespace observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! -  This is implementation of Observer Pattern");
            
            //Instantiating the Transport Medium Availability Service
            TransportAvailabilityCheckService checkService =  new TransportAvailabilityCheckService();
            ITransportService landTS = new  LandTransportService(checkService);

            //Subscribe to the Observable, i.e., The land Transport service will attach to the transport availability service to get status update.
            checkService.Attach(landTS);

            //transport availability service notify all the attached subscribers.
            checkService.informAll();
          
            // Unsubscribe to the observable, therefore, this service will stop recieving the updates.
            checkService.Detach(landTS);
            // Validate by running informAll(), the landTS object will not recieve further status updates from the Availability Service.
            checkService.informAll();
        
        }
    }
}
