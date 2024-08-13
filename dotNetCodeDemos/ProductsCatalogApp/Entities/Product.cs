using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsCatalogApp.Entities
{
    //[Table("tbl_products")]
    public class Product // POCO
    {
        //[Key]
        public int ProductId { get; set; } // Primary Key
        //[Required]
        //[MaxLength(10)]
        public string Name { get; set; }
        //[Column("Rate")]
        //[Range(1000,100000)]
        public int Price { get; set; }
      
        public string Brand { get; set; }
        public string Country { get; set; }
        public virtual Catagory Catagory { get; set; } 

    }
    public class Catagory
    {
        public int CatagoryId { get; set; }
        public string CatagoryName { get; set; }
    }
}
