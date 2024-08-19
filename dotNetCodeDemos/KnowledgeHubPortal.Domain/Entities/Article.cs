using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeHubPortal.Domain.Entities
{
    public class Article
    {
        public int ArticleId { get; set; }
        [Required]
        [MinLength(6)]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
        [Required]
        [Url]
        public string ArticleUrl { get; set; }
        //[ForeignKey("Category")]
        public int CategoryId  { get; set; }
        public Category Category { get; set; }
        public bool IsApproved { get; set; }
        //[Required]
        public string SubmitedBy { get; set; }
        public DateTime DateSubmited { get; set; }
    }
}
