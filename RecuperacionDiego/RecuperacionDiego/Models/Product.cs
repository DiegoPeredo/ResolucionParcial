using System;
using System.ComponentModel.DataAnnotations;

namespace RecuperacionDiego.Models
{
    public class Product
    {
        [Key]
        [Range(1, 99999, ErrorMessage = "Ingrese un número entre 1 a 99999")]
        public int ProductId { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime LastBuy { get; set; }


    }
}