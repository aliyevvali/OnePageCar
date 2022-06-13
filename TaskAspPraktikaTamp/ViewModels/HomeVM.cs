using System.Collections.Generic;
using TaskAspPraktikaTamp.Models;

namespace TaskAspPraktikaTamp.ViewModels
{
    public class HomeVM
    {
        public List<Category> Categories{ get; set; }
        public List<Car>Cars { get; set; }
    }
}
