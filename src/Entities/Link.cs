using System;

namespace Entities
{
    public class Link
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public string Phone { get; set; }
        public bool isAvailable { get; set; }
        public string Tags { get; set; }
    }
}