using BlazorServerApp.Models;

namespace BlazorServerApp.Pages.AdditionalPages.Category.Service
{
    public class CategoryViewService
    {
        public async Task InsertCategory(string Name, HttpClient httpClient)
        {
            CategoryDTO newCategory = new CategoryDTO();
            newCategory.Id = Guid.NewGuid().ToString();
            newCategory.Name = Name;
            httpClient.PostAsJsonAsync("https://localhost:7127/api/Category", newCategory);
        }
    }
}
