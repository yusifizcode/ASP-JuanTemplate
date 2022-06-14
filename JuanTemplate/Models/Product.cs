using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JuanTemplate.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double SalePrice { get; set; }
        public double CostPrice { get; set; }
        public double DiscountPercent { get; set; }
        public string Desc { get; set; }
        public string Image { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
    }
}
