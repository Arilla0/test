using System;

namespace Entities
{
    public class CarVariant
    {
        public int ID { get; set; }
        public String engine { get; set; }
        public FuelTypes FuelTypes { get; set; }
        public GearTypes GearTypes { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public bool isAvailable { get; set; }
        public int carTrimId { get; set; }
    }
}