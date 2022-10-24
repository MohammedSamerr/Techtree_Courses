using System.Collections.Generic;
using TeckTree_WepApp.Entities;

namespace TeckTree_WepApp.Models
{
    public class CategoryDetailsModel
    {
        public IEnumerable<GroupedCategoryItemsByCategoryModel> GroupedCategoryItemsByCategoryModels { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
