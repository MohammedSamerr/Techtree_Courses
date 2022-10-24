using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.VisualBasic;

namespace TeckTree_WepApp.Entities
{
    public class CategoryItem
    {
        private DateTime _releaseDate = DateTime.MinValue;
        public int Id { get; set; }

        [Required]
        [StringLength(250, MinimumLength = 2)]
        public string Title { get; set; }
        public string Description { get; set; }

        public int CategoryId { get; set; }

        [Required(ErrorMessage ="Please Select a Vaild Item From The '{0}' Dropdown List")]
        [Display(Name ="Media Type")]
        public int MediaTybeId { get; set; }

        [NotMapped]
        public virtual ICollection<SelectListItem> MediaTypes { get; set; }

        
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Release Date")]
        public DateTime DateTimeItemRealeased
        {
            get
            {
                return (_releaseDate == DateTime.MinValue) ? DateTime.Now : _releaseDate;
            }
            set
            {
                _releaseDate = value;
            }

        }

        [NotMapped]
        public int ContentId { get; set; }

    }
}
