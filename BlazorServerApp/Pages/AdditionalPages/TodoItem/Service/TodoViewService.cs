using BlazorServerApp.Models;

namespace BlazorServerApp.Pages.AdditionalPages.TodoItem.Service
{
    public class TodoViewService
    {
        public static List<CategoryDTO> categories = new List<CategoryDTO>();
        public static List<UserDTO> users = new List<UserDTO>();
        public static List<TodoItemDTO> todoItems = new List<TodoItemDTO>();

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
            newTodoItem.User = usr;

            var result = await httpClient.PostAsJsonAsync("https://localhost:7127/api/TodoItem", newTodoItem);
        }

        public async Task DeleteTodo(string TodoId, HttpClient httpClient)
        {
            Guid TodoIdGuid = Guid.Parse(TodoId);
            var result = await httpClient.DeleteAsync($"https://localhost:7127/api/TodoItem?Id={TodoIdGuid}");
        }

        public async Task UpdateTodo(string TodoId, string Title, string Description, bool IsDone, string CategoryId, string UserId, HttpClient httpClient)
        {
            categories = await httpClient.GetFromJsonAsync<List<CategoryDTO>>("https://localhost:7127/api/Categories");
            users = await httpClient.GetFromJsonAsync<List<UserDTO>>("https://localhost:7127/api/Users");

            TodoItemToUpdateDTO TodoItemToUpdate = new TodoItemToUpdateDTO();
            CategoryDTO cat = new CategoryDTO();
            cat = categories.First(x => x.Id == CategoryId);
            UserDTO usr = new UserDTO();
            usr = users.First(x => x.Id == UserId);

            TodoItemToUpdate.Id = Guid.Parse(TodoId);
            TodoItemToUpdate.Title = Title;
            TodoItemToUpdate.Description = Description;
            TodoItemToUpdate.IsDone = IsDone;
            TodoItemToUpdate.Category = cat;
            TodoItemToUpdate.User = usr;

            var result = await httpClient.PutAsJsonAsync("https://localhost:7127/api/TodoItem", TodoItemToUpdate);
        }
    }
}
