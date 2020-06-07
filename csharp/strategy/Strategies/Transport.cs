using System;


namespace StrategyPattern
{
    class Transport
    {
        private ITransportMedium _transportMedium;
        public Transport(){}

        public Transport(ITransportMedium transportMedium){
            this._transportMedium = transportMedium;
        }
        public void setTransportMedium(ITransportMedium transportMedium)
        {
            this._transportMedium = transportMedium;
        }

        public void ShowTransportSelection()
        {
            Console.WriteLine("The Medium of Transport is: " + this._transportMedium);
            this._transportMedium.displayMedium();
        }
    }
    
}