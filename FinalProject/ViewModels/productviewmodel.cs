using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
    public class productviewmodel
    {
        public string Name { get; set; }
        public double price { get; set; }
        public string description { get; set; }

        public IFormFile Picture { get; set; }
    }
}
