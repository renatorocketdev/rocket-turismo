﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rocket_api.Models
{
    public class Categories
    {
        [Key]
        [Column("categoriesId")]
        public int CategoriesId { get; set; }

        [Required]
        [Column("name")]
        [StringLength(64)]
        public string Name { get; set; }

        [Required]
        [Column("icon")]
        public byte[] Icon { get; set; }
    }
}