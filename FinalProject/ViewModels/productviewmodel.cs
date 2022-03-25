using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project1.ViewModel
{
    public class productviewmodel
    {
        public string Name { get; set; }
        public double price { get; set; }
        public string description { get; set; }

        public IFormFile Picture { get; set; }
    }
}
