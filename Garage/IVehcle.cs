namespace Garage {
    internal interface IVehcle {
        public int RegisterNumber { get; set; }
        public string Color { get; set; }
        public int WheelsNumber { get; set; }
        public V_Type VehcleType { get; set; }


    }
}