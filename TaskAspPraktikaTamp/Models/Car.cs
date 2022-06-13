using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskAspPraktikaTamp.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int DoorCout { get; set; }
        public double Price { get; set; }
        public bool RentACar { get; set; }
        public int Luggage { get; set; }
        public string Transmission { get; set; }
        public int MyProperty { get; set; }
        public bool AirConditioning { get; set; }
        public int MinimumAge { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
