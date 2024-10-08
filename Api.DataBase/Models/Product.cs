using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.DataBase.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid TypeId { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }

        public virtual TypeProduct TypeProduct { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        
    }
}
