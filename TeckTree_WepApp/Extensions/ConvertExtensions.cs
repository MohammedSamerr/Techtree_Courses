using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using TeckTree_WepApp.Interfaces;

namespace TeckTree_WepApp.Extensions
{
    public static class ConvertExtensions
    {
        public static List<SelectListItem> ConvertToSelectList<T>(this IEnumerable<T> collection , int selectedValue) 
                      where T:IPrimaryProperties
        {
            //SelectListItem has three property (text , value , selected )
            return (from item in collection
                    select new SelectListItem
                    {
                        Text = item.Title,
                        Value = item.Id.ToString(),
                        Selected = (item.Id == selectedValue)
                    }).ToList() ;
        }
    }
}
