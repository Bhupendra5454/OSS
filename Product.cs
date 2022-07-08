using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TFLWebApp.Models
{

    //POCO class
    //Entity Class
    //Data Annotations defined metadata for class or field, or property

    [Table("Products")]
    public class Product
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }

        [Range(minimum:4, maximum:4000)]
        public int Quantity { get; set; }
        
   

    }
}