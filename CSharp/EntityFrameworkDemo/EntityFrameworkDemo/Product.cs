using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    [Table("ProductDetails")]
    internal class Product
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [StringLength(20)]
        public string ProductName { get; set; }
        [Column("ProductBrand")]
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
}
