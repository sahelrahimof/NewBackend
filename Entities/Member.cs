using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using secbackend.Entities.Base;
using secbackend.Enums;

namespace secbackend.Entities
{
    public class Member : Thing
    {
        public required string Firstname { get; set; }
        public required string Lastname { get; set; }
        public Gender Gender { get; set; }
        
    }
}