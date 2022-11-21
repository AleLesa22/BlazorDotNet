using BlazorServerApp.Models;

namespace BlazorServerApp.Pages.AdditionalPages.Category.Service
{
    public class CategoryViewService
    {
        public static List<CategoryDTO> categories = new List<CategoryDTO>();
        public async Task InsertCategory(string Name, HttpClient httpClient)
        {
            CategoryDTO newCategory = new CategoryDTO();
            newCategory.Id = Guid.NewGuid().ToString();
            newCategory.Name = Name;
            httpClient.PostAsJsonAsync("http://localhost:1234/api/Category", newCategory);
        }

        public async Task DeleteCategory(string CategoryId, HttpClient httpClient)
        {
            Guid CategoryIdGuid = Guid.Parse(CategoryId);
            var result = await httpClient.DeleteAsync($"http://localhost:1234/api/Category?Id={CategoryIdGuid}");
        }

        public async Task UpdateCategory(string CategoryId, string Name, HttpClient httpClient)
        {
            CategoryToUpdateDTO newCategory = new CategoryToUpdateDTO();
            Guid CategoryIdGuid = Guid.Parse(CategoryId);
            newCategory.Id = CategoryIdGuid;
            newCategory.Name = Name;
            var result = await httpClient.PutAsJsonAsync("http://localhost:1234/api/Category", newCategory);
        }
    }
}
