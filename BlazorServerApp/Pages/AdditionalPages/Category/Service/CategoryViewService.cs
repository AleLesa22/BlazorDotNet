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

        public async Task DeleteCategory(string CategoryId, HttpClient httpClient)
        {
            Guid CategoryIdGuid = Guid.Parse(CategoryId);
            var result = await httpClient.DeleteAsync($"https://localhost:7127/api/Category?Id={CategoryIdGuid}");
        }
    }
}
