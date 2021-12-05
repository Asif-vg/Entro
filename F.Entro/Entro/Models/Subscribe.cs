using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Entro.Models
{
    public class Subscribe
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        public string Title { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }



    }
}
