using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.DataBase.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public bool IsClient { get; set; }
        public bool IsProvider { get; set; }
        public string FIO { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
