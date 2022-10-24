using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeckTree_WepApp.Entities
{
    public class Content
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250, MinimumLength = 2)]
        public string Title { get; set; }
        [Display(Name ="HTML Content")]
        public string HtmlContent { get; set; }

        [Display(Name ="Video Link")]
        public string VideoLink { get; set; }

        public CategoryItem CategoryItems { get; set; }

        [NotMapped]
        public int CatItemId { get; set; }

        [NotMapped]
        public int CategoryId { get; set; }

    }
}
