using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Models
{
    public abstract class BaseEntity
    {
        
        public DateTime CreatedAt { get; set; }

        [MaxLength(50)]
        public string CreatedBy { get; set; }


        public DateTime? UpdatedAt { get; set; }

        [MaxLength(50)]
        public string? UpdatedBy { get; set; }
    }
}
