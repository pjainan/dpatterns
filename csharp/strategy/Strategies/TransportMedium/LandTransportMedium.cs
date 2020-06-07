using System;

namespace StrategyPattern
{
    class LandTransportMedium : ITransportMedium
    {
        public void displayMedium(){
            Console.WriteLine("Land Transport Medium Definition - Land Transport Concrete Implementation");
        }
    }
    
}