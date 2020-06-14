using System;
namespace ObserverPattern
{
    interface ITransportMediumAvailability
    {
        void Attach(ITransportService transportMedium);
        void Detach(ITransportService transportMedium);
        void NotifyTransportService();

    }
}