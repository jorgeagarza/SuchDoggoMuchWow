using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuchDoggoMuchWow.Models.Entities
{
    public class Dog
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(25)]
        [Required]
        public string Breed { get; set; }
        [MinLength(1)]
        [Required]
        public string Name { get; set; }
    }
}
