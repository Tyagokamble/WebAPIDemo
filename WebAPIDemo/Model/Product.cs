using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIDemo.Model
{
    [Table("Product")]  //mapping of table product with class product
    public class Product
    {
        [Key] //primary column
        public int Id{ get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

    }
}
