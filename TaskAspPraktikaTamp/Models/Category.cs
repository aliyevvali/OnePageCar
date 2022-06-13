using System.Collections.Generic;

namespace TaskAspPraktikaTamp.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Car> Car{ get; set; }
    }
}
