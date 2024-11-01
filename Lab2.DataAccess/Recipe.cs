﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.DataAccess
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string DishName { get; set; }

        [Required]
        [StringLength(50)]
        public string Category { get; set; }

        [Required] 
        [StringLength(20)]
        public string PrepTime { get; set; }

        public List<Ingredient> Ingredients { get; } = new();
    }
}
