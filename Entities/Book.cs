using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using secbackend.Entities.Base;

namespace secbackend.Entities
{
    public class Book : Thing
    {
        public required string Titel { get; set; }
        public string? Writer { get; set; }
        public string? Publisher { get; set; }
        public double Price { get; set; }
    }
}