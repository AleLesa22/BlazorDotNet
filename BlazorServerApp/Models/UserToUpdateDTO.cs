namespace BlazorServerApp.Models
{
    public class UserToUpdateDTO
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserToUpdateDTO(Guid Id, string FirstName, string LastName)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public UserToUpdateDTO()
        {

        }
    }
}
