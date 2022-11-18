using BlazorServerApp.Pages.AdditionalPages.Category.Service;

namespace BlazorServerApp.Pages.AdditionalPages.Category.Store
{
    public class CategoryStore
    {
        public async Task InsertCategoryStore(string Name, HttpClient httpClient)
        {
            CategoryViewService categoryViewService = new CategoryViewService();
            categoryViewService.InsertCategory(Name, httpClient);
        }
        public async Task DeleteCategoryStore(string CategoryId, HttpClient httpClient)
        {
            CategoryViewService categoryViewService = new CategoryViewService();
            categoryViewService.DeleteCategory(CategoryId, httpClient);
        }

        public async Task UpdateCategoryStore(string CategoryId, string Name, HttpClient httpClient)
        {
            CategoryViewService categoryViewService = new CategoryViewService();
            categoryViewService.UpdateCategory(CategoryId, Name, httpClient);
        }
    }
}
