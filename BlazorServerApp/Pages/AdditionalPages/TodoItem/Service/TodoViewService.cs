using BlazorServerApp.Models;

namespace BlazorServerApp.Pages.AdditionalPages.TodoItem.Service
{
    public class TodoViewService
    {
        public static List<CategoryDTO> categories = new List<CategoryDTO>();
        public static List<UserDTO> users = new List<UserDTO>();

        public async Task InsertTodo(string Title, string Description, bool IsDone, string CategoryId, string UserId, HttpClient httpClient)
        {
            categories = await httpClient.GetFromJsonAsync<List<CategoryDTO>>("https://localhost:7127/api/Categories");
            users = await httpClient.GetFromJsonAsync<List<UserDTO>>("https://localhost:7127/api/Users");

            TodoItemDTO newTodoItem = new TodoItemDTO();
            CategoryDTO cat = new CategoryDTO();
            cat = categories.First(x => x.Id == CategoryId);
            UserDTO usr = new UserDTO();
            usr = users.First(x => x.Id == UserId);

            newTodoItem.Id = Guid.NewGuid().ToString();
            newTodoItem.Title = Title;
            newTodoItem.Description = Description;
            newTodoItem.IsDone = IsDone;
            newTodoItem.Category = cat;
            newTodoItem.User = usr; ;

            var result = await httpClient.PostAsJsonAsync("https://localhost:7127/api/TodoItem", newTodoItem);
        }
    }
}
