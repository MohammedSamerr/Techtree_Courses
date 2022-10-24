using System.Collections.Generic;
using System.Threading.Tasks;
using TeckTree_WepApp.Entities;

namespace TeckTree_WepApp.Data
{
    public interface IDataFunctions
    {
        Task UpdateUserCategoryEntityAsync(List<UserCategory> userCategoryItemsToDelete, List<UserCategory> userCategoryItemsToAdd);
    }
}
