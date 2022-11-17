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
    }
}
