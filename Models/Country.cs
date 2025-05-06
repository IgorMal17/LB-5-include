using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLoadingIncludeLoad.Models
{
    internal class Country
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int CapitalId { get; set; }
        // столица страны
        public City? Capital { get; set; }  
        public List<Company> Companies { get; set; } = new();
    }
}
