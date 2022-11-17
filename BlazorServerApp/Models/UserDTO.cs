namespace BlazorServerApp.Models
{
    public class UserDTO
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserDTO(string Id, string FirstName, string LastName)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public UserDTO()
        {

        }
    }
}
