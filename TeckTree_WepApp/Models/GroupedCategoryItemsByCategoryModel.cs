using System.Linq;

namespace TeckTree_WepApp.Models
{
    public class GroupedCategoryItemsByCategoryModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public IGrouping<int, CategoryItemDatailsModel> Items { get; set; }

    }
}
