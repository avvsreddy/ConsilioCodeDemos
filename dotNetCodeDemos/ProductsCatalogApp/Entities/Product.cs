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
        public virtual List<Supplier> Suppliers { get; set; }

    }
    public class Catagory
    {
        public int CatagoryId { get; set; }
        public string CatagoryName { get; set; }

        public virtual List<Product> Products { get; set; }
    }

    public class Supplier : Person
    {
      
        public string GST { get; set; }
        public int Rating { get; set; }
        public virtual List<Product> Products { get; set; }
    }

    abstract public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
       
    }

    public class Customer : Person
    {
        public int Discount { get; set; }
        [Required]
        public Address Address { get; set; }
    }

    [ComplexType]
    public class Address
    {
        //public int Id { get; set; }
        public string Area { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }
}
