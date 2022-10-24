using System.Collections.Generic;

namespace TeckTree_WepApp.Areas.Admin.Models
{
    public class UsersCategoryListModel
    {
        public int CategoryId { get; set; }
        //contain all registred users in the system
        public ICollection<UserModel> Users { get; set; }
        //contain users in the system that have particular category
        public ICollection<UserModel> UsersSelected { get; set; }

    }
}
