﻿using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities
{
    public class Feedback
    {
        public int Id { get; set; }
        public virtual Order Order { get; set; }
        public int OrderId { get; set; }
        [Required]
        public int Stars { get; set; }
        public string Comment { get; set; }
    }
}