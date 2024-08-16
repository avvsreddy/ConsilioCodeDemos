using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeHubPortal.Domain.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage ="Please enter category")]
        [MinLength(3)]
        [MaxLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        [Required(ErrorMessage ="Please enter description")]
        public string Description { get; set; }

    }
}
