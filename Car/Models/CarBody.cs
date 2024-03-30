using CarsName.Models;

namespace Car.Models
{
    public class CarBody
    {
        public int CarId { get; set; } 
        public Cars Car { get; set; }
        public int BodyId { get; set; }
        public Body Body { get; set; }

    }
}
