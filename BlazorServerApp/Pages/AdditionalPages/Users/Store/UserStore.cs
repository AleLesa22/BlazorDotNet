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
    }
}
