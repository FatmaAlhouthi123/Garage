namespace Garage {
    public interface IVehcle {
        public string RegisterNumber { get; set; }
        public string Color { get; set; }
        public int WheelsNumber { get; set; }
        public V_Type VehcleType { get; set; }


    }
}