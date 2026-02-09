namespace AM.ApplicationCore.Domain
{
    public class Plane
    {
        //Version Java
        // private int capacity;
        // public int getCapacity()
        // {
        //     return capacity;
        // }
        // public void setCapacity(int capacity)
        // {
        //     this.capacity = capacity;
        // }
        public int PlaneId { get; set; }
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public PlaneType PlaneType { get; set; }

        public ICollection<Flight> Flights { get; set; }

        // Constructeur paramétré (Q8)
        public Plane(PlaneType pt, int capacity, DateTime date)
        {
            PlaneType = pt;
            Capacity = capacity;
            ManufactureDate = date;
        }

        // Constructeur par défaut (implicite ou explicite)
        public Plane() { }

        public override string ToString()
        {
            return $"PlaneId: {PlaneId}, Capacity: {Capacity}, ManufactureDate: {ManufactureDate}, PlaneType: {PlaneType}";
        }

    }
}
