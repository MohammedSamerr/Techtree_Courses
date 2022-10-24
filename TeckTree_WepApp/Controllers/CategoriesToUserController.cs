using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TeckTree_WepApp.Data;
using TeckTree_WepApp.Entities;
using TeckTree_WepApp.Models;

namespace TeckTree_WepApp.Controllers
{
    [Authorize]
    public class CategoriesToUserController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUSer> _userManager;
        private readonly IDataFunctions _dataFunctions;

        public CategoriesToUserController(ApplicationDbContext context , UserManager<ApplicationUSer> userManager, IDataFunctions dataFunctions)
        {
            _context = context;
            _userManager = userManager;
            _dataFunctions = dataFunctions;
            _dataFunctions = dataFunctions;
        }
        public async Task<IActionResult> Index()
        {
            //opject from Categories To User Model model
            CategoriesToUserModel categoriesToUserModel = new CategoriesToUserModel();
            var userId = _userManager.GetUserAsync(User).Result?.Id;
            categoriesToUserModel.Categories = await GetCategoriesThatHaveContent();
            categoriesToUserModel.CategoriesSelected = await GetCategoriesCurrentlySavedForUser(userId);
            categoriesToUserModel.UserId = userId;
            return View(categoriesToUserModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(string[] categoriesSelected)
        {
            var userId = _userManager.GetUserAsync(User).Result?.Id;

            List<UserCategory> userCategoriesToDelete = await GetCategoriesToDeleteForUser(userId);
            List<UserCategory> userCategoriesToAdd = GetCategoriesToAddForUser(categoriesSelected, userId);

            await _dataFunctions.UpdateUserCategoryEntityAsync(userCategoriesToDelete, userCategoriesToAdd);

            return RedirectToAction("Index", "Home");
        }

            private async Task<List<Category>> GetCategoriesThatHaveContent()
        {
            var categoriesThatHaveContent = await (from categ in _context.Category
                                                   join catitem in _context.CategoryItem
                                                   on categ.Id equals catitem.CategoryId
                                                   join cont in _context.Content
                                                   on catitem.Id equals cont.CategoryItems.Id
                                                   select new Category
                                                   {
                                                       Id = categ.Id,
                                                       Title = cont.Title,
                                                       Description = categ.Description,

                                                   }).Distinct().ToListAsync();
            return categoriesThatHaveContent;
        }

        private async Task<List<Category>> GetCategoriesCurrentlySavedForUser(string userId)
        {
            var categoriesCurrentlySavedForUser = await (from usercateg in _context.UserCategory
                                                         where usercateg.UserId == userId
                                                         select new Category
                                                         {
                                                             Id = usercateg.CategoryId 
                                                         }).ToListAsync();
            return categoriesCurrentlySavedForUser;
        }
        private async Task<List<UserCategory>> GetCategoriesToDeleteForUser(string userId)
        {
            var categoriesToDelete = await (from usercateg in _context.UserCategory
                                            where usercateg.UserId == userId
                                            select new UserCategory
                                            {
                                                ID = usercateg.ID,
                                                UserId = userId,
                                                CategoryId = usercateg.CategoryId
                                                
                                            }).ToListAsync();
            return categoriesToDelete;
        }
        
        private List<UserCategory> GetCategoriesToAddForUser(string[] categoriesSelected,string userId)
        {
            var categoriesToAdd =  (from categoryId in categoriesSelected
                                    select new UserCategory
                                    {
                                        UserId = userId,
                                        CategoryId = int.Parse(categoryId)
                                    }).ToList() ;

            return categoriesToAdd;
        }
    }
}
