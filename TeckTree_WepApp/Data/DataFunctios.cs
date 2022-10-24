using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TeckTree_WepApp.Entities;

namespace TeckTree_WepApp.Data
{
    public class DataFunctios : IDataFunctions
    {
        private readonly ApplicationDbContext _context;
        public DataFunctios(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task UpdateUserCategoryEntityAsync(List<UserCategory> userCategoryItemsToDelete, List<UserCategory> userCategoryItemsToAdd)
        {

            using (var dbContextTransaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {

                    _context.RemoveRange(userCategoryItemsToDelete);
                    await _context.SaveChangesAsync();

                    if (userCategoryItemsToAdd != null)
                    {
                        _context.AddRange(userCategoryItemsToAdd);
                        await _context.SaveChangesAsync();
                    }
                    await dbContextTransaction.CommitAsync();

                }
                catch (Exception ex)
                {
                    await dbContextTransaction.DisposeAsync();
                }

            }
        }
    }
}
