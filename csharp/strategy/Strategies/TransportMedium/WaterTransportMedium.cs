using System;

namespace StrategyPattern
{
    class WaterTransportMedium : ITransportMedium
    {
        public void displayMedium(){
            Console.WriteLine("Water Transport Medium Definition - Water Transport Concrete Implementation");
        }
    }
    
}