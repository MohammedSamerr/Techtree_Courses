using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TeckTree_WepApp.Interfaces;

namespace TeckTree_WepApp.Entities
{
    public class Category :IPrimaryProperties
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string Title { get; set; }
        public string Description { get; set; }

        [Required]
        [Display(Name = "Thumb nail Image Path")]
        public string ThumbnaImagePath { get; set; }

        [ForeignKey("CategoryId")]
        public virtual ICollection<CategoryItem> CategoryItems { get; set; }

        [ForeignKey("CategoryId")]
        public virtual ICollection<UserCategory> UserCategory { get; set; }

        
    }
}
