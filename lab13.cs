namespace mepw
{
    internal class program
    {
        static void Main(string[] args)
        {
            Flight.FlightsList();
            Flight.FlightInfo();

        }
    }

    class Flight
    {
        static public List<Flight> flightsList = new List<Flight>(Flight.FlightsList());
        private long _flightNumber { get; set; }
        private DateTime DepartureTime { get; set; }
        private DateTime _arrivalTime { get; set; }
        private int _price { get; set; }

        public DateTime ArrivalTime
        {
            get
            {
                return _arrivalTime;
            }
            set
            {
                if (value < DepartureTime)
                {
                    Console.WriteLine("Invalid value Arrival time");
                }
                else
                {
                    _arrivalTime = value;
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
                if (value < 0)
                {
                    Console.WriteLine("We are not doing it for free");
                }
                else
                {
                    _price = value;
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

       

        static public List<Flight> FlightsList()

        {
            Flight flight1 = new Flight(1000000, new DateTime(2026, 5, 4, 19, 30, 00), new DateTime(2026, 5, 5, 7, 30, 00), 5000);
            Flight flight2 = new Flight(1000001, new DateTime(2026, 7, 4, 13, 00, 00), new DateTime(2026, 7, 5, 23, 30, 00), 9000);
            List<Flight> flights = new List<Flight>();
            flights.Add(flight1);
            flights.Add(flight2);

            return flights;
        }
        static public string Comparer()
        {
            
            TimeSpan meow = flightsList[1].FlightDuration - flightsList[0].FlightDuration;
            return meow.TotalHours.ToString();
        }
        static public void FlightInfo()
        {

            Console.WriteLine("HIIII");
            Console.WriteLine(flightsList.Count);
            Console.WriteLine($"Press I to see info");
            ConsoleKeyInfo cki = Console.ReadKey();
            if(cki.Key == ConsoleKey.I)
            {
                
                foreach (var item in flightsList)
                {
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    Console.WriteLine($"Flight number: {item._flightNumber}\n Departure Time: {item.DepartureTime} \n Arrival Time: {item.ArrivalTime} \n Price: {item.Price} \n Flight Duration: {item.FlightDuration} ");
                    Console.WriteLine("--------------------------------------------------------------------------------");
                }
            }
            Console.WriteLine("If you want to compare two flights press C");
            ConsoleKeyInfo cki1 = Console.ReadKey();
            if(cki1.Key == ConsoleKey.C)
            {
                Console.WriteLine($"{Comparer()} Hours");
            }
        }
    }

}