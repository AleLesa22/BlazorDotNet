using BlazorServerApp.Pages.AdditionalPages.TodoItem.Service;

namespace BlazorServerApp.Pages.AdditionalPages.TodoItem.Store
{
    public class TodoStore
    {
        public async Task InsertTodoStore(string Title, string Description, bool IsDone, string CategoryId, string CategoryName, string UserId, string UserFirstName, string UserLastName, HttpClient httpClient)
        {
            TodoViewService todoViewService = new TodoViewService();
            todoViewService.InsertTodo(Title, Description, IsDone, CategoryId, CategoryName, UserId, UserFirstName, UserLastName, httpClient);
        }
    }
}
