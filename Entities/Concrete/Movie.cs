using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Movie : IEntity
    {
        [Key]
        public int MovieId { get; set; }
        public string Name { get; set; } 
        public int CategoryId { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
    }
}
