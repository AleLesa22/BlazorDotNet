using BlazorServerApp.Models;

namespace BlazorServerApp.Pages.AdditionalPages.Users.Service
{
    public class UserViewService
    {
        public async Task InsertUser(string FirstName, string LastName, HttpClient httpClient)
        {
            UserDTO newUser = new UserDTO();
            newUser.Id = Guid.NewGuid().ToString();
            newUser.FirstName = FirstName;
            newUser.LastName = LastName;
            httpClient.PostAsJsonAsync("http://localhost:1234/api/User", newUser);
        }

        public async Task DeleteUser(string UserId, HttpClient httpClient)
        {
            Guid UserIdGuid = Guid.Parse(UserId);
            var result = await httpClient.DeleteAsync($"http://localhost:1234/api/User?Id={UserIdGuid}");
        }

        public async Task UpdateUser(string UserId, string FirstName, string LastName, HttpClient httpClient)
        {
            UserToUpdateDTO newUser = new UserToUpdateDTO();
            Guid UserIdGuid = Guid.Parse(UserId);
            newUser.Id = UserIdGuid;
            newUser.FirstName = FirstName;
            newUser.LastName = LastName;
            var result = await httpClient.PutAsJsonAsync("http://localhost:1234/api/User", newUser);
        }
    }
}
