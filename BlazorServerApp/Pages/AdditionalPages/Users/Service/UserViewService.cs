﻿using BlazorServerApp.Models;

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
            httpClient.PostAsJsonAsync("https://localhost:7127/api/User", newUser);
        }

        public async Task DeleteUser(string UserId, HttpClient httpClient)
        {
            Guid UserIdGuid = Guid.Parse(UserId);
            var result = await httpClient.DeleteAsync($"https://localhost:7127/api/User?Id={UserIdGuid}");
        }
    }
}
