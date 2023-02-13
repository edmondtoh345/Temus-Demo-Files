using System.ComponentModel.DataAnnotations;

namespace CRUDApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        [StringLength(10, MinimumLength = 5)]
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
}
