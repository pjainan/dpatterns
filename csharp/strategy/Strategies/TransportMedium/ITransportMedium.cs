using System;
namespace StrategyPattern
{
    interface ITransportMedium
    {
        public void displayMedium(){
            Console.WriteLine("Interface Definition - Transport Medium Implementation");
        }
    }
}