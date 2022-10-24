using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TeckTree_WepApp.Data;
using TeckTree_WepApp.Entities;
using TeckTree_WepApp.Models;

namespace TeckTree_WepApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<ApplicationUSer> _signInManager;
        private readonly UserManager<ApplicationUSer> _userManager;


        public HomeController(ILogger<HomeController> logger , ApplicationDbContext context , SignInManager<ApplicationUSer> signInManager, UserManager<ApplicationUSer> userManager)
        {
            _logger = logger;
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<CategoryItemDatailsModel> categoryItemDetailsModels = null;
            IEnumerable<GroupedCategoryItemsByCategoryModel> groupedCategoryItemsByCategoryModels = null;
            CategoryDetailsModel categoryDetailsModel = new CategoryDetailsModel();
            if (_signInManager.IsSignedIn(User))
            {
                var user = await _userManager.GetUserAsync(User);
                if(user != null)
                {
                    categoryItemDetailsModels = await GetCategoryItemDetailsForUser(user.Id);
                    groupedCategoryItemsByCategoryModels = GetGroupedCategoryItemsByCategory(categoryItemDetailsModels);
                    categoryDetailsModel.GroupedCategoryItemsByCategoryModels = groupedCategoryItemsByCategoryModels;
                }
            }
            else
            {
                var categories = await GetCategoriesThatHaveContent();
                categoryDetailsModel.Categories = categories;
            }
            return View(categoryDetailsModel);
        }

        private async Task<List<Category>> GetCategoriesThatHaveContent()
        {
            var categoriesWithContent = await (from cat in _context.Category
                                               join catitem in _context.CategoryItem
                                               on cat.Id equals catitem.CategoryId
                                               join cont in _context.Content
                                               on catitem.Id equals cont.CategoryItems.Id
                                               select new Category
                                               {
                                                   Id = cat.Id,
                                                   Title = cat.Title,
                                                   Description = cat.Description,
                                                   ThumbnaImagePath = cat.ThumbnaImagePath
                                               }).Distinct().ToListAsync();
            return categoriesWithContent;
        }
        private IEnumerable<GroupedCategoryItemsByCategoryModel> GetGroupedCategoryItemsByCategory(IEnumerable<CategoryItemDatailsModel> categoryItemDetailsModels)
        {
            return from item in categoryItemDetailsModels
                   group item by item.CategoryId into g
                   select new GroupedCategoryItemsByCategoryModel
                   {
                       Id = g.Key,
                       Title = g.Select(c => c.CategoryTitle).FirstOrDefault(),
                       Items = g
                   };
        }
        private async Task<IEnumerable<CategoryItemDatailsModel>> GetCategoryItemDetailsForUser(string userId)
        {
            return await (from catItem in _context.CategoryItem
                          join category in _context.Category
                          on catItem.CategoryId equals category.Id
                          join content in _context.Content
                          on catItem.Id equals content.CategoryItems.Id
                          join userCat in _context.UserCategory
                          on category.Id equals userCat.CategoryId
                          join mediaType in _context.MediaType
                          on catItem.MediaTybeId equals mediaType.Id
                          where userCat.UserId == userId
                          select new CategoryItemDatailsModel
                          {
                              CategoryId = category.Id,
                              CategoryTitle = category.Title,
                              CategoryItemId = catItem.Id,
                              CategoryItemTitle = catItem.Title,
                              CategoryItemDescription = catItem.Description,
                              MediaImagePath = mediaType.ThumbnaImagePath
                          }).ToListAsync();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
