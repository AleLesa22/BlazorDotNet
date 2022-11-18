using BlazorServerApp.Pages.AdditionalPages.Users.Service;

namespace BlazorServerApp.Pages.AdditionalPages.Users.Store
{
    public class UserStore
    {
        public async Task InsertUserStore(string FirstName, string LastName, HttpClient httpClient)
        {
            UserViewService userViewService = new UserViewService();
            userViewService.InsertUser(FirstName, LastName, httpClient);
        }

        public async Task DeleteUserStore(string UserId, HttpClient httpClient)
        {
            UserViewService userViewService = new UserViewService();
            userViewService.DeleteUser(UserId, httpClient);
        }

        public async Task UpdateUserStore(string UserId, string FirstName, string LastName, HttpClient httpClient)
        {
            UserViewService userViewService = new UserViewService();
            userViewService.UpdateUser(UserId, FirstName, LastName, httpClient);
        }
    }
}
