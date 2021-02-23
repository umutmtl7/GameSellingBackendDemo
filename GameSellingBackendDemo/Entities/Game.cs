using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingBackendDemo.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
