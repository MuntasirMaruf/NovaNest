using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaNestDAL.EF.Tables
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(600)]
        public string Description { get; set; }

        [Required]
        public int Category { get; set; }


        public int? Color { get; set; }

        public int Size { get; set; }

        public double Price { get; set; }

        public int? Quantity { get; set; }

        public int? Status { get; set; }

        public DateTime? Created {  get; set; }

        public DateTime? Updated { get; set; }
    }
}
