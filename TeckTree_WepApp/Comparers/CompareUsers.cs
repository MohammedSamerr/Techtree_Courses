using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using TeckTree_WepApp.Areas.Admin.Models;

namespace TeckTree_WepApp.Comparers
{
    public class CompareUsers : IEqualityComparer<UserModel>
    {
        public bool Equals(UserModel x, UserModel y)
        {
            if (y == null) return false;

            if (x.Id == y.Id)
                return true;

            return false;

        }

        public int GetHashCode([DisallowNull] UserModel obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}