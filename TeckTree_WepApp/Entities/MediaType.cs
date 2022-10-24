using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TeckTree_WepApp.Interfaces;

namespace TeckTree_WepApp.Entities
{
    public class MediaType : IPrimaryProperties
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250, MinimumLength = 2)]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Thumb Nail Image Path")]
        public string ThumbnaImagePath { get; set; }

        [ForeignKey("MediaTybeId")]
        public virtual ICollection<CategoryItem> CategoryItems { get; set; }
    }
}
