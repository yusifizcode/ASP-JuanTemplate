using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JuanTemplate.Models
{
    public class HomeSlider
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:50)]
        public string Subtitle { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string Title { get; set; }
        public string Desc { get; set; }
        public string Image { get; set; }
        [Required]
        public string BtnText { get; set; }
        public string BtnURL { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
