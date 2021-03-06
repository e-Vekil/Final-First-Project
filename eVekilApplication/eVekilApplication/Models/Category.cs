﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eVekilApplication.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PhotoPath { get; set; }
        public bool Visibilty { get; set; }
        [NotMapped]
        public string Description1 { get; set; }
        [NotMapped]
        public string Description2 { get; set; }
    }
}
