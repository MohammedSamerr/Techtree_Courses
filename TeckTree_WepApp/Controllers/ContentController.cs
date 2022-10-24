using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TeckTree_WepApp.Data;
using TeckTree_WepApp.Entities;


namespace TeckTree_WepApp.Controllers
{
    public class ContentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContentController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int categoryItemId)
        {
            Content content = await (from item in _context.Content
                                     where item.CategoryItems.Id == categoryItemId
                                     select new Content
                                     {
                                         Title = item.Title,
                                         VideoLink = item.VideoLink,
                                         HtmlContent = item.HtmlContent
                                     }).FirstOrDefaultAsync();
            return View(content);
        }
    }
}
