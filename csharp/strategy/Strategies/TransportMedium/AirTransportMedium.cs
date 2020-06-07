using System;

namespace StrategyPattern
{
    class AirTransportMedium : ITransportMedium
    {
        public void displayMedium(){
            Console.WriteLine("Air Transport Medium Definition - Air Transport Concrete Implementation");
        }
    }
    
}