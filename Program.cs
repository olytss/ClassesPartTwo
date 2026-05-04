namespace mepw
{
    internal class program
    {
        static void Main(string[] args)
        {
        }
    }

    class Flight
    {
        
       private long _flightNumber {  get; set; }
        private DateTime DepartureTime {  get; set; }
        private DateTime _arrivalTime { get; set; }
        private int _price {  get; set; }

      public DateTime ArrivalTime
        {
            get
            {
                return _arrivalTime;
            }
            set
            {
                if(value < DepartureTime)
                {
                    Console.WriteLine("Invalid value Arrival time");
                }
                else
                {
                    ArrivalTime = value;
                }
            }
        }
      public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                if(value< 0)
                {
                    Console.WriteLine("We are not doing it for free"); 
                }
                else
                {
                    Price = value;  
                }
            }
        }
    
        public TimeSpan FlightDuration
        {
            get
            {
                return ArrivalTime - DepartureTime;
            }
        }
        public Flight(long flightnumber, DateTime DepartureTime, DateTime ArrivalTime, int price)
        {
            this._flightNumber = flightnumber;
            this.DepartureTime = DepartureTime;
            this.ArrivalTime = ArrivalTime;
            this.Price = price;
        }

        Flight flight1 = new Flight(1000000, new DateTime(2026, 5, 4, 19, 30, 00), new DateTime(2026, 5, 5, 7, 30, 00), 5000);
        Flight flight2 = new Flight(1000001, new DateTime(2026, 7, 4, 13, 00, 00), new DateTime(2026, 7, 5, 23, 30, 00), 9000);
        static public List<Flight> flights =new List<Flight>();
        
        public List<Flight> FlightsList()
        {
            flights.Add(flight1);
            flights.Add(flight2);
            return flights;
        }
    }

}