using System;
namespace ObserverPattern
{
    interface ITransportService
    {
        void updateMedium()
        {
            Console.WriteLine("This update messagge is from IObserver");
        }
    }
}