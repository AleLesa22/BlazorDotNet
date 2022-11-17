using BlazorServerApp.Models;

namespace BlazorServerApp.Pages.AdditionalPages.TodoItem.Service
{
    public class TodoViewService
    {

        public static List<CategoryDTO> categories = new List<CategoryDTO>();
        public static List<UserDTO> users = new List<UserDTO>();
        public async Task InsertTodo(string Title, string Description, bool IsDone, string CategoryId, string UserId, HttpClient httpClient)
        {
            TodoItemDTO newTodoItem = new TodoItemDTO();
            CategoryDTO Cat = new CategoryDTO();
            UserDTO Usr = new UserDTO();

            HttpClient httpClientGetUsers = new HttpClient();
            HttpClient httpClientGetCategories = new HttpClient();
            HttpClient newHttpCLIENT = new HttpClient();

            categories = await httpClientGetCategories.GetFromJsonAsync<List<CategoryDTO>>("https://localhost:7127/api/Categories");
            users = await httpClientGetUsers.GetFromJsonAsync<List<UserDTO>>("https://localhost:7127/api/Users");

            newTodoItem.Id = Guid.NewGuid().ToString();
            newTodoItem.Title = Title;
            newTodoItem.Description = Description;
            newTodoItem.IsDone = IsDone;

            Cat = categories.First(x => x.Id == CategoryId);
            Usr = users.First(x => x.Id == UserId);

            newTodoItem.Category = Cat;
            newTodoItem.User = Usr;

            newTodoItem.Category.Id = Cat.Id;
            newTodoItem.Category.Name = Cat.Name;
            newTodoItem.User.Id = Usr.Id;
            newTodoItem.User.FirstName = Usr.FirstName;
            newTodoItem.User.LastName = Usr.LastName;

            var result = await newHttpCLIENT.PostAsJsonAsync("https://localhost:7127/api/TodoItem", newTodoItem);
        }
    }
}
