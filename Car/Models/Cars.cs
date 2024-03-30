using Car.Models;

namespace CarsName.Models
{
    public class Cars
    {
        public int Id { get; set; }
        public string CarName { get; set; }
        public List<CarBody> CarBodies { get; set; }
    }
}
