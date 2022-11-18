using BlazorServerApp.Pages.AdditionalPages.TodoItem.Service;

namespace BlazorServerApp.Pages.AdditionalPages.TodoItem.Store
{
    public class TodoStore
    {
        public async Task InsertTodoStore(string Title, string Description, bool IsDone, string CategoryId, string UserId, HttpClient httpClient)
        {
            TodoViewService todoViewService = new TodoViewService();
            todoViewService.InsertTodo(Title, Description, IsDone, CategoryId, UserId, httpClient);
        }


        public async Task DeleteTodoStore(string TodoId, HttpClient httpClient)
        {
            TodoViewService todoViewService = new TodoViewService();
            todoViewService.DeleteTodo(TodoId, httpClient);
        }
    }
}
