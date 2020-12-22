using System;

namespace Entities
{
    public class CarTrims
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public int carModelId { get; set; }
        public bool isAvailable { get; set; }
    }
}