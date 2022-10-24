using System.Collections.Generic;
using TeckTree_WepApp.Entities;

namespace TeckTree_WepApp.Models
{
    public class CategoriesToUserModel
    {
        public string UserId { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ICollection<Category> CategoriesSelected { get; set; }
    }
}
